namespace Quanlidichvu
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.ListView();
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.makh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenkh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập địa chỉ";
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(357, 40);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(182, 22);
            this.txtmakh.TabIndex = 3;
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(357, 81);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(182, 22);
            this.txttenkh.TabIndex = 4;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(357, 130);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(182, 22);
            this.txtdiachi.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(696, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // view
            // 
            this.view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.makh,
            this.tenkh,
            this.diachi});
            this.view.FullRowSelect = true;
            this.view.GridLines = true;
            this.view.Location = new System.Drawing.Point(38, 191);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(812, 298);
            this.view.TabIndex = 9;
            this.view.UseCompatibleStateImageBehavior = false;
            this.view.View = System.Windows.Forms.View.Details;
            this.view.SelectedIndexChanged += new System.EventHandler(this.view_SelectedIndexChanged);
            // 
            // stt
            // 
            this.stt.Text = "STT";
            // 
            // makh
            // 
            this.makh.Text = "Mã khách hàng";
            this.makh.Width = 100;
            // 
            // tenkh
            // 
            this.tenkh.Text = "Tên khách hàng";
            this.tenkh.Width = 100;
            // 
            // diachi
            // 
            this.diachi.Text = "Địa chỉ";
            this.diachi.Width = 100;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 501);
            this.Controls.Add(this.view);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttenkh);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView view;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.ColumnHeader makh;
        private System.Windows.Forms.ColumnHeader tenkh;
        private System.Windows.Forms.ColumnHeader diachi;
    }
}