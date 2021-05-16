namespace Quanlidichvu
{
    partial class Form2
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
            this.txtmadv = new System.Windows.Forms.TextBox();
            this.txttendv = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.ListView();
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.madv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tendv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập tên dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập đơn giá";
            // 
            // txtmadv
            // 
            this.txtmadv.Location = new System.Drawing.Point(255, 51);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.Size = new System.Drawing.Size(172, 22);
            this.txtmadv.TabIndex = 3;
            // 
            // txttendv
            // 
            this.txttendv.Location = new System.Drawing.Point(255, 93);
            this.txttendv.Name = "txttendv";
            this.txttendv.Size = new System.Drawing.Size(172, 22);
            this.txttendv.TabIndex = 4;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(255, 143);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(172, 22);
            this.txtdongia.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(536, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // view
            // 
            this.view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.madv,
            this.tendv,
            this.dongia});
            this.view.FullRowSelect = true;
            this.view.GridLines = true;
            this.view.Location = new System.Drawing.Point(25, 187);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(694, 260);
            this.view.TabIndex = 10;
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
            this.madv.Width = 100;
            // 
            // tendv
            // 
            this.tendv.Text = "Tên dịch vụ";
            this.tendv.Width = 100;
            // 
            // dongia
            // 
            this.dongia.Text = "Đơn giá";
            this.dongia.Width = 100;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 449);
            this.Controls.Add(this.view);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.txttendv);
            this.Controls.Add(this.txtmadv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmadv;
        private System.Windows.Forms.TextBox txttendv;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView view;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.ColumnHeader madv;
        private System.Windows.Forms.ColumnHeader tendv;
        private System.Windows.Forms.ColumnHeader dongia;
    }
}