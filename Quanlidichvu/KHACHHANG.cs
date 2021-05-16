using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Quanlidichvu
{
    class KHACHHANG
    {
        string makh, tenkh, diachi;
        public KHACHHANG() { }
        public KHACHHANG(string makh, string tenkh, string diachi)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.diachi = diachi;
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
            SqlCommand cmd = new SqlCommand("select * from KHACHHANG", conn);
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
        public void Insert(KHACHHANG ob)
        {
            string sql = "Insert into KHACHHANG values(@mkh,@tkh,@dc)";
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.Parameters.Add("@mkh", SqlDbType.NVarChar, 50).Value = ob.makh;
            cmd.Parameters.Add("@tkh", SqlDbType.NVarChar, 50).Value = ob.tenkh;
            cmd.Parameters.Add("@dc", SqlDbType.NVarChar, 50).Value = ob.diachi;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                DialogResult tl = MessageBox.Show("Mã khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        //lenh update
        public void update(KHACHHANG ob)
        {
            string sql = "Update KHACHHANG set hoten='" + ob.tenkh + "' ,diachi='" + ob.diachi + "' where makh='" + ob.makh + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        // lenh delete
        public void delete(KHACHHANG ob)
        {
            string sql = "DELETE from KHACHHANG where makh='" + ob.makh + "'";
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
            KHACHHANG ob = new KHACHHANG();
            ob.conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, ob.conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            ob.conn.Close();
            return dt;
        }
    }
}
