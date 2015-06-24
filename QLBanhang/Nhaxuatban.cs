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
    public partial class Nhaxuatban : Form
    {
        Hamchung hc = new Hamchung();
        public Nhaxuatban()
        {
            InitializeComponent();
        }

        private void Nhaxuatban_Load(object sender, EventArgs e)
        {
            MaNXB.Text = null;
            TenNXB.Text = null;
            Diachi.Text = null;
            Sdt.Text = null;
            cboTimkiem.SelectedIndex = 0;
            hc.Hienthi("NXB", grvNXB);
            grvNXB.Columns[0].HeaderText = "Mã nhà xuất bản";
            grvNXB.Columns[1].HeaderText = "Tên nhà xuất bản";
            grvNXB.Columns[2].HeaderText = "Địa chỉ";
            grvNXB.Columns[3].HeaderText = "Số điện thoại";
            
        }

        private void grvNXB_Click(object sender, EventArgs e)
        {
            MaNXB.Text = grvNXB.CurrentRow.Cells[0].Value.ToString();
            TenNXB.Text = grvNXB.CurrentRow.Cells[1].Value.ToString();
            Diachi.Text = grvNXB.CurrentRow.Cells[2].Value.ToString();
            Sdt.Text = grvNXB.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            switch (cboTimkiem.SelectedIndex) { 
                case 0:
                    hc.Timkiemtuongdoi("NXB","*","MaNXB",Timkiem.Text,grvNXB);
                    break;
                case 1:
                    hc.Timkiemtuongdoi("NXB", "*", "TenNXB", Timkiem.Text, grvNXB);
                    break;
                case 2:
                    hc.Timkiemtuongdoi("NXB", "*", "Diachi", Timkiem.Text, grvNXB);
                    break;
                case 3:
                    hc.Timkiemtuongdoi("NXB", "*", "Sdt", Timkiem.Text, grvNXB);
                    break;
            }
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //kiểm tra
            if (string.IsNullOrEmpty(MaNXB.Text)) {
                MessageBox.Show("Không để chống mã ");
                return;
            }
            if (MaNXB.TextLength > 10) {
                MessageBox.Show("Mã không được quá 10 ký tự");
                return;
            }
            if(hc.KiemtraTrungkhoa("NXB","MaNXB",MaNXB.Text)){
                MessageBox.Show("Trùng mã, mời nhập lại!");
                return;
            }
            if(TenNXB.TextLength>50){
                MessageBox.Show("Tên nhà xuất bản không quá 50 ký tự");
                return;
            }
            if(Diachi.TextLength>80){
                MessageBox.Show("Địa chỉa không quá 80 ký tự");
                return;
            }
            if(Sdt.TextLength>11){
                MessageBox.Show("Số điện thoại không quá 11 chữ số");
                return;
            }

            //thêm
            SqlParameter pr1 = new SqlParameter("@MaNXB", MaNXB.Text);
            SqlParameter pr2 = new SqlParameter("@TenNXB", TenNXB.Text);
            SqlParameter pr3 = new SqlParameter("@Diachi", Diachi.Text);
            SqlParameter pr4 = new SqlParameter("@Sdt", Sdt.Text);
            int i = hc.ThemSuaXoa("Themnxb", pr1, pr2, pr3, pr4);
            if (i > 0) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Không thêm được");
            this.Nhaxuatban_Load(sender, e);
        }

        private void Sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timkiem.Text = null;
            MaNXB.Text = null;
            TenNXB.Text = null;
            Diachi.Text = null;
            Sdt.Text = null;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            // kiểm tra
            if (string.IsNullOrEmpty(MaNXB.Text))
            {
                MessageBox.Show("Không để chống mã ");
                return;
            }
            if (MaNXB.Text != grvNXB.CurrentRow.Cells[0].Value.ToString()) {
                MessageBox.Show("Không được sửa mã");
                MaNXB.Text = grvNXB.CurrentRow.Cells[0].Value.ToString();
                return;
            }
            if (MaNXB.TextLength > 10)
            {
                MessageBox.Show("Mã không được quá 10 ký tự");
                return;
            }
            if (TenNXB.TextLength > 50)
            {
                MessageBox.Show("Tên nhà xuất bản không quá 50 ký tự");
                return;
            }
            if (Diachi.TextLength > 80)
            {
                MessageBox.Show("Địa chỉa không quá 80 ký tự");
                return;
            }
            if (Sdt.TextLength > 11)
            {
                MessageBox.Show("Số điện thoại không quá 11 chữ số");
                return;
            }
            //sửa
            SqlParameter pr1 = new SqlParameter("@MaNXB", MaNXB.Text);
            SqlParameter pr2 = new SqlParameter("@TenNXB", TenNXB.Text);
            SqlParameter pr3 = new SqlParameter("@Diachi", Diachi.Text);
            SqlParameter pr4 = new SqlParameter("@Sdt", Sdt.Text);
            int i = hc.ThemSuaXoa("Suanxb", pr1, pr2, pr3, pr4);
            if (i > 0) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Không sửa được");
            this.Nhaxuatban_Load(sender, e);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            SqlParameter pr = new SqlParameter("@MaNXB", MaNXB.Text);
            if (MessageBox.Show("Chắc chắn xóa ?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int i = hc.ThemSuaXoa("Xoanxb", pr);
            if (i > 0) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Không xóa được");
            this.Nhaxuatban_Load(sender, e);
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            DanhsachNXB nxb = new DanhsachNXB();
            nxb.ShowDialog();
        }

        private void grvNXB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
