using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBanhang
{
    public partial class Form_Muahang : Form
    {
        public Form_Muahang()
        {
            InitializeComponent();
        }

        DataTable tblsach;
        DataTable tblnv;
        DataTable tblhd;
        public string txt;
        Hamchung pt = new Hamchung();

        #region "Hàm tính tổng số tiền"
        public void Tinhtien()
        {
            float tongtien = 0;
            for (int i = 0; i < grvGiohang.Rows.Count; i++)
            {
                tongtien += float.Parse(grvGiohang.Rows[i].Cells[4].Value.ToString());
            }
            string tien = tongtien.ToString();
            txtTongtien.Text = tongtien + " VNĐ";
            if (float.Parse(tien) > 0)
                btnGiaodich.Enabled = true;
            else
                btnGiaodich.Enabled = false;
        }
        #endregion

        public void Capnhatdulieu()
        {
            tblnv = pt.GetTable("select MaNV as[Mã NV],Hoten as[Họ tên],Gioitinh as[Giới tính], Scm as[Số CMT], Sdt as[Số ĐT], Diachi as[Địa chỉ] from Nhanvien");
            tblsach = pt.GetTable("select MaSach as[Mã Sách],MaNXB as[Mã NXB],Dongia as[Đơn giá],Soluong as [Số lượng],Mota as[Mô tả], Tensach as[Tên sách] from Sach");
            tblhd = pt.GetTable("select MaHD as[Mã HD],MaNV as[Mã NV],MaKH as[Mã KH],Ngaylap as[Ngày lập] from Hoadon");

            #region "Những thông tin bắt buộc"
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(lblTT1, "Thông tin bắt buộc!");
            tooltip.SetToolTip(lblTT2, "Thông tin bắt buộc!");
            tooltip.SetToolTip(lblTT3, "Thông tin bắt buộc!");
            tooltip.SetToolTip(lblTT4, "Thông tin bắt buộc!");
            #endregion

            #region "Nạp dữ liệu cho combobox"
            //Xóa dữ liệu trên 2 combobox
            cboLoaisach.Items.Clear();
            cboNhanvien.Items.Clear();
            for (int i = 0; i < tblnv.Rows.Count; i++)
            {
                cboNhanvien.Items.Add(tblnv.Rows[i][0] + "|" + tblnv.Rows[i][1]);
            }
            for (int i = 0; i < tblsach.Rows.Count; i++)
            {
                cboLoaisach.Items.Add(tblsach.Rows[i][0] + "|" + tblsach.Rows[i][5]);
            }
            #endregion

            cboLoaisach.SelectedIndex = -1;
            cboNhanvien.SelectedIndex = -1;
            btnGiaodich.Enabled = false;

            txtMahd.Text = "";
            txtMakh.Text = txt;
            txtSoluongmua.Text = "";
            txtTongtien.Text = "";
        }

        private void Form_Muahang_Load(object sender, EventArgs e)
        {
            Capnhatdulieu();
        }

        int soluong_co;
        private void btnThemvaogio_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(txtSoluongmua.Text.Trim(), out n) || cboLoaisach.SelectedIndex < 0 || txtSoluongmua.Text.Length <= 0 || int.Parse(txtSoluongmua.Text.Trim()) <= 0)
                lblThongbao.Text = "Hãy chọn loại sách và số lượng cần mua tối thiểu bằng 1!";
            else
            {
                float dongia = 0;
                int soluong,vt=-1;
                string[] strTT = cboLoaisach.SelectedItem.ToString().Split(new char[] { '|' });
                //Lấy số lượng có sẵn của sản phẩm và vị trí của sản phẩm
                for (int i = 0; i < tblsach.Rows.Count; i++)
                {
                    if (string.Compare(strTT[0], tblsach.Rows[i][0].ToString()) == 0)
                    {
                        soluong_co = int.Parse(tblsach.Rows[i][3].ToString());
                        vt = i;
                    }
                }
                soluong = int.Parse(txtSoluongmua.Text.Trim());
                if (soluong > soluong_co)
                {
                    lblThongbao.Text = "Số lượng \"" + strTT[1] + "\" hiện tại là: " + soluong_co;
                }
                else
                {
                    //Lấy đơn giá của sản phẩm
                    for (int i = 0; i < tblsach.Rows.Count; i++)
                    {
                        if (string.Compare(tblsach.Rows[i][0].ToString(), strTT[0]) == 0)
                            dongia = float.Parse(tblsach.Rows[i][2].ToString());
                    }
                    //Thêm vào giỏ hàng
                    grvGiohang.Rows.Add(strTT[0], strTT[1], soluong, dongia, soluong * dongia);
                    lblThongbao.Text = "";
                    //Số lượng sản phẩm trong kho giảm đi sau khi thêm sp vào giỏ hàng
                    if(vt!=-1)
                        tblsach.Rows[vt][3] = soluong_co-soluong;
                    #region "Gộp những sản phẩm giống nhau trong giỏ hàng"
                    for (int i = 0; i < grvGiohang.Rows.Count; i++)
                    {
                        for (int j = i + 1; j < grvGiohang.Rows.Count; j++)
                        {
                            if (string.Compare(grvGiohang.Rows[i].Cells[0].Value.ToString(), grvGiohang.Rows[j].Cells[0].Value.ToString()) == 0)
                            {
                                grvGiohang.Rows[i].Cells[2].Value = int.Parse(grvGiohang.Rows[i].Cells[2].Value.ToString()) + int.Parse(grvGiohang.Rows[j].Cells[2].Value.ToString());
                                grvGiohang.Rows[i].Cells[4].Value = int.Parse(grvGiohang.Rows[i].Cells[2].Value.ToString()) * float.Parse(grvGiohang.Rows[i].Cells[3].Value.ToString());
                                grvGiohang.Rows.RemoveAt(j);
                            }
                        }
                    }
                    #endregion
                }
                Tinhtien();
            }
        }

        private void grvGiohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sl=0,vitri=-1;
            if (e.ColumnIndex > -1 && grvGiohang.Columns[e.ColumnIndex].Name == "btnGHHuy")
            {
                for (int i = 0; i < tblsach.Rows.Count; i++)
                {
                    if (string.Compare(grvGiohang.Rows[e.RowIndex].Cells[0].Value.ToString(), tblsach.Rows[i][0].ToString()) == 0)
                    {
                        sl = int.Parse(tblsach.Rows[i][3].ToString());
                        vitri = i;
                    }
                }
                if(vitri!=-1)
                    tblsach.Rows[vitri][3] = sl + int.Parse(grvGiohang.Rows[e.RowIndex].Cells[2].Value.ToString());
                grvGiohang.Rows.RemoveAt(e.RowIndex);
                Tinhtien();
            }
        }

        private void txtMahd_TextChanged(object sender, EventArgs e)
        {
            pt.checkdulieu(txtMahd, testMaHD, tblhd);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Form_Muahang_Load(sender, e);
            grvGiohang.Rows.Clear();
        }

        private void btnGiaodich_Click(object sender, EventArgs e)
        {
            int dk1;
            int dk2=0;
            if (pt.checkdulieu(txtMahd, testMaHD, tblhd))
            {
                if (txtMakh.Text.Length > 0 && cboLoaisach.SelectedIndex > -1 && cboNhanvien.SelectedIndex > -1)
                {
                    #region "Khởi tạo các parameter"
                    string[] strTT = cboNhanvien.SelectedItem.ToString().Split(new char[] { '|' });
                    SqlParameter prhd1 = new SqlParameter("@MaHD", txtMahd.Text.Trim());
                    SqlParameter prhd2 = new SqlParameter("@MaKH", txtMakh.Text.Trim());
                    SqlParameter prhd3 = new SqlParameter("@MaNV", strTT[0]);
                    SqlParameter prhd4 = new SqlParameter("@Ngaylap", DateTime.Now);
                    #endregion

                    dk1 = pt.ThemSuaXoa("Themhd", prhd1, prhd2, prhd3,prhd4);
                    if (dk1 > 0)
                    {
                        for (int i = 0; i < grvGiohang.Rows.Count; i++)
                        {
                            #region "Khởi tạo các parameter"
                            SqlParameter pr1 = new SqlParameter("@MaHD", txtMahd.Text.Trim());
                            SqlParameter pr2 = new SqlParameter("@Masach", grvGiohang.Rows[i].Cells[0].Value.ToString());
                            SqlParameter pr3 = new SqlParameter("@Soluong", grvGiohang.Rows[i].Cells[2].Value.ToString());
                            #endregion

                            dk2 = pt.ThemSuaXoa("Themcthd", pr1, pr2, pr3);
                        }
                        if (dk2 > 0)
                        {
                            lblThongbao.Text = "Giao dịch thành công!";
                            Tinhtien();
                            btnGiaodich.Enabled = false;
                            MessageBox.Show("Giao dịch thành công!");
                            Form_Muahang_Load(sender, e);
                            grvGiohang.Rows.Clear();
                        }
                    }
                    else
                    {
                        lblThongbao.Text = "Lỗi!";
                    }  
                }
                else
                {
                    lblThongbao.Text = "Bạn phải nhập đầy đủ những thông tin bắt buộc!";
                }
            }
            else
                lblThongbao.Text = "Bạn chưa nhập mã hóa đơn hoặc mã này đã tồn tại!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
