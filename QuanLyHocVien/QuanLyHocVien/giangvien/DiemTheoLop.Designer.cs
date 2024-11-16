namespace QuanLyHocVien.giangvien
{
    partial class DiemTheoLop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clmDiemTrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiemDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiemNoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiemNghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.gridLop = new System.Windows.Forms.DataGridView();
            this.clmMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.gridThongKe = new System.Windows.Forms.DataGridView();
            this.clmDiemViet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnHienTatCa = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaoBaoCao = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongKe)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clmDiemTrungBinh
            // 
            this.clmDiemTrungBinh.DataPropertyName = "DiemTrungBinh";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.clmDiemTrungBinh.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmDiemTrungBinh.FillWeight = 75F;
            this.clmDiemTrungBinh.HeaderText = "Điểm trung bình";
            this.clmDiemTrungBinh.MinimumWidth = 6;
            this.clmDiemTrungBinh.Name = "clmDiemTrungBinh";
            this.clmDiemTrungBinh.ReadOnly = true;
            // 
            // clmDiemDoc
            // 
            this.clmDiemDoc.DataPropertyName = "DiemDoc";
            this.clmDiemDoc.FillWeight = 50F;
            this.clmDiemDoc.HeaderText = "Điểm đọc";
            this.clmDiemDoc.MinimumWidth = 6;
            this.clmDiemDoc.Name = "clmDiemDoc";
            this.clmDiemDoc.ReadOnly = true;
            // 
            // clmDiemNoi
            // 
            this.clmDiemNoi.DataPropertyName = "DiemNoi";
            this.clmDiemNoi.FillWeight = 50F;
            this.clmDiemNoi.HeaderText = "Điểm nói";
            this.clmDiemNoi.MinimumWidth = 6;
            this.clmDiemNoi.Name = "clmDiemNoi";
            this.clmDiemNoi.ReadOnly = true;
            // 
            // clmDiemNghe
            // 
            this.clmDiemNghe.DataPropertyName = "DiemNghe";
            this.clmDiemNghe.FillWeight = 50F;
            this.clmDiemNghe.HeaderText = "Điểm nghe";
            this.clmDiemNghe.MinimumWidth = 6;
            this.clmDiemNghe.Name = "clmDiemNghe";
            this.clmDiemNghe.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Kết quả tìm kiếm";
            // 
            // gridLop
            // 
            this.gridLop.AllowUserToAddRows = false;
            this.gridLop.AllowUserToResizeRows = false;
            this.gridLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLop.BackgroundColor = System.Drawing.Color.White;
            this.gridLop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaLop,
            this.clmTenLop});
            this.gridLop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLop.Location = new System.Drawing.Point(21, 161);
            this.gridLop.MultiSelect = false;
            this.gridLop.Name = "gridLop";
            this.gridLop.ReadOnly = true;
            this.gridLop.RowHeadersVisible = false;
            this.gridLop.RowHeadersWidth = 51;
            this.gridLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLop.Size = new System.Drawing.Size(279, 277);
            this.gridLop.TabIndex = 64;
            // 
            // clmMaLop
            // 
            this.clmMaLop.DataPropertyName = "MaLop";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
            this.clmMaLop.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmMaLop.FillWeight = 70F;
            this.clmMaLop.HeaderText = "Mã lớp";
            this.clmMaLop.MinimumWidth = 6;
            this.clmMaLop.Name = "clmMaLop";
            this.clmMaLop.ReadOnly = true;
            // 
            // clmTenLop
            // 
            this.clmTenLop.DataPropertyName = "TenLop";
            this.clmTenLop.FillWeight = 93.27411F;
            this.clmTenLop.HeaderText = "Tên lớp";
            this.clmTenLop.MinimumWidth = 6;
            this.clmTenLop.Name = "clmTenLop";
            this.clmTenLop.ReadOnly = true;
            // 
            // clmTenHV
            // 
            this.clmTenHV.DataPropertyName = "TenHV";
            this.clmTenHV.HeaderText = "Tên học viên";
            this.clmTenHV.MinimumWidth = 6;
            this.clmTenHV.Name = "clmTenHV";
            this.clmTenHV.ReadOnly = true;
            // 
            // clmMaHV
            // 
            this.clmMaHV.DataPropertyName = "MaHV";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Blue;
            this.clmMaHV.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmMaHV.FillWeight = 70F;
            this.clmMaHV.HeaderText = "Mã học viên";
            this.clmMaHV.MinimumWidth = 6;
            this.clmMaHV.Name = "clmMaHV";
            this.clmMaHV.ReadOnly = true;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaLop.Location = new System.Drawing.Point(98, 45);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(202, 30);
            this.txtMaLop.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mã lớp:";
            // 
            // lblTongCong
            // 
            this.lblTongCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongCong.AutoSize = true;
            this.lblTongCong.Location = new System.Drawing.Point(16, 471);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(331, 16);
            this.lblTongCong.TabIndex = 68;
            this.lblTongCong.Text = "Tổng cộng: 0 học viên. Điểm trung bình của lớp: 0 điểm.";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(144, 16);
            this.label24.TabIndex = 67;
            this.label24.Text = "Thống kê điểm của lớp";
            // 
            // gridThongKe
            // 
            this.gridThongKe.AllowUserToAddRows = false;
            this.gridThongKe.AllowUserToResizeRows = false;
            this.gridThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridThongKe.BackgroundColor = System.Drawing.Color.White;
            this.gridThongKe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaHV,
            this.clmTenHV,
            this.clmDiemNghe,
            this.clmDiemNoi,
            this.clmDiemDoc,
            this.clmDiemViet,
            this.clmDiemTrungBinh});
            this.gridThongKe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridThongKe.Location = new System.Drawing.Point(19, 45);
            this.gridThongKe.MultiSelect = false;
            this.gridThongKe.Name = "gridThongKe";
            this.gridThongKe.ReadOnly = true;
            this.gridThongKe.RowHeadersVisible = false;
            this.gridThongKe.RowHeadersWidth = 51;
            this.gridThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridThongKe.Size = new System.Drawing.Size(572, 423);
            this.gridThongKe.TabIndex = 66;
            // 
            // clmDiemViet
            // 
            this.clmDiemViet.DataPropertyName = "DiemViet";
            this.clmDiemViet.FillWeight = 50F;
            this.clmDiemViet.HeaderText = "Điểm viết";
            this.clmDiemViet.MinimumWidth = 6;
            this.clmDiemViet.Name = "clmDiemViet";
            this.clmDiemViet.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 28);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tìm kiếm lớp học";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnTaoBaoCao);
            this.panel6.Controls.Add(this.lblTongCong);
            this.panel6.Controls.Add(this.label24);
            this.panel6.Controls.Add(this.gridThongKe);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(325, 24);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(606, 496);
            this.panel6.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(320, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 496);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHienTatCa);
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.gridLop);
            this.panel2.Controls.Add(this.txtMaLop);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 496);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ ĐIỂM THEO LỚP";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::QuanLyHocVien.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(891, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 19);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 24);
            this.panel1.TabIndex = 14;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(180, 90);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(120, 29);
            this.guna2Button1.TabIndex = 70;
            this.guna2Button1.Text = "Đặt Lại";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BorderRadius = 10;
            this.btnTimKiem.BorderThickness = 1;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(22, 90);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(113, 29);
            this.btnTimKiem.TabIndex = 69;
            this.btnTimKiem.Text = "Tìm Kiếm";
            // 
            // btnHienTatCa
            // 
            this.btnHienTatCa.BorderRadius = 10;
            this.btnHienTatCa.BorderThickness = 1;
            this.btnHienTatCa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHienTatCa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHienTatCa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHienTatCa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHienTatCa.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btnHienTatCa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHienTatCa.ForeColor = System.Drawing.Color.White;
            this.btnHienTatCa.Location = new System.Drawing.Point(144, 444);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(156, 27);
            this.btnHienTatCa.TabIndex = 76;
            this.btnHienTatCa.Text = "Hiện Tất Cả";
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.BorderRadius = 10;
            this.btnTaoBaoCao.BorderThickness = 1;
            this.btnTaoBaoCao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoBaoCao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaoBaoCao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaoBaoCao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaoBaoCao.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btnTaoBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTaoBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnTaoBaoCao.Location = new System.Drawing.Point(426, 12);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(156, 27);
            this.btnTaoBaoCao.TabIndex = 77;
            this.btnTaoBaoCao.Text = "Tạo Báo Cáo";
            // 
            // DiemTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 520);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DiemTheoLop";
            this.Text = "DiemTheoLop";
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongKe)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiemTrungBinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiemDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiemNoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiemNghe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaHV;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView gridThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiemViet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnTaoBaoCao;
        private Guna.UI2.WinForms.Guna2Button btnHienTatCa;
    }
}