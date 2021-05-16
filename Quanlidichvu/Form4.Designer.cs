namespace Quanlidichvu
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chonmakh = new System.Windows.Forms.ComboBox();
            this.chonmadv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmact = new System.Windows.Forms.TextBox();
            this.txtngay = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.view = new System.Windows.Forms.ListView();
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.madv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.makh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(618, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chonmakh
            // 
            this.chonmakh.FormattingEnabled = true;
            this.chonmakh.Location = new System.Drawing.Point(277, 91);
            this.chonmakh.Name = "chonmakh";
            this.chonmakh.Size = new System.Drawing.Size(189, 24);
            this.chonmakh.TabIndex = 3;
            // 
            // chonmadv
            // 
            this.chonmadv.FormattingEnabled = true;
            this.chonmadv.Location = new System.Drawing.Point(277, 39);
            this.chonmadv.Name = "chonmadv";
            this.chonmadv.Size = new System.Drawing.Size(189, 24);
            this.chonmadv.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập mã chứng từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhập số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhập ngày";
            // 
            // txtmact
            // 
            this.txtmact.Location = new System.Drawing.Point(277, 132);
            this.txtmact.Name = "txtmact";
            this.txtmact.Size = new System.Drawing.Size(189, 22);
            this.txtmact.TabIndex = 10;
            // 
            // txtngay
            // 
            this.txtngay.Location = new System.Drawing.Point(277, 165);
            this.txtngay.Name = "txtngay";
            this.txtngay.Size = new System.Drawing.Size(189, 22);
            this.txtngay.TabIndex = 11;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(277, 205);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(189, 22);
            this.txtsoluong.TabIndex = 12;
            // 
            // view
            // 
            this.view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.mact,
            this.ngay,
            this.madv,
            this.makh,
            this.soluong});
            this.view.FullRowSelect = true;
            this.view.GridLines = true;
            this.view.Location = new System.Drawing.Point(32, 262);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(858, 287);
            this.view.TabIndex = 13;
            this.view.UseCompatibleStateImageBehavior = false;
            this.view.View = System.Windows.Forms.View.Details;
            this.view.SelectedIndexChanged += new System.EventHandler(this.view_SelectedIndexChanged);
            // 
            // stt
            // 
            this.stt.Text = "STT";
            // 
            // madv
            // 
            this.madv.Text = "Mã dịch vụ";
            this.madv.Width = 120;
            // 
            // makh
            // 
            this.makh.Text = "Mã khách hàng";
            this.makh.Width = 120;
            // 
            // mact
            // 
            this.mact.Text = "Mã chứng từ";
            this.mact.Width = 120;
            // 
            // ngay
            // 
            this.ngay.Text = "Ngày";
            this.ngay.Width = 120;
            // 
            // soluong
            // 
            this.soluong.Text = "Số lượng";
            this.soluong.Width = 120;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 561);
            this.Controls.Add(this.view);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtngay);
            this.Controls.Add(this.txtmact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chonmakh);
            this.Controls.Add(this.chonmadv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox chonmakh;
        private System.Windows.Forms.ComboBox chonmadv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmact;
        private System.Windows.Forms.TextBox txtngay;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.ListView view;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.ColumnHeader madv;
        private System.Windows.Forms.ColumnHeader makh;
        private System.Windows.Forms.ColumnHeader mact;
        private System.Windows.Forms.ColumnHeader ngay;
        private System.Windows.Forms.ColumnHeader soluong;
    }
}