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
    public partial class Themsach : Form
    {
        public Themsach()
        {
            InitializeComponent();
        }
        Hamchung hc = new Hamchung();
        private void Themsach_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.frmSach.Sach_Load(sender, e);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //kt dữ liệu vào
            if (Masach.TextLength > 10)
            {
                MessageBox.Show("Mã sách không quá 10 ký tự");
                return;
            }
            if (Tensach.TextLength > 50)
            {
                MessageBox.Show("Tên sách không quá 50 ký tự");
                return;
            }
            if (Tacgia.TextLength > 50)
            {
                MessageBox.Show("Tên tác giả không quá 50 ký tự");
                return;
            }
            if (hc.KiemtraTrungkhoa("Sach", "Masach", Masach.Text)) {
                MessageBox.Show("Trùng mã sách, mời nhập lại mã khác!");
                return;
            }
            if (String.IsNullOrEmpty(Masach.Text.Trim()))
            {
                MessageBox.Show("Không để chống Mã");
                return;
            }
            if (!hc.KiemtraSonguyen(Namxb.Text)) { 
                MessageBox.Show("Năm xuất bản nhập sai định dạng số");
                return;
            }
            if (!hc.KiemtraSonguyen(Dongia.Text))
            {
                MessageBox.Show("Đơn giá nhập sai định dạng số");
                return;
            }
            if (!hc.KiemtraSonguyen(Namxb.Text))
            {
                MessageBox.Show("Năm xuất bản nhập sai định dạng số");
                return;
            }
            if (Mota.TextLength > 1000)
            {
                MessageBox.Show("Nội dung tóm tắt không được quá 1000 ký tự");
                return;
            }
            //thêm
            SqlParameter pr1 = new SqlParameter("@Masach",Masach.Text);
            SqlParameter pr2 = new SqlParameter("@MaNXB", Nxb.SelectedValue.ToString());
            SqlParameter pr3 = new SqlParameter("@Tensach", Tensach.Text);
            SqlParameter pr4 = new SqlParameter("@Tacgia", Tacgia.Text);
            SqlParameter pr5 = new SqlParameter("@Namxb", Namxb.Text);
            SqlParameter pr6 = new SqlParameter("@Dongia", Dongia.Text);
            SqlParameter pr7 = new SqlParameter("@Soluong", Sl.Text);
            SqlParameter pr8 = new SqlParameter("@Mota", Mota.Text);
            int i = hc.ThemSuaXoa("Themsach", pr1, pr2, pr3, pr4, pr5, pr6, pr7, pr8);
            if (i > 0) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Không thêm được");
            this.Close();
        }

        private void Themsach_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select MaNXB,TenNXB from NXB",hc.sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Nxb.DataSource = dt;
            Nxb.DisplayMember = "TenNXB";
            Nxb.ValueMember = "MaNXB";
        }


    }
}
