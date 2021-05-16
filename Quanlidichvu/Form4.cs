using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlidichvu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        CHUNGTU ob = new CHUNGTU();
        private void Form4_Load(object sender, EventArgs e)
        {
            chonmadv.DataSource = ob.LoadTable("select * from DICHVU");
            chonmadv.DisplayMember = "tendv";
            chonmadv.ValueMember = "madv";
            chonmakh.DataSource = ob.LoadTable("select * from KHACHHANG");
            chonmakh.DisplayMember = "hoten";
            chonmakh.ValueMember = "makh";
            ob.HienThi(view);

        }
        string dv, kh, ct;
        string date;
        int sl;

        private void button1_Click(object sender, EventArgs e)
        {
            ct = txtmact.Text;
            date = txtngay.Text;
            sl = int.Parse(txtsoluong.Text);
            dv = chonmadv.SelectedValue.ToString();
            kh = chonmakh.SelectedValue.ToString();
            string sqlconn;
            sqlconn = "INSERT INTO CHUNGTU (madv, makh, mact,ngay,soluong) VALUES ('" + dv + "' ,'" + kh + "', '" + ct + "' , '" + date +"',"+sl+ ")";
            ob.Excecute(sqlconn);
            ob.HienThi(view);
        }

        private void view_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in view.SelectedItems)
            {
                txtmact.Text = item.SubItems[1].Text;
                txtngay.Text = item.SubItems[2].Text;
                txtsoluong.Text = item.SubItems[5].Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ct = txtmact.Text;
            date = txtngay.Text;
            sl = int.Parse(txtsoluong.Text);
            dv = chonmadv.SelectedValue.ToString();
            kh = chonmakh.SelectedValue.ToString();
            string sqlconn;
            sqlconn = "UPDATE CHUNGTU set mact ='" + ct + "', soluong='" + sl + "' where makh='"+kh+"' and madv='"+dv+"'";
            ob.Excecute(sqlconn);
            ob.HienThi(view);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ct = txtmact.Text;
            date = txtngay.Text;
            sl = int.Parse(txtsoluong.Text);
            dv = chonmadv.SelectedValue.ToString();
            kh = chonmakh.SelectedValue.ToString();
            string sqlconn;
            sqlconn = "DELETE from CHUNGTU where makh='"+kh+"' and madv='" +dv+ "'";
            ob.Excecute(sqlconn);
            ob.HienThi(view);
        }
    }
}
