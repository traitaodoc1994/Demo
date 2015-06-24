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
    public partial class DanhsachKH : Form
    {
        public DanhsachKH()
        {
            InitializeComponent();
        }

        private void DanhsachKH_Load(object sender, EventArgs e)
        {
            Hamchung hc = new Hamchung();
            SqlConnection cnn = new SqlConnection(hc.sqlCon);
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Khachhang", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportKhachhang kh = new  ReportKhachhang();
            kh.SetDataSource(dt);
            rptvKhachhang.ReportSource = kh;
            cnn.Close();
        }
    }
}
