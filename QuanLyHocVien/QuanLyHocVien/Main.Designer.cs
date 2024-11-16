namespace QuanLyHocVien
{
    partial class Main
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
            this.họcViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinHọcViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHọcViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menugiangvien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuhocvien = new System.Windows.Forms.MenuStrip();
            this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xếpLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuhocvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // họcViênToolStripMenuItem
            // 
            this.họcViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinHọcViênToolStripMenuItem,
            this.quảnLýHọcViênToolStripMenuItem});
            this.họcViênToolStripMenuItem.Name = "họcViênToolStripMenuItem";
            this.họcViênToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.họcViênToolStripMenuItem.Text = "Học Viên";
            // 
            // thôngTinHọcViênToolStripMenuItem
            // 
            this.thôngTinHọcViênToolStripMenuItem.Name = "thôngTinHọcViênToolStripMenuItem";
            this.thôngTinHọcViênToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.thôngTinHọcViênToolStripMenuItem.Text = "Thông Tin Học Viên";
            this.thôngTinHọcViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinHọcViênToolStripMenuItem_Click);
            // 
            // quảnLýHọcViênToolStripMenuItem
            // 
            this.quảnLýHọcViênToolStripMenuItem.Name = "quảnLýHọcViênToolStripMenuItem";
            this.quảnLýHọcViênToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.quảnLýHọcViênToolStripMenuItem.Text = "Quản Lý Học Viên";
            // 
            // menugiangvien
            // 
            this.menugiangvien.Name = "menugiangvien";
            this.menugiangvien.Size = new System.Drawing.Size(83, 21);
            this.menugiangvien.Text = "Giảng Viên";
            // 
            // menuhocvien
            // 
            this.menuhocvien.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuhocvien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.họcViênToolStripMenuItem,
            this.menugiangvien,
            this.lớpHọcToolStripMenuItem});
            this.menuhocvien.Location = new System.Drawing.Point(0, 0);
            this.menuhocvien.Name = "menuhocvien";
            this.menuhocvien.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuhocvien.Size = new System.Drawing.Size(771, 25);
            this.menuhocvien.TabIndex = 0;
            this.menuhocvien.Text = "Học viên";
            // 
            // lớpHọcToolStripMenuItem
            // 
            this.lớpHọcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xếpLớpToolStripMenuItem});
            this.lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            this.lớpHọcToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.lớpHọcToolStripMenuItem.Text = "Lớp Học";
            // 
            // xếpLớpToolStripMenuItem
            // 
            this.xếpLớpToolStripMenuItem.Name = "xếpLớpToolStripMenuItem";
            this.xếpLớpToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.xếpLớpToolStripMenuItem.Text = "Xếp Lớp";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 399);
            this.Controls.Add(this.menuhocvien);
            this.MainMenuStrip = this.menuhocvien;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuhocvien.ResumeLayout(false);
            this.menuhocvien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem họcViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menugiangvien;
        private System.Windows.Forms.MenuStrip menuhocvien;
        private System.Windows.Forms.ToolStripMenuItem thôngTinHọcViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHọcViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xếpLớpToolStripMenuItem;
    }
}

