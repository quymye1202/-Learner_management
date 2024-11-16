namespace QuanLyHocVien.giangvien
{
    partial class QuanLyGiangVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTongCongGV = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gridLop = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDangMo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTongCongLop = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHienTatCa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemGV = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDatLai = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.cboChuyenMon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkChuyenMon = new System.Windows.Forms.CheckBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkTenGV = new System.Windows.Forms.CheckBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkMaGV = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gridGV = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTongCongGV
            // 
            this.lblTongCongGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongCongGV.AutoSize = true;
            this.lblTongCongGV.Location = new System.Drawing.Point(9, 229);
            this.lblTongCongGV.Name = "lblTongCongGV";
            this.lblTongCongGV.Size = new System.Drawing.Size(182, 16);
            this.lblTongCongGV.TabIndex = 12;
            this.lblTongCongGV.Text = "Tổng cộng: <num> giảng viên";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gridLop);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 290);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(933, 225);
            this.panel4.TabIndex = 3;
            // 
            // gridLop
            // 
            this.gridLop.AllowUserToAddRows = false;
            this.gridLop.AllowUserToOrderColumns = true;
            this.gridLop.AllowUserToResizeRows = false;
            this.gridLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLop.BackgroundColor = System.Drawing.Color.White;
            this.gridLop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.clmDangMo,
            this.dataGridViewTextBoxColumn5});
            this.gridLop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLop.Location = new System.Drawing.Point(12, 23);
            this.gridLop.MultiSelect = false;
            this.gridLop.Name = "gridLop";
            this.gridLop.ReadOnly = true;
            this.gridLop.RowHeadersVisible = false;
            this.gridLop.RowHeadersWidth = 51;
            this.gridLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLop.Size = new System.Drawing.Size(909, 196);
            this.gridLop.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaLop";
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Blue;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn1.FillWeight = 70F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã lớp";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenLop";
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Green;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn2.FillWeight = 93.27411F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên lớp";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgayBD";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày bắt đầu";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NgayKT";
            this.dataGridViewTextBoxColumn4.FillWeight = 93.27411F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày kết thúc";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // clmDangMo
            // 
            this.clmDangMo.DataPropertyName = "DangMo";
            this.clmDangMo.HeaderText = "Đang mở";
            this.clmDangMo.MinimumWidth = 6;
            this.clmDangMo.Name = "clmDangMo";
            this.clmDangMo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SiSo";
            this.dataGridViewTextBoxColumn5.FillWeight = 93.27411F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Sỉ số";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Các lớp dạy";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTongCongLop);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 515);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 30);
            this.panel3.TabIndex = 2;
            // 
            // lblTongCongLop
            // 
            this.lblTongCongLop.AutoSize = true;
            this.lblTongCongLop.Location = new System.Drawing.Point(9, 7);
            this.lblTongCongLop.Name = "lblTongCongLop";
            this.lblTongCongLop.Size = new System.Drawing.Size(107, 16);
            this.lblTongCongLop.TabIndex = 11;
            this.lblTongCongLop.Text = "Tổng cộng: 0 lớp";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHienTatCa);
            this.panel2.Controls.Add(this.btnThemGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 37);
            this.panel2.TabIndex = 0;
            // 
            // btnHienTatCa
            // 
            this.btnHienTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHienTatCa.BorderRadius = 10;
            this.btnHienTatCa.BorderThickness = 1;
            this.btnHienTatCa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHienTatCa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHienTatCa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHienTatCa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHienTatCa.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btnHienTatCa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHienTatCa.ForeColor = System.Drawing.Color.White;
            this.btnHienTatCa.Location = new System.Drawing.Point(765, 6);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(156, 27);
            this.btnHienTatCa.TabIndex = 74;
            this.btnHienTatCa.Text = "Hiện Tất Cả";
            this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);
            // 
            // btnThemGV
            // 
            this.btnThemGV.BorderRadius = 10;
            this.btnThemGV.BorderThickness = 1;
            this.btnThemGV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemGV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemGV.FillColor = System.Drawing.Color.LimeGreen;
            this.btnThemGV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemGV.ForeColor = System.Drawing.Color.White;
            this.btnThemGV.Location = new System.Drawing.Point(12, 6);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(200, 27);
            this.btnThemGV.TabIndex = 71;
            this.btnThemGV.Text = "Cập nhật thông tin";
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 24);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ GIẢNG VIÊN";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.BackgroundImage = global::QuanLyHocVien.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1242, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 19);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.btnDatLai);
            this.splitContainer1.Panel1.Controls.Add(this.btnTimKiem);
            this.splitContainer1.Panel1.Controls.Add(this.cboChuyenMon);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.chkChuyenMon);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenGV);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.chkTenGV);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaGV);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.chkMaGV);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1282, 545);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.TabIndex = 8;
            // 
            // btnDatLai
            // 
            this.btnDatLai.BorderRadius = 10;
            this.btnDatLai.BorderThickness = 1;
            this.btnDatLai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatLai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLai.ForeColor = System.Drawing.Color.White;
            this.btnDatLai.Location = new System.Drawing.Point(197, 290);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(120, 29);
            this.btnDatLai.TabIndex = 66;
            this.btnDatLai.Text = "Đặt Lại";
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
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
            this.btnTimKiem.Location = new System.Drawing.Point(27, 290);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(113, 29);
            this.btnTimKiem.TabIndex = 65;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboChuyenMon
            // 
            this.cboChuyenMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChuyenMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenMon.Enabled = false;
            this.cboChuyenMon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboChuyenMon.FormattingEnabled = true;
            this.cboChuyenMon.Location = new System.Drawing.Point(138, 219);
            this.cboChuyenMon.Name = "cboChuyenMon";
            this.cboChuyenMon.Size = new System.Drawing.Size(187, 31);
            this.cboChuyenMon.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 63;
            this.label5.Text = "Chuyên môn:";
            // 
            // chkChuyenMon
            // 
            this.chkChuyenMon.AutoSize = true;
            this.chkChuyenMon.Location = new System.Drawing.Point(22, 191);
            this.chkChuyenMon.Name = "chkChuyenMon";
            this.chkChuyenMon.Size = new System.Drawing.Size(136, 20);
            this.chkChuyenMon.TabIndex = 62;
            this.chkChuyenMon.Text = "Theo chuyên môn";
            this.chkChuyenMon.UseVisualStyleBackColor = true;
            this.chkChuyenMon.CheckedChanged += new System.EventHandler(this.chkChuyenMon_CheckedChanged);
            // 
            // txtTenGV
            // 
            this.txtTenGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenGV.Enabled = false;
            this.txtTenGV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenGV.Location = new System.Drawing.Point(138, 151);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(187, 30);
            this.txtTenGV.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tên giảng viên:";
            // 
            // chkTenGV
            // 
            this.chkTenGV.AutoSize = true;
            this.chkTenGV.Location = new System.Drawing.Point(22, 126);
            this.chkTenGV.Name = "chkTenGV";
            this.chkTenGV.Size = new System.Drawing.Size(147, 20);
            this.chkTenGV.TabIndex = 49;
            this.chkTenGV.Text = "Theo tên giảng viên";
            this.chkTenGV.UseVisualStyleBackColor = true;
            this.chkTenGV.CheckedChanged += new System.EventHandler(this.chkTenGV_CheckedChanged);
            // 
            // txtMaGV
            // 
            this.txtMaGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaGV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaGV.Location = new System.Drawing.Point(138, 88);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(187, 30);
            this.txtMaGV.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mã giảng viên:";
            // 
            // chkMaGV
            // 
            this.chkMaGV.AutoSize = true;
            this.chkMaGV.Checked = true;
            this.chkMaGV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMaGV.Location = new System.Drawing.Point(22, 63);
            this.chkMaGV.Name = "chkMaGV";
            this.chkMaGV.Size = new System.Drawing.Size(148, 20);
            this.chkMaGV.TabIndex = 46;
            this.chkMaGV.Text = "Theo mã giảng viên";
            this.chkMaGV.UseVisualStyleBackColor = true;
            this.chkMaGV.CheckedChanged += new System.EventHandler(this.chkMaGV_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 31);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tìm kiếm giảng viên";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gridGV);
            this.panel5.Controls.Add(this.lblTongCongGV);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(933, 253);
            this.panel5.TabIndex = 4;
            // 
            // gridGV
            // 
            this.gridGV.AllowUserToAddRows = false;
            this.gridGV.AllowUserToResizeRows = false;
            this.gridGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridGV.BackgroundColor = System.Drawing.Color.White;
            this.gridGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridGV.Location = new System.Drawing.Point(0, 0);
            this.gridGV.MultiSelect = false;
            this.gridGV.Name = "gridGV";
            this.gridGV.ReadOnly = true;
            this.gridGV.RowHeadersVisible = false;
            this.gridGV.RowHeadersWidth = 51;
            this.gridGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGV.Size = new System.Drawing.Size(933, 253);
            this.gridGV.TabIndex = 2;
            // 
            // QuanLyGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 569);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyGiangVien";
            this.Text = "QuanLyGiangVien";
            this.Load += new System.EventHandler(this.QuanLyGiangVien_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTongCongGV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView gridLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmDangMo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTongCongLop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cboChuyenMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkChuyenMon;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTenGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkMaGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView gridGV;
        private Guna.UI2.WinForms.Guna2Button btnDatLai;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnHienTatCa;
        private Guna.UI2.WinForms.Guna2Button btnThemGV;
    }
}