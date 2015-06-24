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
    public partial class DanhsachNXB : Form
    {
        public DanhsachNXB()
        {
            InitializeComponent();
        }

        private void DanhsachNXB_Load(object sender, EventArgs e)
        {
            Hamchung hc = new Hamchung();
            SqlConnection cnn = new SqlConnection(hc.sqlCon);
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from NXB", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reportNXB nxb = new reportNXB();
            nxb.SetDataSource(dt);
            rptvNXB.ReportSource = nxb;
            cnn.Close();
        }
    }
}
