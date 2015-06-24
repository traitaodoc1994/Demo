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
    public partial class Sach : Form
    {
        Hamchung hc = new Hamchung();
        public string Madangchon,ten,tg,nam,nxb,dg,sl,mt;
        public Sach()
        {
            InitializeComponent();
        }

        public void Sach_Load(object sender, EventArgs e)
        {
            cboTimkiem.SelectedIndex = 0;
            cboSosanh.Hide();
            hc.Hienthi("vSach",grvSach);
        }

        private void grvSach_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("vCtsach", hc.Cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Masach", grvSach.CurrentRow.Cells[0].Value.ToString());
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            NXB.Text = reader[0].ToString();
            Namxb.Text = reader[1].ToString();
            Sl.Text = reader[2].ToString();
            Dongia.Text = reader[3].ToString();
            Mota.Text = reader[4].ToString();
            reader.Dispose();

            Madangchon = grvSach.CurrentRow.Cells[0].Value.ToString();
            ten = grvSach.CurrentRow.Cells[1].Value.ToString();
            tg = grvSach.CurrentRow.Cells[2].Value.ToString();
            nam = Namxb.Text;
            nxb = NXB.Text;
            dg = Dongia.Text;
            sl = Sl.Text;
            mt = Mota.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chon = cboTimkiem.SelectedIndex;
            switch (chon) { 
                case 0:
                    hc.Timkiemtuongdoi("vTimSach",
                        "Masach as N'Mã sách',Tensach as N'Tên sách',Tacgia as N'Tác giả'",
                        "Masach", txtTimkiem.Text, grvSach);
                    break;
                case 1:
                    hc.Timkiemtuongdoi("vTimSach",
                        "Masach as N'Mã sách',Tensach as N'Tên sách',Tacgia as N'Tác giả'",
                        "Tacgia", txtTimkiem.Text, grvSach);
                    break;
                case 2:
                    hc.Timkiemtuongdoi("vTimSach",
                        "Masach as N'Mã sách',Tensach as N'Tên sách',Tacgia as N'Tác giả'",
                        "Tensach", txtTimkiem.Text, grvSach);
                    break;
                case 3:
                    hc.Timkiemtuyetdoi("Sach",
                        "Masach as N'Mã sách',Tensach as N'Tên sách',Tacgia as N'Tác giả'",
                        "Namxb","=", txtTimkiem.Text, grvSach);
                    break;
                case 4:
                    hc.Timkiemtuongdoi("vTimSach",
                        "Masach as N'Mã sách',Tensach as N'Tên sách',Tacgia as N'Tác giả'",
                        "TenNXB", txtTimkiem.Text, grvSach);
                    break;
                case 5:
                    switch (cboSosanh.SelectedIndex) { 
                        case 0:
                            hc.Timkiemtuyetdoi("Sach",
                                "Masach as N'Mã sách',Tensach as N'Tên sách',Tacgia as N'Tác giả'",
                                "Dongia",">", txtTimkiem.Text, grvSach);
                            break;  
                        case 1:
                            hc.Timkiemtuyetdoi("Sach",
                                "Masach as N'Mã sách',Tensach as N'Tên sách',Tacgia as N'Tác giả'",
                                "Dongia","<", txtTimkiem.Text, grvSach);
                            break;
                        case 2:
                            hc.Timkiemtuyetdoi("Sach",
                                "Masach as N'Mã sách',Tensach as N'Tên sách',Tacgia as N'Tác giả'",
                                "Dongia","=", txtTimkiem.Text, grvSach);
                            break;  
                    }
                    break;
            }
        }

        private void cboTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTimkiem.SelectedIndex == 5)
            {
                txtTimkiem.Width -= 45;
                txtTimkiem.Left += 45;
                cboSosanh.Show();
                cboSosanh.SelectedIndex = 0;
            }
            else {
                txtTimkiem.Width = 151;
                txtTimkiem.Left = 321;
                cboSosanh.Hide();
                
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Themsach Frm_Themsach = new Themsach();
            Frm_Themsach.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Madangchon)) {
                MessageBox.Show("Hãy click vào dòng mà bạn muốn sửa!");
                return;
            }
            Suasach Frm_Suasach = new Suasach();
            Frm_Suasach.ShowDialog();
        }

        private void XoaSach_Click(object sender, EventArgs e)
        {
            SqlParameter pr = new SqlParameter("@Masach",grvSach.CurrentRow.Cells[0].Value.ToString());
            if(MessageBox.Show("Chắc chắn muốn xóa ?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            hc.ThemSuaXoa("Xoasach",pr);
            this.Sach_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DanhsachSach ds = new DanhsachSach();
            ds.ShowDialog();
        }




    }
}
