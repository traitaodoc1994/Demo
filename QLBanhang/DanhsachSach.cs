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
    public partial class DanhsachSach : Form
    {
        public DanhsachSach()
        {
            InitializeComponent();
        }
        Hamchung hc = new Hamchung();
        private void DanhsachSach_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(hc.sqlCon);
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("rpSach",cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ReportSach cr = new ReportSach();
            cr.SetDataSource(dt);
            rptvSach.ReportSource = cr;
            cnn.Close();
        }
    }
}
