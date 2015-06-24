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
    public partial class Suasach : Form
    {
        public Suasach()
        {
            InitializeComponent();
        }
        Hamchung hc = new Hamchung();
        private void Suasach_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu ra combobox
            SqlDataAdapter da = new SqlDataAdapter("select MaNXB,TenNXB from NXB", hc.sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Nxb.DataSource = dt;
            Nxb.DisplayMember = "TenNXB";
            Nxb.ValueMember = "MaNXB";
            // đổ dữ liệu
            
            Masach.Text = MainForm.frmSach.Madangchon;
            Tensach.Text = MainForm.frmSach.ten;
            Tacgia.Text = MainForm.frmSach.tg;
            Namxb.Text = MainForm.frmSach.nam;
            Nxb.Text = MainForm.frmSach.nxb;
            Sl.Text = MainForm.frmSach.sl;
            Dongia.Text = MainForm.frmSach.dg;
            Mota.Text = MainForm.frmSach.mt;
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Suasach_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.frmSach.Sach_Load(sender, e);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            //kt dữ liệu
            if (Tensach.TextLength > 50) {
                MessageBox.Show("Tên sách không quá 50 ký tự");
                return;
            }
            if (Tacgia.TextLength > 50)
            {
                MessageBox.Show("Tên tác giả không quá 50 ký tự");
                return;
            }
            if (String.IsNullOrEmpty(Masach.Text.Trim()))
            {
                MessageBox.Show("Không để chống Mã");
                return;
            }
            if (!hc.KiemtraSonguyen(Namxb.Text))
            {
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
            if (Mota.TextLength > 1000) {
                MessageBox.Show("Nội dung tóm tắt không được quá 1000 ký tự");
                return;
            }
            //sửa
            SqlParameter pr1 = new SqlParameter("@Masach", Masach.Text);
            SqlParameter pr2 = new SqlParameter("@MaNXB", Nxb.SelectedValue.ToString());
            SqlParameter pr3 = new SqlParameter("@Tensach", Tensach.Text);
            SqlParameter pr4 = new SqlParameter("@Tacgia", Tacgia.Text);
            SqlParameter pr5 = new SqlParameter("@Namxb", Namxb.Text);
            SqlParameter pr6 = new SqlParameter("@Dongia", Dongia.Text);
            SqlParameter pr7 = new SqlParameter("@Soluong", Sl.Text);
            SqlParameter pr8 = new SqlParameter("@Mota", Mota.Text);
            int i = hc.ThemSuaXoa("Suasach", pr1, pr2, pr3, pr4, pr5, pr6, pr7, pr8);
            if (i > 0) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Không thể sửa");
            this.Close();
        }

    }
}
