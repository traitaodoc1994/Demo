using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBanhang
{
    class Hamchung
        
    {
        
        public string sqlCon = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\QLBansach.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        public SqlConnection Cnn = new SqlConnection();
        public Boolean KetnoiCSDL()
        {
            try
            {
                if (Cnn.State == ConnectionState.Open)
                    Cnn.Close();
                Cnn.ConnectionString = sqlCon;
                Cnn.Open();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối CSDL!");
                return false;
            }
            return true;
        }
        public Boolean KiemtraSonguyen(string sSo)
        {
            try
            {
                Int32.Parse(sSo);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public Boolean KiemtraTrungkhoa(string sTenbang, string sTencotKhoa, string sGiatri)
        {
            if (KetnoiCSDL() == false)
                return true;
            string strSql = "Select * from " + sTenbang + " Where " + sTencotKhoa
                + "='" + sGiatri + "'";
            SqlDataAdapter da = new SqlDataAdapter(strSql, Cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public void Hienthi(string ViewTable, DataGridView dgrv)
        {
            string strSQL = "Select * from " + ViewTable;
            if (KetnoiCSDL() == false)
                return;
            SqlDataAdapter da = new SqlDataAdapter(strSQL, Cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgrv.DataSource = dt;
            da.Dispose();
            dt.Dispose();
        }
        public void Timkiemtuyetdoi(string ViewTable, string Hienthi,string Tieuchi,string Sosanh,string Giatri, DataGridView dgrv)
        {
            string strSQL = "Select " + Hienthi + " from " + ViewTable + " where " + Tieuchi + " "+Sosanh+" N'" + Giatri + "'";
            if (KetnoiCSDL() == false)
                return;
            SqlDataAdapter da = new SqlDataAdapter(strSQL, Cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgrv.DataSource = dt;
            da.Dispose();
            dt.Dispose();
        }
        public void Timkiemtuongdoi(string ViewTable, string Hienthi, string Tieuchi, string Giatri, DataGridView dgrv)
        {
            string strSQL = "Select "+Hienthi+ " from " + ViewTable + " where " + Tieuchi + " like N'%" + Giatri + "%'";
            if (KetnoiCSDL() == false)
                return;
            SqlDataAdapter da = new SqlDataAdapter(strSQL, Cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgrv.DataSource = dt;
            da.Dispose();
            dt.Dispose();
        }
        public int ThemSuaXoa(string Tenproc,params SqlParameter[] lspr){
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(Tenproc, Cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(lspr);
            try
            {
                return cmd.ExecuteNonQuery();
            }catch(Exception ex){
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }

        public DataTable GetTable(string sql)
        {
            KetnoiCSDL();
            SqlDataAdapter da = new SqlDataAdapter(sql,Cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
        public Boolean checkdulieu(TextBox A, PictureBox ptb, DataTable dttb)
        {
            int dem = 0;
            if (A.Text.Length == 0)
            {
                ptb.Image = QLBanhang.Properties.Resources.TT;
                return false;
            }
            else
            {
                for (int i = 0; i < dttb.Rows.Count; i++)
                {
                    if (string.Compare(A.Text.Trim(), dttb.Rows[i][0].ToString()) == 0)
                    {
                        dem++;
                    }
                }
                if (dem > 0)
                {
                    ptb.Image = QLBanhang.Properties.Resources.TT;
                    return false;
                }
                else
                {
                    ptb.Image = QLBanhang.Properties.Resources.TM;
                }
            }
            return true;
        }
    }
}
