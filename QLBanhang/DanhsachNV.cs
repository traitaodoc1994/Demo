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
    public partial class DanhsachNV : Form
    {
        public DanhsachNV()
        {
            InitializeComponent();
        }

        private void DanhsachNV_Load(object sender, EventArgs e)
        {
            Hamchung hc = new Hamchung();
            SqlConnection cnn = new SqlConnection(hc.sqlCon);
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Nhanvien", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reportNhanvien nv = new reportNhanvien();
            nv.SetDataSource(dt);
            rptvNhanvien.ReportSource = nv;
            cnn.Close();
        }
    }
}
