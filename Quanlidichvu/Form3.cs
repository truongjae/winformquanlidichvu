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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void view_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in view.SelectedItems)
            {
                txtmakh.Text = item.SubItems[1].Text;
                txttenkh.Text = item.SubItems[2].Text;
                txtdiachi.Text = item.SubItems[3].Text;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            KHACHHANG ob = new KHACHHANG();
            ob.HienThi(view);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KHACHHANG ob = new KHACHHANG(txtmakh.Text, txttenkh.Text, txtdiachi.Text);
            ob.Insert(ob);
            ob.HienThi(view);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                KHACHHANG ob = new KHACHHANG(txtmakh.Text, txttenkh.Text, txtdiachi.Text);
                ob.update(ob);
                ob.HienThi(view);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                KHACHHANG ob = new KHACHHANG(txtmakh.Text, txttenkh.Text, txtdiachi.Text);
                ob.delete(ob);
                ob.HienThi(view);
            }
        }
    }
}
