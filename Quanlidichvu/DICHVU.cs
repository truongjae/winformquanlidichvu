using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Quanlidichvu
{
    class DICHVU
    {
        string madv, tendv;
        int dongia;
        public DICHVU() { }
        public DICHVU(string madv, string tendv, int dongia)
        {
            this.madv = madv;
            this.tendv = tendv;
            this.dongia = dongia;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=TRUONGJAE\SQLEXPRESS;Initial Catalog=QLDV;Integrated Security=True");
        public void HienThi(ListView item)
        {
            item.Items.Clear();
            try
            {
                conn.Open();
            }
            catch (System.InvalidOperationException) { }
            SqlCommand cmd = new SqlCommand("select * from DICHVU", conn);
            SqlDataReader Doc = cmd.ExecuteReader();
            int i = 0;
            while (Doc.Read())
            {
                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(Doc[0].ToString());
                item.Items[i].SubItems.Add(Doc[1].ToString());
                item.Items[i].SubItems.Add(Doc[2].ToString());
                i++;
            }
            conn.Close();
        }
        public void Insert(DICHVU ob)
        {
            string sql = "Insert into DICHVU values(@mdv,@tdv,@dg)";
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@mdv", SqlDbType.NVarChar, 50).Value = ob.madv;
            cmd.Parameters.Add("@tdv", SqlDbType.NVarChar, 50).Value = ob.tendv;
            cmd.Parameters.Add("@dg", SqlDbType.Int).Value = ob.dongia;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                DialogResult tl = MessageBox.Show("Mã dịch vụ đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        //lenh update
        public void update(DICHVU ob)
        {
            string sql = "Update DICHVU set tendv='" + ob.tendv + "',dongia=" + ob.dongia + " where madv='" + ob.madv + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        // lenh delete
        public void delete(DICHVU ob)
        {
            string sql = "DELETE from DICHVU where madv='" + ob.madv + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                //
            }
            conn.Close();
        }

        public DataTable Load_Table(String sql)
        {
            DICHVU ob = new DICHVU();
            ob.conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, ob.conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            ob.conn.Close();
            return dt;
        }
    }
}
