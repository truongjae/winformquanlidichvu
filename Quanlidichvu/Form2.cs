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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DICHVU ob = new DICHVU(txtmadv.Text, txttendv.Text, int.Parse(txtdongia.Text));
            ob.Insert(ob);
            ob.HienThi(view);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                DICHVU ob = new DICHVU(txtmadv.Text, txttendv.Text, int.Parse(txtdongia.Text));
                ob.update(ob);
                ob.HienThi(view);
            }
        }

        private void view_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in view.SelectedItems)
            {
                txtmadv.Text = item.SubItems[1].Text;
                txttendv.Text = item.SubItems[2].Text;
                txtdongia.Text = item.SubItems[3].Text;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DICHVU ob = new DICHVU();
            ob.HienThi(view);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                DICHVU ob = new DICHVU(txtmadv.Text, txttendv.Text, int.Parse(txtdongia.Text));
                ob.delete(ob);
                ob.HienThi(view);
            }
        }
    }
}
