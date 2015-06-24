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
    public partial class Form_KH : Form
    {
        public Form_KH()
        {
            InitializeComponent();
        }

        bool checkMakh;
        DataTable tblkh;
        Hamchung pt = new Hamchung();

        private void Form_KH_Load(object sender, EventArgs e)
        {
            tblkh = pt.GetTable("select MaKH as[Mã KH],Hoten as[Họ tên],Gioitinh as[Giới tính],Scm as[Số CMT],Sdt as[SĐT] from Khachhang");
            grvdata.Rows.Clear();
            for (int i = 0; i < tblkh.Rows.Count; i++)
            {
                grvdata.Rows.Add(tblkh.Rows[i][0], tblkh.Rows[i][1], tblkh.Rows[i][2],tblkh.Rows[i][3], tblkh.Rows[i][4]);
            }

            #region "Thông tin bắt buộc"
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(lblTT1, "Thông tin bắt buộc!");
            tooltip.SetToolTip(lblTT2, "Thông tin bắt buộc!");
            #endregion
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            #region "Giới tính nam hay nữ"
            string gioitinh;
            if (radNam.Checked==true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            #endregion

            if (checkMakh == true && txtTenkh.Text.Length > 0)
            {
                SqlParameter pr1 = new SqlParameter("@MaKH", txtMakh.Text.Trim());
                SqlParameter pr2 = new SqlParameter("@Hoten", txtTenkh.Text.Trim());
                SqlParameter pr3 = new SqlParameter("@Gioitinh", gioitinh);
                SqlParameter pr4 = new SqlParameter("@Scm", txtScmkh.Text.Trim());
                SqlParameter pr5 = new SqlParameter("@Sdt", txtSdtkh.Text.Trim());
                int i = pt.ThemSuaXoa("Themkh", pr1, pr2, pr3, pr4, pr5);
                if (i > 0) MessageBox.Show("Thêm thành công!");
                else MessageBox.Show("Không thể thêm");
                Form_KH_Load(sender, e);
            }
            else
                MessageBox.Show("Thông tin không hợp lệ!");
        }

        private void txtMakh_TextChanged(object sender, EventArgs e)
        {
            checkMakh = pt.checkdulieu(txtMakh, testMaKH, tblkh);
        }

        int dong;
        private void grvdata_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMakh.Text = grvdata.Rows[dong].Cells[0].Value.ToString();
            txtTenkh.Text = grvdata.Rows[dong].Cells[1].Value.ToString();

            if (string.Compare(grvdata.Rows[dong].Cells[2].Value.ToString(), "Nam") == 0)
            {
                radNam.Checked = true;
            }
            else
                radNu.Checked = true;
            txtScmkh.Text = grvdata.Rows[dong].Cells[3].Value.ToString();
            txtSdtkh.Text = grvdata.Rows[dong].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region "Giới tính nam hay nữ"
            string gioitinh;
            if (radNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            #endregion
            SqlParameter pr1 = new SqlParameter("@MaKH", txtMakh.Text.Trim());
            SqlParameter pr2 = new SqlParameter("@Hoten", txtTenkh.Text.Trim());
            SqlParameter pr3 = new SqlParameter("@Gioitinh", gioitinh);
            SqlParameter pr4 = new SqlParameter("@Scm", txtScmkh.Text.Trim());
            SqlParameter pr5 = new SqlParameter("@Sdt", txtSdtkh.Text.Trim());
            int i = pt.ThemSuaXoa("Suakh", pr1, pr2, pr3, pr4,pr5);
            if (i > 0)
            {
                Form_KH_Load(sender, e);
            }
            else
                MessageBox.Show("Đã xảy ra lỗi!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult qs = MessageBox.Show("Khi xóa thì các hóa đơn của khách này cũng bị xóa. Chắc chắn xóa ?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (qs == DialogResult.Yes)
            {
                SqlParameter pr1 = new SqlParameter("@MaKH", txtMakh.Text.Trim());
                int i = pt.ThemSuaXoa("Xoakh", pr1);
                if (i > 0)
                {
                    Form_KH_Load(sender, e);
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable kq = new DataTable();
            #region "Xử lý câu lệnh sql"
            string sql = "select MaKH as[Mã KH],Hoten as[Họ tên],Gioitinh as[Giới tính], Scm as[CMT], Sdt as[Số điện thoại]"
                    + " from Khachhang";

            if (txtMakh.Text.Length > 0)
                sql += " where MaKH='" + txtMakh.Text.Trim() + "'";
            else
            {
                sql += " where MaKH like '%'";
                if (txtTenkh.Text.Length > 0)
                    sql += " and Hoten=N'" + txtTenkh.Text.Trim() + "'";
                if (radNam.Checked == true)
                    sql += " and Gioitinh=N'Nam'";
                if (radNu.Checked == true)
                    sql += " and Gioitinh=N'Nữ'";
                if (txtSdtkh.Text.Length > 0)
                    sql += " and Sdt='" + txtSdtkh.Text.Trim() + "'";
                if (txtScmkh.Text.Length > 0)
                    sql += " and Scm='" + txtScmkh.Text.Trim() + "'";
            }
            #endregion
            try
            {
                kq = pt.GetTable(sql);
                grvdata.Rows.Clear();
                for (int i = 0; i < kq.Rows.Count; i++)
                {
                    grvdata.Rows.Add(kq.Rows[i][0], kq.Rows[i][1],kq.Rows[i][2],kq.Rows[i][3],kq.Rows[i][4]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: "+ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Form_KH_Load(sender, e);
            txtMakh.Text = "";
            txtScmkh.Text = "";
            txtTenkh.Text = "";
            txtSdtkh.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult qs = MessageBox.Show("Bạn muốn thoát chương trình?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(qs==DialogResult.Yes)
                Close();
        }

        Form_Muahang fmh;
        private void grvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && grvdata.Columns[e.ColumnIndex].Name == "btnMuahang")
            {
                if (fmh == null || fmh.IsDisposed)
                {
                    fmh = new Form_Muahang();
                    fmh.txt = txtMakh.Text.Trim();
                    fmh.Show();
                }
                else
                {
                    fmh.txt = txtMakh.Text.Trim();
                    fmh.Capnhatdulieu();
                }
            }
        }
        private void Thoát_Click(object sender, EventArgs e)
        {
            btnThoat_Click(sender, e);
        }
    }
}
