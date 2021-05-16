namespace Quanlidichvu
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngDựÁnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngNVDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nToolStripMenuItem
            // 
            this.nToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảngDựÁnToolStripMenuItem,
            this.bảngNhânViênToolStripMenuItem,
            this.bảngNVDAToolStripMenuItem});
            this.nToolStripMenuItem.Name = "nToolStripMenuItem";
            this.nToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.nToolStripMenuItem.Text = "Nhập dữ liệu";
            // 
            // bảngDựÁnToolStripMenuItem
            // 
            this.bảngDựÁnToolStripMenuItem.Name = "bảngDựÁnToolStripMenuItem";
            this.bảngDựÁnToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.bảngDựÁnToolStripMenuItem.Text = "Bảng dịch vụ";
            this.bảngDựÁnToolStripMenuItem.Click += new System.EventHandler(this.bảngDựÁnToolStripMenuItem_Click);
            // 
            // bảngNhânViênToolStripMenuItem
            // 
            this.bảngNhânViênToolStripMenuItem.Name = "bảngNhânViênToolStripMenuItem";
            this.bảngNhânViênToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.bảngNhânViênToolStripMenuItem.Text = "Bảng khách hàng";
            this.bảngNhânViênToolStripMenuItem.Click += new System.EventHandler(this.bảngNhânViênToolStripMenuItem_Click);
            // 
            // bảngNVDAToolStripMenuItem
            // 
            this.bảngNVDAToolStripMenuItem.Name = "bảngNVDAToolStripMenuItem";
            this.bảngNVDAToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.bảngNVDAToolStripMenuItem.Text = "Bảng chứng từ";
            this.bảngNVDAToolStripMenuItem.Click += new System.EventHandler(this.bảngNVDAToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            this.báoCáoToolStripMenuItem.Click += new System.EventHandler(this.báoCáoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 335);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngDựÁnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngNVDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
    }
}

