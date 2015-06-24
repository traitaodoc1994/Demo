using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBanhang
{
    public partial class MainForm : Form
    {
        public static Sach frmSach ;
        public static Nhanvien frmNhanvien;
        public static Form_KH frmKH;
        public static Hoadon frmHoadon;
        public static Nhaxuatban frmNhaxuatban;
        Hamchung hc = new Hamchung();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            hc.KetnoiCSDL();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSach != null)
            {
                frmSach.Dispose();
                frmSach = new Sach();
                frmSach.MdiParent = this;
                frmSach.Show();
            }
            else {
                frmSach = new Sach();
                frmSach.MdiParent = this;
                frmSach.Show();
            }
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmNhanvien != null)
            {
                frmNhanvien.Dispose();
                frmNhanvien = new Nhanvien();
                frmNhanvien.MdiParent = this;
                frmNhanvien.Show();
            }
            else
            {
                frmNhanvien = new Nhanvien();
                frmNhanvien.MdiParent = this;
                frmNhanvien.Show();
            }
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKH != null)
            {
                frmKH.Dispose();
                frmKH = new Form_KH();
                frmKH.MdiParent = this;
                frmKH.Show();
            }
            else
            {
                frmKH = new Form_KH();
                frmKH.MdiParent = this;
                frmKH.Show();
            }
        }

        private void thToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHoadon != null)
            {
                frmHoadon.Dispose();
                frmHoadon = new Hoadon();
                frmHoadon.MdiParent = this;
                frmHoadon.Show();
            }
            else
            {
                frmHoadon = new Hoadon();
                frmHoadon.MdiParent = this;
                frmHoadon.Show();
            }
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmNhaxuatban != null)
            {
                frmNhaxuatban.Dispose();
                frmNhaxuatban = new Nhaxuatban();
                frmNhaxuatban.MdiParent = this;
                frmNhaxuatban.Show();
            }
            else
            {
                frmNhaxuatban = new Nhaxuatban();
                frmNhaxuatban.MdiParent = this;
                frmNhaxuatban.Show();
            }
        }

        private void giớiThiệuPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gioithieu gt = new Gioithieu();
            gt.ShowDialog();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Huongdan hd = new Huongdan();
            hd.ShowDialog();
        }

        private void danhSáchSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhsachSach ds = new DanhsachSach();
            ds.ShowDialog();
        }

        private void danhSáchNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhsachNXB nxb = new DanhsachNXB();
            nxb.ShowDialog();
            
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhsachNV nv = new DanhsachNV();
            nv.ShowDialog();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhsachKH kh = new DanhsachKH();
            kh.ShowDialog();
        }

    }
}
