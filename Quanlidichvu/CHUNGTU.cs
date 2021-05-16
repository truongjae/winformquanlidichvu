using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Quanlidichvu
{
    class CHUNGTU
    {
        public CHUNGTU() { }
        public SqlConnection conn = new SqlConnection(@"Data Source=TRUONGJAE\SQLEXPRESS;Initial Catalog=QLDV;Integrated Security=True");
        public DataTable LoadTable(string sql)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            try
            {
                ad.Fill(dt);
            }
            catch (System.Data.SqlClient.SqlException) { }
            conn.Close();
            return dt;
        }
        public void Excecute(string sql)
        {
            conn.Open();
            SqlCommand thuchienlenh = new SqlCommand(sql, conn);
            try
            {
                thuchienlenh.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException) { }
            conn.Close();
        }
        public void HienThi(ListView item)
        {
            item.Items.Clear();
            try
            {
                conn.Open();
            }
            catch (System.InvalidOperationException) { }
            SqlCommand cmd = new SqlCommand("select * from CHUNGTU", conn);
            SqlDataReader Doc = cmd.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(Doc[0].ToString());
                item.Items[i].SubItems.Add(Doc[1].ToString());
                item.Items[i].SubItems.Add(Doc[2].ToString());
                item.Items[i].SubItems.Add(Doc[3].ToString());
                item.Items[i].SubItems.Add(Doc[4].ToString());
                i++;
            }
            conn.Close();
        }
    }
}
