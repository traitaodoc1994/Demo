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
    public partial class SuaNhanvien : Form
    {
        Hamchung hc = new Hamchung();
        public SuaNhanvien()
        {
            InitializeComponent();
        }

        private void SuaNhanvien_Load(object sender, EventArgs e)
        {
            Gt.SelectedIndex = 0;
            MaNV.Text = MainForm.frmNhanvien.manv;
            Hoten.Text = MainForm.frmNhanvien.ht;
            Namsinh.Text = MainForm.frmNhanvien.ns;
            Scm.Text = MainForm.frmNhanvien.scm;
            Sdt.Text = MainForm.frmNhanvien.sdt;
            Gt.Text = MainForm.frmNhanvien.gt;
            Diachi.Text = MainForm.frmNhanvien.dc;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            // kiểm tra
            if (Hoten.TextLength > 50)
            {
                MessageBox.Show("Họ tên không vượt quá 50 ký tự!");
                return;
            }
            if (hc.KiemtraSonguyen(Namsinh.Text))
            {
                int ns = int.Parse(Namsinh.Text);
                int tuoi = DateTime.Now.Year - ns;
                if ((tuoi < 18) || (tuoi > 50))
                {
                    MessageBox.Show("Cửa hàng chỉ nhận nhân viên từ 18 đến 50 tuổi");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Năm sinh nhập sai định dạng số");
                return;
            }
            if (Sdt.TextLength > 11)
            {
                MessageBox.Show("Số điện thoại tối đa 11 chữ số");
                return;
            }
            if (Sdt.Text != MainForm.frmNhanvien.sdt)
            {
                if (hc.KiemtraTrungkhoa("Nhanvien", "Sdt", Sdt.Text))
                {
                    MessageBox.Show("Trùng số điện thoại");
                    return;
                }
            }
            if (Scm.TextLength > 10)
            {
                MessageBox.Show("Số CMND tối đa 10 chữ số");
                return;
            }
            if (Scm.Text != MainForm.frmNhanvien.scm)
            {
                if (hc.KiemtraTrungkhoa("Nhanvien", "Scm", Sdt.Text))
                {
                    MessageBox.Show("Trùng số CMND");
                    return;
                }
            }
            if (Diachi.TextLength > 80)
            {
                MessageBox.Show("Địa chỉ tối đa 80 ký tự");
                return;
            }
            SqlParameter pr1 = new SqlParameter("@MaNV", MaNV.Text);
            SqlParameter pr2 = new SqlParameter("@Hoten", Hoten.Text);
            SqlParameter pr3 = new SqlParameter("@Gioitinh", Gt.Text);
            SqlParameter pr4 = new SqlParameter("@Namsinh", Namsinh.Text);
            SqlParameter pr5 = new SqlParameter("@Scm", Scm.Text);
            SqlParameter pr6 = new SqlParameter("@Sdt", Sdt.Text);
            SqlParameter pr7 = new SqlParameter("@Diachi", Diachi.Text);
            int i = hc.ThemSuaXoa("Suanv", pr1, pr2, pr3, pr4, pr5, pr6, pr7);
            if (i > 0) MessageBox.Show("Sửa thành công!");
            else MessageBox.Show("Không sửa được");
            this.Close();
        }

        private void Sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true; 
        }

        private void Scm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true; 
        }

        private void SuaNhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.frmNhanvien.Nhanvien_Load(sender, e);
        }


    }
}
