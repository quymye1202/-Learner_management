namespace QuanLyHocVien.lophoc
{
    partial class xeplop
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
            this.label5 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTongCongHVLop = new System.Windows.Forms.Label();
            this.gridDSHVLop = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongCongHV = new System.Windows.Forms.Label();
            this.gridDSHV = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnThem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnThemVaoLop = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDatLai = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLuuLop = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLoaiKhoiLop = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSHVLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSHV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "Danh sách học viên trong lớp";
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(239, 11);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(215, 31);
            this.cboLop.TabIndex = 67;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "Danh sách lớp :";
            // 
            // lblTongCongHVLop
            // 
            this.lblTongCongHVLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongCongHVLop.AutoSize = true;
            this.lblTongCongHVLop.Location = new System.Drawing.Point(15, 485);
            this.lblTongCongHVLop.Name = "lblTongCongHVLop";
            this.lblTongCongHVLop.Size = new System.Drawing.Size(138, 16);
            this.lblTongCongHVLop.TabIndex = 15;
            this.lblTongCongHVLop.Text = "Tổng cộng: 0 học viên";
            // 
            // gridDSHVLop
            // 
            this.gridDSHVLop.AllowUserToAddRows = false;
            this.gridDSHVLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDSHVLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDSHVLop.BackgroundColor = System.Drawing.Color.White;
            this.gridDSHVLop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDSHVLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDSHVLop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridDSHVLop.Location = new System.Drawing.Point(16, 68);
            this.gridDSHVLop.MultiSelect = false;
            this.gridDSHVLop.Name = "gridDSHVLop";
            this.gridDSHVLop.ReadOnly = true;
            this.gridDSHVLop.RowHeadersVisible = false;
            this.gridDSHVLop.RowHeadersWidth = 51;
            this.gridDSHVLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDSHVLop.Size = new System.Drawing.Size(500, 365);
            this.gridDSHVLop.TabIndex = 69;
            this.gridDSHVLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDSHVLop_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Danh sách các học viên chưa có lớp";
            // 
            // lblTongCongHV
            // 
            this.lblTongCongHV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongCongHV.AutoSize = true;
            this.lblTongCongHV.Location = new System.Drawing.Point(18, 484);
            this.lblTongCongHV.Name = "lblTongCongHV";
            this.lblTongCongHV.Size = new System.Drawing.Size(138, 16);
            this.lblTongCongHV.TabIndex = 14;
            this.lblTongCongHV.Text = "Tổng cộng: 0 học viên";
            // 
            // gridDSHV
            // 
            this.gridDSHV.AllowUserToAddRows = false;
            this.gridDSHV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDSHV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDSHV.BackgroundColor = System.Drawing.Color.White;
            this.gridDSHV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDSHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDSHV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridDSHV.Location = new System.Drawing.Point(21, 45);
            this.gridDSHV.MultiSelect = false;
            this.gridDSHV.Name = "gridDSHV";
            this.gridDSHV.RowHeadersVisible = false;
            this.gridDSHV.RowHeadersWidth = 51;
            this.gridDSHV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDSHV.Size = new System.Drawing.Size(472, 387);
            this.gridDSHV.TabIndex = 13;
            this.gridDSHV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDSHV_CellClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 23);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            this.splitContainer1.Panel1.Controls.Add(this.btnThemVaoLop);
            this.splitContainer1.Panel1.Controls.Add(this.lblTongCongHV);
            this.splitContainer1.Panel1.Controls.Add(this.gridDSHV);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1045, 509);
            this.splitContainer1.SplitterDistance = 513;
            this.splitContainer1.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnThem.FillColor2 = System.Drawing.Color.Red;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(310, 443);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 34);
            this.btnThem.TabIndex = 76;
            this.btnThem.Text = "Thêm vào";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThemVaoLop
            // 
            this.btnThemVaoLop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemVaoLop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemVaoLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemVaoLop.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemVaoLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemVaoLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemVaoLop.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoLop.Location = new System.Drawing.Point(219, 437);
            this.btnThemVaoLop.Name = "btnThemVaoLop";
            this.btnThemVaoLop.Size = new System.Drawing.Size(178, 0);
            this.btnThemVaoLop.TabIndex = 31;
            this.btnThemVaoLop.Text = "Thêm Vào Lớp";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDatLai);
            this.panel2.Controls.Add(this.btnLuuLop);
            this.panel2.Controls.Add(this.btnLoaiKhoiLop);
            this.panel2.Controls.Add(this.lblTongCongHVLop);
            this.panel2.Controls.Add(this.gridDSHVLop);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cboLop);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 509);
            this.panel2.TabIndex = 0;
            // 
            // btnDatLai
            // 
            this.btnDatLai.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDatLai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatLai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatLai.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatLai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnDatLai.FillColor2 = System.Drawing.Color.Red;
            this.btnDatLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDatLai.ForeColor = System.Drawing.Color.White;
            this.btnDatLai.Location = new System.Drawing.Point(421, 443);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(97, 34);
            this.btnDatLai.TabIndex = 75;
            this.btnDatLai.Text = "Đặt Lại";
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // btnLuuLop
            // 
            this.btnLuuLop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuuLop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuLop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuLop.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnLuuLop.FillColor2 = System.Drawing.Color.Red;
            this.btnLuuLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuuLop.ForeColor = System.Drawing.Color.White;
            this.btnLuuLop.Location = new System.Drawing.Point(293, 443);
            this.btnLuuLop.Name = "btnLuuLop";
            this.btnLuuLop.Size = new System.Drawing.Size(97, 34);
            this.btnLuuLop.TabIndex = 74;
            this.btnLuuLop.Text = "Lưu Lớp";
            this.btnLuuLop.Click += new System.EventHandler(this.btnLuuLop_Click);
            // 
            // btnLoaiKhoiLop
            // 
            this.btnLoaiKhoiLop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLoaiKhoiLop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoaiKhoiLop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoaiKhoiLop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoaiKhoiLop.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoaiKhoiLop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoaiKhoiLop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnLoaiKhoiLop.FillColor2 = System.Drawing.Color.Red;
            this.btnLoaiKhoiLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoaiKhoiLop.ForeColor = System.Drawing.Color.White;
            this.btnLoaiKhoiLop.Location = new System.Drawing.Point(18, 443);
            this.btnLoaiKhoiLop.Name = "btnLoaiKhoiLop";
            this.btnLoaiKhoiLop.Size = new System.Drawing.Size(135, 34);
            this.btnLoaiKhoiLop.TabIndex = 73;
            this.btnLoaiKhoiLop.Text = "Loại Khỏi Lớp";
            this.btnLoaiKhoiLop.Click += new System.EventHandler(this.btnLoaiKhoiLop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "XẾP LỚP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 23);
            this.panel1.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::QuanLyHocVien.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1014, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 27);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // xeplop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 532);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "xeplop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xeplop";
            this.Load += new System.EventHandler(this.xeplop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDSHVLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSHV)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTongCongHVLop;
        private System.Windows.Forms.DataGridView gridDSHVLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTongCongHV;
        private System.Windows.Forms.DataGridView gridDSHV;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnThemVaoLop;
        private Guna.UI2.WinForms.Guna2GradientButton btnLuuLop;
        private Guna.UI2.WinForms.Guna2GradientButton btnLoaiKhoiLop;
        private Guna.UI2.WinForms.Guna2GradientButton btnDatLai;
        private Guna.UI2.WinForms.Guna2GradientButton btnThem;
    }
}