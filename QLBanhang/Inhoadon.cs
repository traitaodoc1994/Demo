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
    public partial class Inhoadon : Form
    {
        public Inhoadon()
        {
            InitializeComponent();
        }
        
        private void Inhoadon_Load(object sender, EventArgs e)
        {
            Hamchung hc = new Hamchung();
            SqlConnection cnn = new SqlConnection(hc.sqlCon);
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("rpHoadon '"+MainForm.frmHoadon.Madangchon+"'", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlCommand cmd = new SqlCommand("Tongtien", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHD", MainForm.frmHoadon.Madangchon);
            SqlDataReader reader =  cmd.ExecuteReader();
            reader.Read();
            string Tongtien = reader[0].ToString();
            ReportHoadon cr = new ReportHoadon();
            cr.SetDataSource(dt);
            cr.SetParameterValue("MaHD", MainForm.frmHoadon.Madangchon);
            cr.SetParameterValue("Tenkhachhang", MainForm.frmHoadon.tenkh);
            cr.SetParameterValue("Tennhanvien", MainForm.frmHoadon.tennv);
            cr.SetParameterValue("Makhachhang", MainForm.frmHoadon.makh);
            cr.SetParameterValue("Ngaylap", MainForm.frmHoadon.nl);
            try
            {
                cr.SetParameterValue("Tongtien", Tongtien);
            }
            catch {
                MessageBox.Show("Hóa đơn này rỗng");
                return;
            }
            rptvHoadon.ReportSource = cr;
            cnn.Close();
        }
    }
}
