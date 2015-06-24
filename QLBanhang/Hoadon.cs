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
    public partial class Hoadon : Form
    {
        Hamchung hc = new Hamchung();
        public Hoadon()
        {
            InitializeComponent();
        }
        public string Madangchon,makh,manv,tenkh,tennv,nl;
        private void Hoadon_Load(object sender, EventArgs e)
        {
            cboTimkiem.SelectedIndex = 0;
            MaHD.Text = null;
            MaKH.Text = "..."; MaNV.Text = "...";
            hc.Hienthi("vHoadon", grvHoadon);
            grvHoadon.Columns[0].HeaderText = "Mã hóa đơn";
            grvHoadon.Columns[1].HeaderText = "Tên khách";
            grvHoadon.Columns[2].HeaderText = "Nhân viên lập";
            grvHoadon.Columns[3].HeaderText = "Ngày lập";
            string sql1 = "select MaNV,Hoten from Nhanvien";
            string sql2 = "select MaKH,Hoten from Khachhang";
            string sql3 = "select Masach,Tensach from Sach";
            SqlDataAdapter da, da1,da2;
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            da = new SqlDataAdapter(sql1,hc.Cnn);
            da.Fill(dt);
            cboNV.DataSource = dt;
            cboNV.DisplayMember = "Hoten";
            cboNV.ValueMember = "MaNV";
            cboNV.SelectedItem = null;
            da1 = new SqlDataAdapter(sql2, hc.Cnn);
            da1.Fill(dt1);
            cboKH.DataSource = dt1;
            cboKH.DisplayMember = "Hoten";
            cboKH.ValueMember = "MaKH";
            cboKH.SelectedItem = null;
            da2 = new SqlDataAdapter(sql3, hc.Cnn);
            da2.Fill(dt2);
            cboMasach.DataSource = dt2;
            cboMasach.DisplayMember = "Masach";
            cboMasach.ValueMember = "Tensach";
            cboMasach.SelectedItem = null;
        }

        private void grvcthdLoad() {
            
            string sql = "select Masach,Soluong from CTHD where CTHD.MaHD = '" +
                grvHoadon.CurrentRow.Cells[0].Value.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, hc.Cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grvChitiethd.DataSource = dt;
            grvChitiethd.Columns[0].HeaderText = "Mã sách";
            grvChitiethd.Columns[1].HeaderText = "Số lượng";
        }

        private void grvHoadon_Click(object sender, EventArgs e)
        {
            MaHD.Text = grvHoadon.CurrentRow.Cells[0].Value.ToString();
            cboKH.Text = grvHoadon.CurrentRow.Cells[1].Value.ToString();
            cboNV.Text = grvHoadon.CurrentRow.Cells[2].Value.ToString();
            Ngaylap.Value = (DateTime) grvHoadon.CurrentRow.Cells[3].Value;
            Madangchon = grvHoadon.CurrentRow.Cells[0].Value.ToString();
            makh = MaKH.Text;
            manv = MaNV.Text;
            tenkh = grvHoadon.CurrentRow.Cells[1].Value.ToString();
            tennv = grvHoadon.CurrentRow.Cells[2].Value.ToString();
            nl = grvHoadon.CurrentRow.Cells[3].Value.ToString();
            grvcthdLoad();
        }

        private void btn_Themhd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MaHD.Text)) {
                MessageBox.Show("Không để trống mã!");
                return;
            }
            if (hc.KiemtraTrungkhoa("Hoadon","MaHD",MaHD.Text)){
                MessageBox.Show("Trùng mã hóa đơn, mời nhập lại");
                return;
            }
            if (Ngaylap.Value > DateTime.Now) {
                MessageBox.Show("Ngày lập không lớn hơn ngày hôm nay");
                return;
            }
            if (MaNV.Text == "...") {
                MessageBox.Show("Hãy chọn nhân viên lập");
                return;
            }
            if (MaKH.Text == "...") {
                MessageBox.Show("Hãy chọn khách hàng");
                return;
            }
            SqlParameter pr1 = new SqlParameter("@MaHD",MaHD.Text);
            SqlParameter pr2 = new SqlParameter("@MaKH",MaKH.Text);
            SqlParameter pr3 = new SqlParameter("@MaNV",MaNV.Text);
            SqlParameter pr4 = new SqlParameter("@Ngaylap",Ngaylap.Value);
            int i=hc.ThemSuaXoa("Themhd", pr1, pr2, pr3, pr4);
            if (i > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else MessageBox.Show("Không thêm được");
            this.Hoadon_Load(sender, e);
        }

        private void cboKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKH.SelectedValue == null)
            {
                MaKH.Text = "...";
            }
            else {
                MaKH.Text = cboKH.SelectedValue.ToString();
            }
        }

        private void cboNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNV.SelectedValue == null)
            {
                MaNV.Text = "...";
            }
            else
            {
                MaNV.Text = cboNV.SelectedValue.ToString();
            }
        }

        private void btn_Suahd_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(MaHD.Text))
            {
                MessageBox.Show("Không để trống mã!");
                return;
            }
            if (MaHD.Text != grvHoadon.CurrentRow.Cells[0].Value.ToString())
            {
                MessageBox.Show("Không được sửa mã hóa đơn");
                MaHD.Text = grvHoadon.CurrentRow.Cells[0].Value.ToString();
                return;
            }
            if (Ngaylap.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày lập không lớn hơn ngày hôm nay");
                return;
            }
            if (MaNV.Text == "...")
            {
                MessageBox.Show("Hãy chọn nhân viên lập");
                return;
            }
            if (MaKH.Text == "...")
            {
                MessageBox.Show("Hãy chọn khách hàng");
                return;
            }
            SqlParameter pr1 = new SqlParameter("@MaHD", MaHD.Text);
            SqlParameter pr2 = new SqlParameter("@MaKH", MaKH.Text);
            SqlParameter pr3 = new SqlParameter("@MaNV", MaNV.Text);
            SqlParameter pr4 = new SqlParameter("@Ngaylap", Ngaylap.Value);
            int i = hc.ThemSuaXoa("Suahd", pr1, pr2, pr3, pr4);
            if (i > 0)
            {
                MessageBox.Show("Sửa thành công");
            }
            else MessageBox.Show("Không sửa được");
            this.Hoadon_Load(sender, e);
        }

        private void btn_Xoahd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MaHD.Text))
            {
                MessageBox.Show("Không để trống mã!");
                return;
            }
            if (MessageBox.Show("Chắc chắn xóa?", "Cảnh bảo", MessageBoxButtons.YesNo) == DialogResult.No) return;
            SqlParameter pr = new SqlParameter("@MaHD", MaHD.Text);
            int i = hc.ThemSuaXoa("Xoahd", pr);
            if (i > 0)
            {
                MessageBox.Show("Xóa thành công");
            }
            else MessageBox.Show("Không có mã hóa đơn này");
            this.Hoadon_Load(sender, e);
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            switch (cboTimkiem.SelectedIndex) { 
                case 0: 
                    hc.Timkiemtuongdoi("vHoadon","*","MaHD",Timkiem.Text,grvHoadon);
                    break;
                case 1:
                    hc.Timkiemtuongdoi("vHoadon","*","hotenkh",Timkiem.Text,grvHoadon);
                    break;
                case 2:
                    hc.Timkiemtuongdoi("vHoadon","*","hotennv",Timkiem.Text,grvHoadon);
                    break;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            MaHD.Text = null;
            MaKH.Text = "...";
            MaNV.Text = "...";
            cboMasach.SelectedItem = null;
            Tensach.Text = null;
            Timkiem.Text = null;
            cboTimkiem.SelectedIndex = 0;
            cboNV.SelectedItem = null;
            cboKH.SelectedItem = null;
            Soluong.Text = null;
            Ngaylap.Value = DateTime.Now;
        }

        private void btn_Themct_Click(object sender, EventArgs e)
        {
            /*if () {
                MessageBox.Show("Hãy chọn hóa đơn cần thêm chi tiết");
                return;
            }*/
            for(int j = 0;j<grvChitiethd.RowCount;j++){
                if (grvChitiethd.Rows[j].Cells[0].Value.ToString() == cboMasach.Text) {
                    MessageBox.Show("Trùng mã sách, mời nhập lại!");
                    return;
                }
            }
            if (string.IsNullOrEmpty(Soluong.Text)) {
                MessageBox.Show("Hãy nhập số lượng");
                return;
            }
            if (hc.KiemtraSonguyen(Soluong.Text))
            {
                if (int.Parse(Soluong.Text) <= 0) {
                    MessageBox.Show("Số lượng phải lớn hơn 0");
                    return;
                }
            }
            else {
                MessageBox.Show("Số lượng nhập vào sai định dạng số nguyên");
                return;
            }
            SqlParameter pr1 = new SqlParameter("@MaHD", grvHoadon.CurrentRow.Cells[0].Value.ToString());
            SqlParameter pr2 = new SqlParameter("@Masach", cboMasach.Text);
            SqlParameter pr3 = new SqlParameter("@Soluong", Soluong.Text);
            int i = hc.ThemSuaXoa("Themcthd", pr1, pr2, pr3);
            if (i > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else MessageBox.Show("Không thêm được");
            grvcthdLoad();
        }

        private void cboMasach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMasach.SelectedValue == null)
            {
                Tensach.Text = null;
            }
            else {
                Tensach.Text = cboMasach.SelectedValue.ToString();
            }
        }
        
        private void grvChitiethd_Click(object sender, EventArgs e)
        {
            if (grvChitiethd.RowCount == 0) return;
            cboMasach.Text = grvChitiethd.CurrentRow.Cells[0].Value.ToString();
            Soluong.Text = grvChitiethd.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void btn_Suact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboMasach.Text)) {
                MessageBox.Show("Hãy nhập mã sách cần sửa");
                return;
            }
            if(string.IsNullOrEmpty(Soluong.Text)){
                MessageBox.Show("Cần nhập số lượng");
                return;
            }
            if (hc.KiemtraSonguyen(Soluong.Text))
            {
                if (int.Parse(Soluong.Text) <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Số lượng nhập vào sai định dạng số nguyên");
                return;
            }
            if (cboMasach.Text != grvChitiethd.CurrentRow.Cells[0].Value.ToString()) {
                MessageBox.Show("Không được sửa mã sách");
                cboMasach.Text = grvChitiethd.CurrentRow.Cells[0].Value.ToString();
                return;
            }
            SqlParameter pr1 = new SqlParameter("@MaHD", grvHoadon.CurrentRow.Cells[0].Value.ToString());
            SqlParameter pr2 = new SqlParameter("@Masach", cboMasach.Text);
            SqlParameter pr3 = new SqlParameter("@Soluong", Soluong.Text);
            int i = hc.ThemSuaXoa("Suacthd", pr1, pr2, pr3);
            if (i > 0)
            {
                MessageBox.Show("Sửa thành công");
            }
            else MessageBox.Show("Không sửa được");
            grvcthdLoad();
        }

        private void btn_Xoact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboMasach.Text))
            {
                MessageBox.Show("Hãy nhập mã sách cần sửa");
                return;
            }
            SqlParameter pr1 = new SqlParameter("@MaHD", grvHoadon.CurrentRow.Cells[0].Value.ToString());
            SqlParameter pr2 = new SqlParameter("@Masach", cboMasach.Text);
            int i = hc.ThemSuaXoa("Xoacthd", pr1,pr2);
            if (i > 0)
            {
                MessageBox.Show("Xóa thành công");
            }
            else MessageBox.Show("Không xóa được");
            grvcthdLoad();
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Madangchon)){
                MessageBox.Show("Hãy click vào hóa đơn cần in");
                return;
            }
            Inhoadon inhd = new Inhoadon();
            inhd.ShowDialog();
        }








    }
}
