namespace QuanLyHocVien.lophoc
{
    partial class QuanLyLopHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clmMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDangMo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmSiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.lblSiSo = new System.Windows.Forms.Label();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.gridLop = new System.Windows.Forms.DataGridView();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHienTatCa = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaHV = new Guna.UI2.WinForms.Guna2Button();
            this.bntSuaHV = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemLopHoc = new Guna.UI2.WinForms.Guna2Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDatLai = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.rdDong = new System.Windows.Forms.RadioButton();
            this.rdMo = new System.Windows.Forms.RadioButton();
            this.chkTinhTrang = new System.Windows.Forms.CheckBox();
            this.dateDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.chkKhoangTG = new System.Windows.Forms.CheckBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkKhoa = new System.Windows.Forms.CheckBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkTenLop = new System.Windows.Forms.CheckBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkMaLop = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // clmMaLop
            // 
            this.clmMaLop.DataPropertyName = "MaLop";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.clmMaLop.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmMaLop.FillWeight = 70F;
            this.clmMaLop.HeaderText = "Mã lớp";
            this.clmMaLop.MinimumWidth = 6;
            this.clmMaLop.Name = "clmMaLop";
            this.clmMaLop.ReadOnly = true;
            // 
            // clmTenLop
            // 
            this.clmTenLop.DataPropertyName = "TenLop";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
            this.clmTenLop.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmTenLop.FillWeight = 93.27411F;
            this.clmTenLop.HeaderText = "Tên lớp";
            this.clmTenLop.MinimumWidth = 6;
            this.clmTenLop.Name = "clmTenLop";
            this.clmTenLop.ReadOnly = true;
            // 
            // clmNgayBD
            // 
            this.clmNgayBD.DataPropertyName = "NgayBD";
            this.clmNgayBD.HeaderText = "Ngày bắt đầu";
            this.clmNgayBD.MinimumWidth = 6;
            this.clmNgayBD.Name = "clmNgayBD";
            this.clmNgayBD.ReadOnly = true;
            // 
            // clmNgayKT
            // 
            this.clmNgayKT.DataPropertyName = "NgayKT";
            this.clmNgayKT.FillWeight = 93.27411F;
            this.clmNgayKT.HeaderText = "Ngày kết thúc";
            this.clmNgayKT.MinimumWidth = 6;
            this.clmNgayKT.Name = "clmNgayKT";
            this.clmNgayKT.ReadOnly = true;
            // 
            // clmDangMo
            // 
            this.clmDangMo.DataPropertyName = "DangMo";
            this.clmDangMo.HeaderText = "Đang mở";
            this.clmDangMo.MinimumWidth = 6;
            this.clmDangMo.Name = "clmDangMo";
            this.clmDangMo.ReadOnly = true;
            // 
            // clmSiSo
            // 
            this.clmSiSo.DataPropertyName = "SiSo";
            this.clmSiSo.FillWeight = 93.27411F;
            this.clmSiSo.HeaderText = "Sỉ số";
            this.clmSiSo.MinimumWidth = 6;
            this.clmSiSo.Name = "clmSiSo";
            this.clmSiSo.ReadOnly = true;
            // 
            // lblTongCong
            // 
            this.lblTongCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongCong.AutoSize = true;
            this.lblTongCong.Location = new System.Drawing.Point(10, 361);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(107, 16);
            this.lblTongCong.TabIndex = 13;
            this.lblTongCong.Text = "Tổng cộng: 0 lớp";
            // 
            // lblSiSo
            // 
            this.lblSiSo.AutoSize = true;
            this.lblSiSo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSiSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.lblSiSo.Location = new System.Drawing.Point(142, 132);
            this.lblSiSo.Name = "lblSiSo";
            this.lblSiSo.Size = new System.Drawing.Size(79, 23);
            this.lblSiSo.TabIndex = 57;
            this.lblSiSo.Text = "<count>";
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNgayKetThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.lblNgayKetThuc.Location = new System.Drawing.Point(493, 92);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(105, 23);
            this.lblNgayKetThuc.TabIndex = 56;
            this.lblNgayKetThuc.Text = "<date end>";
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
            this.clmTenLop,
            this.clmNgayBD,
            this.clmNgayKT,
            this.clmDangMo,
            this.clmSiSo});
            this.gridLop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridLop.Location = new System.Drawing.Point(12, 5);
            this.gridLop.MultiSelect = false;
            this.gridLop.Name = "gridLop";
            this.gridLop.ReadOnly = true;
            this.gridLop.RowHeadersVisible = false;
            this.gridLop.RowHeadersWidth = 51;
            this.gridLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLop.Size = new System.Drawing.Size(828, 353);
            this.gridLop.TabIndex = 12;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNgayBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.lblNgayBatDau.Location = new System.Drawing.Point(493, 52);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(112, 23);
            this.lblNgayBatDau.TabIndex = 55;
            this.lblNgayBatDau.Text = "<date start>";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.lblMaLop.Location = new System.Drawing.Point(142, 52);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(50, 23);
            this.lblMaLop.TabIndex = 53;
            this.lblMaLop.Text = "<id>";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.label13.Location = new System.Drawing.Point(30, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 23);
            this.label13.TabIndex = 52;
            this.label13.Text = "Sỉ số:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(381, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 51;
            this.label7.Text = "Ngày kết thúc:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.label11.Location = new System.Drawing.Point(381, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 23);
            this.label11.TabIndex = 50;
            this.label11.Text = "Ngày bắt đầu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.label10.Location = new System.Drawing.Point(30, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 23);
            this.label10.TabIndex = 49;
            this.label10.Text = "Khóa:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(48)))), ((int)(((byte)(70)))));
            this.label19.Location = new System.Drawing.Point(30, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 23);
            this.label19.TabIndex = 48;
            this.label19.Text = "Mã lớp:";
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTenLop.ForeColor = System.Drawing.Color.Green;
            this.lblTenLop.Location = new System.Drawing.Point(24, 16);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(162, 32);
            this.lblTenLop.TabIndex = 47;
            this.lblTenLop.Text = "<class name>";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKhoa.ForeColor = System.Drawing.Color.Blue;
            this.lblKhoa.Location = new System.Drawing.Point(142, 91);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(134, 23);
            this.lblKhoa.TabIndex = 54;
            this.lblKhoa.Text = "<course name>";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gridLop);
            this.panel5.Controls.Add(this.lblTongCong);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(852, 386);
            this.panel5.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 24);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHienTatCa);
            this.panel2.Controls.Add(this.btnXoaHV);
            this.panel2.Controls.Add(this.bntSuaHV);
            this.panel2.Controls.Add(this.btnThemLopHoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 37);
            this.panel2.TabIndex = 0;
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
            this.btnHienTatCa.Location = new System.Drawing.Point(684, 7);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(156, 27);
            this.btnHienTatCa.TabIndex = 75;
            this.btnHienTatCa.Text = "Hiện Tất Cả";
            // 
            // btnXoaHV
            // 
            this.btnXoaHV.BorderRadius = 10;
            this.btnXoaHV.BorderThickness = 1;
            this.btnXoaHV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaHV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaHV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaHV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaHV.FillColor = System.Drawing.Color.LimeGreen;
            this.btnXoaHV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaHV.ForeColor = System.Drawing.Color.White;
            this.btnXoaHV.Location = new System.Drawing.Point(231, 4);
            this.btnXoaHV.Name = "btnXoaHV";
            this.btnXoaHV.Size = new System.Drawing.Size(68, 27);
            this.btnXoaHV.TabIndex = 70;
            this.btnXoaHV.Text = "Xóa";
            // 
            // bntSuaHV
            // 
            this.bntSuaHV.BorderRadius = 10;
            this.bntSuaHV.BorderThickness = 1;
            this.bntSuaHV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bntSuaHV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bntSuaHV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bntSuaHV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bntSuaHV.FillColor = System.Drawing.Color.LimeGreen;
            this.bntSuaHV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bntSuaHV.ForeColor = System.Drawing.Color.White;
            this.bntSuaHV.Location = new System.Drawing.Point(157, 4);
            this.bntSuaHV.Name = "bntSuaHV";
            this.bntSuaHV.Size = new System.Drawing.Size(68, 27);
            this.bntSuaHV.TabIndex = 69;
            this.bntSuaHV.Text = "Sửa";
            // 
            // btnThemLopHoc
            // 
            this.btnThemLopHoc.BorderRadius = 10;
            this.btnThemLopHoc.BorderThickness = 1;
            this.btnThemLopHoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemLopHoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemLopHoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemLopHoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemLopHoc.FillColor = System.Drawing.Color.LimeGreen;
            this.btnThemLopHoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemLopHoc.ForeColor = System.Drawing.Color.White;
            this.btnThemLopHoc.Location = new System.Drawing.Point(13, 4);
            this.btnThemLopHoc.Name = "btnThemLopHoc";
            this.btnThemLopHoc.Size = new System.Drawing.Size(138, 27);
            this.btnThemLopHoc.TabIndex = 68;
            this.btnThemLopHoc.Text = "Thêm Lớp Học";
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
            this.splitContainer1.Panel1.Controls.Add(this.rdDong);
            this.splitContainer1.Panel1.Controls.Add(this.rdMo);
            this.splitContainer1.Panel1.Controls.Add(this.chkTinhTrang);
            this.splitContainer1.Panel1.Controls.Add(this.dateDenNgay);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.dateTuNgay);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.chkKhoangTG);
            this.splitContainer1.Panel1.Controls.Add(this.cboKhoa);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.chkKhoa);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenLop);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.chkTenLop);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaLop);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.chkMaLop);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1201, 633);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.TabIndex = 9;
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
            this.btnDatLai.Location = new System.Drawing.Point(206, 456);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(120, 29);
            this.btnDatLai.TabIndex = 74;
            this.btnDatLai.Text = "Đặt Lại";
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
            this.btnTimKiem.Location = new System.Drawing.Point(36, 456);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(113, 29);
            this.btnTimKiem.TabIndex = 73;
            this.btnTimKiem.Text = "Tìm Kiếm";
            // 
            // rdDong
            // 
            this.rdDong.AutoSize = true;
            this.rdDong.Enabled = false;
            this.rdDong.Location = new System.Drawing.Point(181, 370);
            this.rdDong.Name = "rdDong";
            this.rdDong.Size = new System.Drawing.Size(79, 20);
            this.rdDong.TabIndex = 72;
            this.rdDong.Text = "Đã đóng";
            this.rdDong.UseVisualStyleBackColor = true;
            // 
            // rdMo
            // 
            this.rdMo.AutoSize = true;
            this.rdMo.Checked = true;
            this.rdMo.Enabled = false;
            this.rdMo.Location = new System.Drawing.Point(53, 370);
            this.rdMo.Name = "rdMo";
            this.rdMo.Size = new System.Drawing.Size(82, 20);
            this.rdMo.TabIndex = 71;
            this.rdMo.TabStop = true;
            this.rdMo.Text = "Đang mở";
            this.rdMo.UseVisualStyleBackColor = true;
            // 
            // chkTinhTrang
            // 
            this.chkTinhTrang.AutoSize = true;
            this.chkTinhTrang.Location = new System.Drawing.Point(23, 345);
            this.chkTinhTrang.Name = "chkTinhTrang";
            this.chkTinhTrang.Size = new System.Drawing.Size(117, 20);
            this.chkTinhTrang.TabIndex = 70;
            this.chkTinhTrang.Text = "Theo tình trạng";
            this.chkTinhTrang.UseVisualStyleBackColor = true;
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDenNgay.Enabled = false;
            this.dateDenNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateDenNgay.Location = new System.Drawing.Point(141, 305);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(185, 30);
            this.dateDenNgay.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 68;
            this.label5.Text = "Đến ngày:";
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTuNgay.Enabled = false;
            this.dateTuNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTuNgay.Location = new System.Drawing.Point(141, 264);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Size = new System.Drawing.Size(185, 30);
            this.dateTuNgay.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 66;
            this.label8.Text = "Từ ngày:";
            // 
            // chkKhoangTG
            // 
            this.chkKhoangTG.AutoSize = true;
            this.chkKhoangTG.Location = new System.Drawing.Point(23, 239);
            this.chkKhoangTG.Name = "chkKhoangTG";
            this.chkKhoangTG.Size = new System.Drawing.Size(162, 20);
            this.chkKhoangTG.TabIndex = 65;
            this.chkKhoangTG.Text = "Theo khoảng thời gian";
            this.chkKhoangTG.UseVisualStyleBackColor = true;
            // 
            // cboKhoa
            // 
            this.cboKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.Enabled = false;
            this.cboKhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(139, 203);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(187, 31);
            this.cboKhoa.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 63;
            this.label9.Text = "Khóa học:";
            // 
            // chkKhoa
            // 
            this.chkKhoa.AutoSize = true;
            this.chkKhoa.Location = new System.Drawing.Point(23, 180);
            this.chkKhoa.Name = "chkKhoa";
            this.chkKhoa.Size = new System.Drawing.Size(94, 20);
            this.chkKhoa.TabIndex = 62;
            this.chkKhoa.Text = "Theo khóa";
            this.chkKhoa.UseVisualStyleBackColor = true;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenLop.Enabled = false;
            this.txtTenLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenLop.Location = new System.Drawing.Point(139, 140);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(187, 30);
            this.txtTenLop.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tên lớp:";
            // 
            // chkTenLop
            // 
            this.chkTenLop.AutoSize = true;
            this.chkTenLop.Location = new System.Drawing.Point(23, 115);
            this.chkTenLop.Name = "chkTenLop";
            this.chkTenLop.Size = new System.Drawing.Size(104, 20);
            this.chkTenLop.TabIndex = 49;
            this.chkTenLop.Text = "Theo tên lớp";
            this.chkTenLop.UseVisualStyleBackColor = true;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaLop.Location = new System.Drawing.Point(139, 77);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(187, 30);
            this.txtMaLop.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mã lớp:";
            // 
            // chkMaLop
            // 
            this.chkMaLop.AutoSize = true;
            this.chkMaLop.Location = new System.Drawing.Point(23, 52);
            this.chkMaLop.Name = "chkMaLop";
            this.chkMaLop.Size = new System.Drawing.Size(105, 20);
            this.chkMaLop.TabIndex = 46;
            this.chkMaLop.Text = "Theo mã lớp";
            this.chkMaLop.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(17, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 28);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tìm kiếm lớp học";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblSiSo);
            this.panel4.Controls.Add(this.lblNgayKetThuc);
            this.panel4.Controls.Add(this.lblNgayBatDau);
            this.panel4.Controls.Add(this.lblKhoa);
            this.panel4.Controls.Add(this.lblMaLop);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.lblTenLop);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 423);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(852, 210);
            this.panel4.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::QuanLyHocVien.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(1161, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 19);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // QuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 657);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyLopHoc";
            this.Text = "QuanLyLopHoc";
            ((System.ComponentModel.ISupportInitialize)(this.gridLop)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgayKT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmDangMo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSiSo;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.Label lblSiSo;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.DataGridView gridLop;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton rdDong;
        private System.Windows.Forms.RadioButton rdMo;
        private System.Windows.Forms.CheckBox chkTinhTrang;
        private System.Windows.Forms.DateTimePicker dateDenNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTuNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkKhoangTG;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkKhoa;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnDatLai;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnXoaHV;
        private Guna.UI2.WinForms.Guna2Button bntSuaHV;
        private Guna.UI2.WinForms.Guna2Button btnThemLopHoc;
        private Guna.UI2.WinForms.Guna2Button btnHienTatCa;
    }
}