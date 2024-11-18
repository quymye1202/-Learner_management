using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.menuhocvien = new System.Windows.Forms.MenuStrip();
            this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbuser = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.họcViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinHọcViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHọcViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menugiangvien = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýGiảngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xếpLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khóaHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xêpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmTheoLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuhocvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(895, 51);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = null;
            // 
            // menuhocvien
            // 
            this.menuhocvien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuhocvien.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuhocvien.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuhocvien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.họcViênToolStripMenuItem,
            this.menugiangvien,
            this.lớpHọcToolStripMenuItem,
            this.điểmToolStripMenuItem,
            this.hệThốngToolStripMenuItem});
            this.menuhocvien.Location = new System.Drawing.Point(0, 0);
            this.menuhocvien.Name = "menuhocvien";
            this.menuhocvien.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuhocvien.Size = new System.Drawing.Size(1087, 36);
            this.menuhocvien.TabIndex = 8;
            this.menuhocvien.Text = "Học viên";
            // 
            // lớpHọcToolStripMenuItem
            // 
            this.lớpHọcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xếpLớpToolStripMenuItem,
            this.khóaHọcToolStripMenuItem,
            this.quảnLýLớpHọcToolStripMenuItem});
            this.lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            this.lớpHọcToolStripMenuItem.Size = new System.Drawing.Size(104, 32);
            this.lớpHọcToolStripMenuItem.Text = "Lớp Học";
            // 
            // lbuser
            // 
            this.lbuser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.Location = new System.Drawing.Point(923, 11);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(65, 25);
            this.lbuser.TabIndex = 10;
            this.lbuser.Text = "Chào ";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = global::QuanLyHocVien.Properties.Resources.Basic_English_Class_Banner;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 36);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1087, 545);
            this.guna2Panel1.TabIndex = 9;
            // 
            // họcViênToolStripMenuItem
            // 
            this.họcViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinHọcViênToolStripMenuItem,
            this.quảnLýHọcViênToolStripMenuItem});
            this.họcViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("họcViênToolStripMenuItem.Image")));
            this.họcViênToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.họcViênToolStripMenuItem.Name = "họcViênToolStripMenuItem";
            this.họcViênToolStripMenuItem.Size = new System.Drawing.Size(131, 32);
            this.họcViênToolStripMenuItem.Text = "Học Viên";
            // 
            // thôngTinHọcViênToolStripMenuItem
            // 
            this.thôngTinHọcViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thôngTinHọcViênToolStripMenuItem.Image")));
            this.thôngTinHọcViênToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thôngTinHọcViênToolStripMenuItem.Name = "thôngTinHọcViênToolStripMenuItem";
            this.thôngTinHọcViênToolStripMenuItem.Size = new System.Drawing.Size(285, 32);
            this.thôngTinHọcViênToolStripMenuItem.Text = "Thông Tin Học Viên";
            this.thôngTinHọcViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinHọcViênToolStripMenuItem_Click_1);
            // 
            // quảnLýHọcViênToolStripMenuItem
            // 
            this.quảnLýHọcViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýHọcViênToolStripMenuItem.Image")));
            this.quảnLýHọcViênToolStripMenuItem.Name = "quảnLýHọcViênToolStripMenuItem";
            this.quảnLýHọcViênToolStripMenuItem.Size = new System.Drawing.Size(285, 32);
            this.quảnLýHọcViênToolStripMenuItem.Text = "Quản Lý Học Viên";
            this.quảnLýHọcViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHọcViênToolStripMenuItem_Click_1);
            // 
            // menugiangvien
            // 
            this.menugiangvien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.quảnLýGiảngViênToolStripMenuItem});
            this.menugiangvien.Image = ((System.Drawing.Image)(resources.GetObject("menugiangvien.Image")));
            this.menugiangvien.Name = "menugiangvien";
            this.menugiangvien.Size = new System.Drawing.Size(149, 32);
            this.menugiangvien.Text = "Giảng Viên";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýToolStripMenuItem.Image")));
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.quảnLýToolStripMenuItem.Text = "Thông Tin Giảng Viên";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click_1);
            // 
            // quảnLýGiảngViênToolStripMenuItem
            // 
            this.quảnLýGiảngViênToolStripMenuItem.Name = "quảnLýGiảngViênToolStripMenuItem";
            this.quảnLýGiảngViênToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.quảnLýGiảngViênToolStripMenuItem.Text = "Quản Lý Giảng Viên";
            this.quảnLýGiảngViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýGiảngViênToolStripMenuItem_Click_1);
            // 
            // xếpLớpToolStripMenuItem
            // 
            this.xếpLớpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xếpLớpToolStripMenuItem.Image")));
            this.xếpLớpToolStripMenuItem.Name = "xếpLớpToolStripMenuItem";
            this.xếpLớpToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.xếpLớpToolStripMenuItem.Text = "Xếp Lớp";
            this.xếpLớpToolStripMenuItem.Click += new System.EventHandler(this.xếpLớpToolStripMenuItem_Click);
            // 
            // khóaHọcToolStripMenuItem
            // 
            this.khóaHọcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("khóaHọcToolStripMenuItem.Image")));
            this.khóaHọcToolStripMenuItem.Name = "khóaHọcToolStripMenuItem";
            this.khóaHọcToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.khóaHọcToolStripMenuItem.Text = "Khóa Học";
            this.khóaHọcToolStripMenuItem.Click += new System.EventHandler(this.khóaHọcToolStripMenuItem_Click_1);
            // 
            // quảnLýLớpHọcToolStripMenuItem
            // 
            this.quảnLýLớpHọcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýLớpHọcToolStripMenuItem.Image")));
            this.quảnLýLớpHọcToolStripMenuItem.Name = "quảnLýLớpHọcToolStripMenuItem";
            this.quảnLýLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.quảnLýLớpHọcToolStripMenuItem.Text = "Quản lý lớp học";
            this.quảnLýLớpHọcToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLớpHọcToolStripMenuItem_Click);
            // 
            // điểmToolStripMenuItem
            // 
            this.điểmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xêpToolStripMenuItem,
            this.điểmTheoLớpToolStripMenuItem});
            this.điểmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("điểmToolStripMenuItem.Image")));
            this.điểmToolStripMenuItem.Name = "điểmToolStripMenuItem";
            this.điểmToolStripMenuItem.Size = new System.Drawing.Size(96, 32);
            this.điểmToolStripMenuItem.Text = "Điểm";
            // 
            // xêpToolStripMenuItem
            // 
            this.xêpToolStripMenuItem.Name = "xêpToolStripMenuItem";
            this.xêpToolStripMenuItem.Size = new System.Drawing.Size(234, 32);
            this.xêpToolStripMenuItem.Text = "Quản lý Điểm";
            this.xêpToolStripMenuItem.Click += new System.EventHandler(this.xêpToolStripMenuItem_Click);
            // 
            // điểmTheoLớpToolStripMenuItem
            // 
            this.điểmTheoLớpToolStripMenuItem.Name = "điểmTheoLớpToolStripMenuItem";
            this.điểmTheoLớpToolStripMenuItem.Size = new System.Drawing.Size(234, 32);
            this.điểmTheoLớpToolStripMenuItem.Text = "Điểm theo lớp";
            this.điểmTheoLớpToolStripMenuItem.Click += new System.EventHandler(this.điểmTheoLớpToolStripMenuItem_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hệThốngToolStripMenuItem.Image")));
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đăngXuấtToolStripMenuItem.Image")));
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 581);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.menuhocvien);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuhocvien.ResumeLayout(false);
            this.menuhocvien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.MenuStrip menuhocvien;
        private System.Windows.Forms.ToolStripMenuItem họcViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinHọcViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHọcViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menugiangvien;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýGiảngViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xếpLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khóaHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điểmToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xêpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điểmTheoLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpHọcToolStripMenuItem;
        private System.Windows.Forms.Label lbuser;
    }
}

