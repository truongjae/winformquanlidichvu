using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Quanlidichvu
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        CHUNGTU ob = new CHUNGTU();
        private void Form5_Load(object sender, EventArgs e)
        {
            chonmakh.DataSource = ob.LoadTable("select * from KHACHHANG");
            chonmakh.DisplayMember = "hoten";
            chonmakh.ValueMember = "makh";
            Console.Write(chonmakh.ValueMember);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = chonmakh.Text;
            

            string sql1;
            sql1 = "select kh.hoten, kh.diachi, dv.dongia, dv.tendv, ct.soluong, ct.soluong*dv.dongia as thanhtien from DICHVU dv , KHACHHANG kh, CHUNGTU ct where dv.madv = ct.madv and ct.makh = kh.makh and ct.makh='" + chonmakh.SelectedValue.ToString() +"'";
            DataTable dt = new DataTable();
            dt = ob.LoadTable(sql1); // Sql chuyển Database thành DataSet
            //Khai báo mode làm việc của reportview
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"E:\hoc Csharp\Quanlidichvu\Quanlidichvu\Quanlidichvu\Report1.rdlc";
            //Truyền giá trị từ form vào biến cho report
            //đặt nguồn cho report và report viewer
            if (dt.Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1"; rds.Value = dt;
                reportViewer1.LocalReport.DataSources.Clear();
                //Add dữ liệu vào
                reportViewer1.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                reportViewer1.RefreshReport();
            }
            else
                MessageBox.Show("Không có dữ liệu");
        }
    }
}
