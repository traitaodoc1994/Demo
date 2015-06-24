using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBanhang
{
    public partial class Nhanvien : Form
    {
        Hamchung hc = new Hamchung();
        public string manv, ht, gt, ns, sdt, scm, dc;
        public Nhanvien()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemNhanvien themnv = new ThemNhanvien();
            themnv.ShowDialog();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(manv))
            {
                MessageBox.Show("Hãy click vào dòng cần sửa");
                return;
            }
            SuaNhanvien suanv = new SuaNhanvien();
            suanv.ShowDialog();
        }

        public void Nhanvien_Load(object sender, EventArgs e)
        {

            cboTimkiem.SelectedIndex = 0;
            hc.Hienthi("vNhanvien", grvNhanvien);
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            switch (cboTimkiem.SelectedIndex) { 
                case 0:
                    hc.Timkiemtuongdoi("Nhanvien", "MaNV as N'Mã nhân viên',Hoten as N'Họ tên',Gioitinh as N'Giới tính', Namsinh as N'Năm sinh',Scm as N'Số CMND',Sdt as N'Số điện thoại',Diachi as N'Địa chỉ'",
                        "MaNV", Timkiem.Text, grvNhanvien);
                    break;
                case 1:
                    hc.Timkiemtuongdoi("Nhanvien", "MaNV as N'Mã nhân viên',Hoten as N'Họ tên',Gioitinh as N'Giới tính', Namsinh as N'Năm sinh',Scm as N'Số CMND',Sdt as N'Số điện thoại',Diachi as N'Địa chỉ'",
                        "Hoten", Timkiem.Text, grvNhanvien);
                    break;
                case 2:
                    hc.Timkiemtuyetdoi("Nhanvien", "MaNV as N'Mã nhân viên',Hoten as N'Họ tên',Gioitinh as N'Giới tính', Namsinh as N'Năm sinh',Scm as N'Số CMND',Sdt as N'Số điện thoại',Diachi as N'Địa chỉ'",
                        "Gioitinh", "=", Timkiem.Text, grvNhanvien);
                    break;
                case 3:
                    hc.Timkiemtuyetdoi("Nhanvien", "MaNV as N'Mã nhân viên',Hoten as N'Họ tên',Gioitinh as N'Giới tính', Namsinh as N'Năm sinh',Scm as N'Số CMND',Sdt as N'Số điện thoại',Diachi as N'Địa chỉ'",
                        "Namsinh", "=", Timkiem.Text, grvNhanvien);
                    break;
                case 4:
                    hc.Timkiemtuongdoi("Nhanvien", "MaNV as N'Mã nhân viên',Hoten as N'Họ tên',Gioitinh as N'Giới tính', Namsinh as N'Năm sinh',Scm as N'Số CMND',Sdt as N'Số điện thoại',Diachi as N'Địa chỉ'",
                        "Scm", Timkiem.Text, grvNhanvien);

                    break;

            }
        }

        private void grvNhanvien_Click(object sender, EventArgs e)
        {
            manv = grvNhanvien.CurrentRow.Cells[0].Value.ToString();
            ht = grvNhanvien.CurrentRow.Cells[1].Value.ToString();
            gt = grvNhanvien.CurrentRow.Cells[2].Value.ToString();
            ns = grvNhanvien.CurrentRow.Cells[3].Value.ToString();
            scm = grvNhanvien.CurrentRow.Cells[4].Value.ToString();
            sdt = grvNhanvien.CurrentRow.Cells[5].Value.ToString();
            dc = grvNhanvien.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            SqlParameter pr = new SqlParameter("@MaNV", grvNhanvien.CurrentRow.Cells[0].Value.ToString());
            if (MessageBox.Show("Chắc chắn muốn xóa ?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            hc.ThemSuaXoa("Xoanv", pr);
            this.Nhanvien_Load(sender, e);
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            DanhsachNV nv = new DanhsachNV();
            nv.ShowDialog();
        }

        private void Timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void grvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
