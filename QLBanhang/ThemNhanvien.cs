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
    public partial class ThemNhanvien : Form
    {
        Hamchung hc = new Hamchung();
        public ThemNhanvien()
        {
            InitializeComponent();
        }

        private void ThemNhanvien_Load(object sender, EventArgs e)
        {
            Gt.SelectedIndex = 0;
        }

        private void ThemNhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.frmNhanvien.Nhanvien_Load(sender, e);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //kiểm tra
            if (string.IsNullOrEmpty(MaNV.Text))
            {
                MessageBox.Show("Mã nhân viên không được để trống!");
                return;
            }
            if(hc.KiemtraTrungkhoa("Nhanvien","MaNV",MaNV.Text)){
                MessageBox.Show("Mã nhân viên này đã có vui lòng nhập mã khác!");
                return;
            }
            if (MaNV.TextLength > 10) {
                MessageBox.Show("Mã nhân viên độ dài không vượt quá 10 ký tự");
                return;
            }
            if (Hoten.TextLength > 50) {
                MessageBox.Show("Họ tên không vượt quá 50 ký tự!");
                return;
            }
            if (hc.KiemtraSonguyen(Namsinh.Text))
            {
                int ns = int.Parse(Namsinh.Text);
                int tuoi = DateTime.Now.Year - ns;
                if ((tuoi < 18) || (tuoi > 50)) {
                    MessageBox.Show("Cửa hàng chỉ nhận nhân viên từ 18 đến 50 tuổi");
                    return;
                }
            }
            else {
                MessageBox.Show("Năm sinh nhập sai định dạng số");
                return;
            }
            if (Sdt.TextLength > 11) {
                MessageBox.Show("Số điện thoại tối đa 11 chữ số");
                return;
            }
            if (hc.KiemtraTrungkhoa("Nhanvien", "Sdt", Sdt.Text)) {
                MessageBox.Show("Trùng số điện thoại");
                return;
            }
            if (Scm.TextLength > 10) {
                MessageBox.Show("Số CMND tối đa 10 chữ số");
                return;
            }
            if (hc.KiemtraTrungkhoa("Nhanvien", "Scm", Sdt.Text))
            {
                MessageBox.Show("Trùng số CMND");
                return;
            }
            if (Diachi.TextLength > 80)
            {
                MessageBox.Show("Địa chỉ tối đa 80 ký tự");
                return;
            }
            // thêm
            SqlParameter pr1 = new SqlParameter("@MaNV", MaNV.Text);
            SqlParameter pr2 = new SqlParameter("@Hoten", Hoten.Text);
            SqlParameter pr3 = new SqlParameter("@Gioitinh", Gt.Text);
            SqlParameter pr4 = new SqlParameter("@Namsinh", Namsinh.Text);
            SqlParameter pr5 = new SqlParameter("@Scm", Scm.Text);
            SqlParameter pr6 = new SqlParameter("@Sdt", Sdt.Text);
            SqlParameter pr7 = new SqlParameter("@Diachi", Diachi.Text);
            int i = hc.ThemSuaXoa("Themnv", pr1, pr2, pr3, pr4, pr5, pr6, pr7);
            if (i > 0) MessageBox.Show("Thêm thành công!");
            else MessageBox.Show("Không thêm được");
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

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
