﻿namespace ServiceLearning
{
    partial class frmAddHoatDong
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.gbGeneralInfo = new System.Windows.Forms.GroupBox();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.txtTenHD = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSinhVien = new System.Windows.Forms.GroupBox();
            this.txtSVNotes = new System.Windows.Forms.TextBox();
            this.btnSVDel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSVEdit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSVFind = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSVClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddSV = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.txtSVHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbSVList = new System.Windows.Forms.GroupBox();
            this.dgvSinhVien = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes_SV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DB_Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DB_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcelSV = new System.Windows.Forms.Button();
            this.btnShowSV = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.gbGVList = new System.Windows.Forms.GroupBox();
            this.dgv_GV = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.gbHD_GV = new System.Windows.Forms.GroupBox();
            this.btnDelGV = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEditGV = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnFindGV = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClearGV = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAddGV = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbGV_Khoa = new System.Windows.Forms.ComboBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtDonvi = new System.Windows.Forms.TextBox();
            this.txtGVHoTenLot = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDonvi = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAddHD = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV_DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVKHoa_DB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGVShow = new System.Windows.Forms.Button();
            this.btnGVExcel = new System.Windows.Forms.Button();
            this.gbGeneralInfo.SuspendLayout();
            this.gbSinhVien.SuspendLayout();
            this.gbSVList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbGVList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GV)).BeginInit();
            this.gbHD_GV.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Tomato;
            this.lblHeader.Location = new System.Drawing.Point(463, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(310, 42);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Thêm Hoạt động";
            // 
            // gbGeneralInfo
            // 
            this.gbGeneralInfo.Controls.Add(this.dtpNgayKT);
            this.gbGeneralInfo.Controls.Add(this.dtpNgayBD);
            this.gbGeneralInfo.Controls.Add(this.cbLoai);
            this.gbGeneralInfo.Controls.Add(this.txtTenHD);
            this.gbGeneralInfo.Controls.Add(this.txtMaHD);
            this.gbGeneralInfo.Controls.Add(this.label3);
            this.gbGeneralInfo.Controls.Add(this.label5);
            this.gbGeneralInfo.Controls.Add(this.label4);
            this.gbGeneralInfo.Controls.Add(this.label2);
            this.gbGeneralInfo.Controls.Add(this.label1);
            this.gbGeneralInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbGeneralInfo.Location = new System.Drawing.Point(17, 15);
            this.gbGeneralInfo.Name = "gbGeneralInfo";
            this.gbGeneralInfo.Size = new System.Drawing.Size(1162, 246);
            this.gbGeneralInfo.TabIndex = 1;
            this.gbGeneralInfo.TabStop = false;
            this.gbGeneralInfo.Text = "Thông tin cơ bản";
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(685, 185);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(183, 29);
            this.dtpNgayKT.TabIndex = 3;
            this.dtpNgayKT.ValueChanged += new System.EventHandler(this.dtpNgayKT_ValueChanged);
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(191, 185);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(183, 29);
            this.dtpNgayBD.TabIndex = 3;
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Items.AddRange(new object[] {
            "Sự kiện",
            "Dự án",
            "Môn học"});
            this.cbLoai.Location = new System.Drawing.Point(673, 61);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(335, 32);
            this.cbLoai.TabIndex = 2;
            // 
            // txtTenHD
            // 
            this.txtTenHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHD.Location = new System.Drawing.Point(191, 115);
            this.txtTenHD.Name = "txtTenHD";
            this.txtTenHD.Size = new System.Drawing.Size(965, 37);
            this.txtTenHD.TabIndex = 1;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(196, 61);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(368, 29);
            this.txtMaHD.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Hoạt Động";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hoạt Động";
            // 
            // gbSinhVien
            // 
            this.gbSinhVien.Controls.Add(this.txtSVNotes);
            this.gbSinhVien.Controls.Add(this.btnSVDel);
            this.gbSinhVien.Controls.Add(this.btnSVEdit);
            this.gbSinhVien.Controls.Add(this.btnSVFind);
            this.gbSinhVien.Controls.Add(this.btnSVClear);
            this.gbSinhVien.Controls.Add(this.btnAddSV);
            this.gbSinhVien.Controls.Add(this.cbRole);
            this.gbSinhVien.Controls.Add(this.cbKhoa);
            this.gbSinhVien.Controls.Add(this.txtSVHoTen);
            this.gbSinhVien.Controls.Add(this.txtMSSV);
            this.gbSinhVien.Controls.Add(this.label8);
            this.gbSinhVien.Controls.Add(this.label9);
            this.gbSinhVien.Controls.Add(this.label10);
            this.gbSinhVien.Controls.Add(this.label7);
            this.gbSinhVien.Controls.Add(this.label6);
            this.gbSinhVien.Location = new System.Drawing.Point(17, 337);
            this.gbSinhVien.Name = "gbSinhVien";
            this.gbSinhVien.Size = new System.Drawing.Size(1162, 298);
            this.gbSinhVien.TabIndex = 2;
            this.gbSinhVien.TabStop = false;
            this.gbSinhVien.Text = "Sinh viên tham gia hoạt động";
            this.gbSinhVien.VisibleChanged += new System.EventHandler(this.gbSinhVien_VisibleChanged);
            // 
            // txtSVNotes
            // 
            this.txtSVNotes.Location = new System.Drawing.Point(131, 145);
            this.txtSVNotes.Multiline = true;
            this.txtSVNotes.Name = "txtSVNotes";
            this.txtSVNotes.Size = new System.Drawing.Size(904, 92);
            this.txtSVNotes.TabIndex = 5;
            // 
            // btnSVDel
            // 
            this.btnSVDel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSVDel.Location = new System.Drawing.Point(938, 248);
            this.btnSVDel.Name = "btnSVDel";
            this.btnSVDel.Size = new System.Drawing.Size(133, 44);
            this.btnSVDel.TabIndex = 4;
            this.btnSVDel.Values.Text = "Xóa SV";
            this.btnSVDel.Click += new System.EventHandler(this.btnSVDel_Click);
            // 
            // btnSVEdit
            // 
            this.btnSVEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSVEdit.Location = new System.Drawing.Point(748, 248);
            this.btnSVEdit.Name = "btnSVEdit";
            this.btnSVEdit.Size = new System.Drawing.Size(133, 44);
            this.btnSVEdit.TabIndex = 4;
            this.btnSVEdit.Values.Text = "Sửa SV";
            this.btnSVEdit.Click += new System.EventHandler(this.kryptonBtnEdit_Click);
            // 
            // btnSVFind
            // 
            this.btnSVFind.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSVFind.Location = new System.Drawing.Point(412, 33);
            this.btnSVFind.Name = "btnSVFind";
            this.btnSVFind.Size = new System.Drawing.Size(112, 44);
            this.btnSVFind.TabIndex = 4;
            this.btnSVFind.Values.Text = "Tìm";
            this.btnSVFind.Click += new System.EventHandler(this.btnSVFind_Click);
            // 
            // btnSVClear
            // 
            this.btnSVClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSVClear.Location = new System.Drawing.Point(11, 243);
            this.btnSVClear.Name = "btnSVClear";
            this.btnSVClear.Size = new System.Drawing.Size(133, 44);
            this.btnSVClear.TabIndex = 4;
            this.btnSVClear.Values.Text = "Clear";
            this.btnSVClear.Click += new System.EventHandler(this.btnSVClear_Click);
            // 
            // btnAddSV
            // 
            this.btnAddSV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddSV.Location = new System.Drawing.Point(560, 248);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.Size = new System.Drawing.Size(133, 44);
            this.btnAddSV.TabIndex = 4;
            this.btnAddSV.Values.Text = "Thêm SV";
            this.btnAddSV.Click += new System.EventHandler(this.btnAddSV_Click);
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Tham gia",
            "Tổ chức"});
            this.cbRole.Location = new System.Drawing.Point(855, 85);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(180, 32);
            this.cbRole.TabIndex = 3;
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "Tham gia",
            "Tổ chức"});
            this.cbKhoa.Location = new System.Drawing.Point(688, 35);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(347, 32);
            this.cbKhoa.TabIndex = 2;
            // 
            // txtSVHoTen
            // 
            this.txtSVHoTen.Location = new System.Drawing.Point(131, 89);
            this.txtSVHoTen.Name = "txtSVHoTen";
            this.txtSVHoTen.Size = new System.Drawing.Size(636, 29);
            this.txtSVHoTen.TabIndex = 1;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(131, 39);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(270, 29);
            this.txtMSSV.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(607, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Khoa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(773, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Vai Trò";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Họ và tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "MSSV";
            // 
            // gbSVList
            // 
            this.gbSVList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSVList.Controls.Add(this.dgvSinhVien);
            this.gbSVList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSVList.Location = new System.Drawing.Point(17, 641);
            this.gbSVList.Name = "gbSVList";
            this.gbSVList.Size = new System.Drawing.Size(1154, 292);
            this.gbSVList.TabIndex = 2;
            this.gbSVList.TabStop = false;
            this.gbSVList.Text = "Danh sách SV";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AllowUserToOrderColumns = true;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HoTenSV,
            this.Khoa,
            this.Role,
            this.Notes_SV,
            this.DB_Khoa,
            this.DB_Role});
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.Location = new System.Drawing.Point(3, 25);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersWidth = 72;
            this.dgvSinhVien.RowTemplate.Height = 31;
            this.dgvSinhVien.Size = new System.Drawing.Size(1148, 264);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // MSSV
            // 
            this.MSSV.Frozen = true;
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 9;
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            this.MSSV.Width = 125;
            // 
            // HoTenSV
            // 
            this.HoTenSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HoTenSV.HeaderText = "Họ và Tên";
            this.HoTenSV.MinimumWidth = 9;
            this.HoTenSV.Name = "HoTenSV";
            this.HoTenSV.ReadOnly = true;
            this.HoTenSV.Width = 150;
            // 
            // Khoa
            // 
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MinimumWidth = 9;
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            this.Khoa.Width = 175;
            // 
            // Role
            // 
            this.Role.HeaderText = "Vai trò";
            this.Role.MinimumWidth = 9;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 175;
            // 
            // Notes_SV
            // 
            this.Notes_SV.HeaderText = "Ghi Chú";
            this.Notes_SV.MinimumWidth = 9;
            this.Notes_SV.Name = "Notes_SV";
            this.Notes_SV.ReadOnly = true;
            this.Notes_SV.Width = 325;
            // 
            // DB_Khoa
            // 
            this.DB_Khoa.HeaderText = "DB_Khoa";
            this.DB_Khoa.MinimumWidth = 9;
            this.DB_Khoa.Name = "DB_Khoa";
            this.DB_Khoa.ReadOnly = true;
            this.DB_Khoa.Visible = false;
            this.DB_Khoa.Width = 175;
            // 
            // DB_Role
            // 
            this.DB_Role.HeaderText = "DB_Role";
            this.DB_Role.MinimumWidth = 9;
            this.DB_Role.Name = "DB_Role";
            this.DB_Role.ReadOnly = true;
            this.DB_Role.Visible = false;
            this.DB_Role.Width = 175;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnGVExcel);
            this.panel1.Controls.Add(this.btnExcelSV);
            this.panel1.Controls.Add(this.btnGVShow);
            this.panel1.Controls.Add(this.btnShowSV);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.gbGeneralInfo);
            this.panel1.Controls.Add(this.gbGVList);
            this.panel1.Controls.Add(this.gbSVList);
            this.panel1.Controls.Add(this.gbHD_GV);
            this.panel1.Controls.Add(this.gbSinhVien);
            this.panel1.Location = new System.Drawing.Point(12, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 638);
            this.panel1.TabIndex = 3;
            // 
            // btnExcelSV
            // 
            this.btnExcelSV.Location = new System.Drawing.Point(328, 266);
            this.btnExcelSV.Name = "btnExcelSV";
            this.btnExcelSV.Size = new System.Drawing.Size(142, 43);
            this.btnExcelSV.TabIndex = 4;
            this.btnExcelSV.Text = "Import Excel";
            this.btnExcelSV.UseVisualStyleBackColor = true;
            this.btnExcelSV.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowSV
            // 
            this.btnShowSV.Location = new System.Drawing.Point(180, 267);
            this.btnShowSV.Name = "btnShowSV";
            this.btnShowSV.Size = new System.Drawing.Size(142, 43);
            this.btnShowSV.TabIndex = 4;
            this.btnShowSV.Text = "Ẩn";
            this.btnShowSV.UseVisualStyleBackColor = true;
            this.btnShowSV.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Thêm Sinh Viên";
            // 
            // gbGVList
            // 
            this.gbGVList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGVList.Controls.Add(this.dgv_GV);
            this.gbGVList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGVList.Location = new System.Drawing.Point(17, 1278);
            this.gbGVList.Name = "gbGVList";
            this.gbGVList.Size = new System.Drawing.Size(1154, 361);
            this.gbGVList.TabIndex = 2;
            this.gbGVList.TabStop = false;
            this.gbGVList.Text = "Danh sách GV";
            // 
            // dgv_GV
            // 
            this.dgv_GV.AllowUserToAddRows = false;
            this.dgv_GV.AllowUserToDeleteRows = false;
            this.dgv_GV.AllowUserToOrderColumns = true;
            this.dgv_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.HoTenLot,
            this.Ten,
            this.GVKhoa,
            this.GV_DonVi,
            this.GVKHoa_DB});
            this.dgv_GV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_GV.Location = new System.Drawing.Point(3, 25);
            this.dgv_GV.Name = "dgv_GV";
            this.dgv_GV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.dgv_GV.ReadOnly = true;
            this.dgv_GV.RowHeadersWidth = 72;
            this.dgv_GV.RowTemplate.Height = 31;
            this.dgv_GV.Size = new System.Drawing.Size(1148, 333);
            this.dgv_GV.TabIndex = 0;
            this.dgv_GV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GV_CellClick);
            // 
            // gbHD_GV
            // 
            this.gbHD_GV.Controls.Add(this.btnDelGV);
            this.gbHD_GV.Controls.Add(this.btnEditGV);
            this.gbHD_GV.Controls.Add(this.btnFindGV);
            this.gbHD_GV.Controls.Add(this.btnClearGV);
            this.gbHD_GV.Controls.Add(this.btnAddGV);
            this.gbHD_GV.Controls.Add(this.cbGV_Khoa);
            this.gbHD_GV.Controls.Add(this.txtTenGV);
            this.gbHD_GV.Controls.Add(this.txtDonvi);
            this.gbHD_GV.Controls.Add(this.txtGVHoTenLot);
            this.gbHD_GV.Controls.Add(this.txtMaGV);
            this.gbHD_GV.Controls.Add(this.label12);
            this.gbHD_GV.Controls.Add(this.label13);
            this.gbHD_GV.Controls.Add(this.lblDonvi);
            this.gbHD_GV.Controls.Add(this.label15);
            this.gbHD_GV.Controls.Add(this.label16);
            this.gbHD_GV.Location = new System.Drawing.Point(17, 1016);
            this.gbHD_GV.Name = "gbHD_GV";
            this.gbHD_GV.Size = new System.Drawing.Size(1162, 252);
            this.gbHD_GV.TabIndex = 2;
            this.gbHD_GV.TabStop = false;
            this.gbHD_GV.Text = "Thêm giảng viên tham gia hoạt động";
            this.gbHD_GV.VisibleChanged += new System.EventHandler(this.gbSinhVien_VisibleChanged);
            // 
            // btnDelGV
            // 
            this.btnDelGV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelGV.Location = new System.Drawing.Point(938, 202);
            this.btnDelGV.Name = "btnDelGV";
            this.btnDelGV.Size = new System.Drawing.Size(133, 44);
            this.btnDelGV.TabIndex = 4;
            this.btnDelGV.Values.Text = "Xóa GV";
            this.btnDelGV.Click += new System.EventHandler(this.btnDelGV_Click);
            // 
            // btnEditGV
            // 
            this.btnEditGV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditGV.Location = new System.Drawing.Point(748, 202);
            this.btnEditGV.Name = "btnEditGV";
            this.btnEditGV.Size = new System.Drawing.Size(133, 44);
            this.btnEditGV.TabIndex = 4;
            this.btnEditGV.Values.Text = "Sửa GV";
            this.btnEditGV.Click += new System.EventHandler(this.btnEditGV_Click);
            // 
            // btnFindGV
            // 
            this.btnFindGV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFindGV.Location = new System.Drawing.Point(412, 30);
            this.btnFindGV.Name = "btnFindGV";
            this.btnFindGV.Size = new System.Drawing.Size(112, 44);
            this.btnFindGV.TabIndex = 4;
            this.btnFindGV.Values.Text = "Tìm";
            this.btnFindGV.Click += new System.EventHandler(this.btnSVFind_Click);
            // 
            // btnClearGV
            // 
            this.btnClearGV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClearGV.Location = new System.Drawing.Point(11, 197);
            this.btnClearGV.Name = "btnClearGV";
            this.btnClearGV.Size = new System.Drawing.Size(133, 44);
            this.btnClearGV.TabIndex = 4;
            this.btnClearGV.Values.Text = "Clear";
            this.btnClearGV.Click += new System.EventHandler(this.btnClearGV_Click);
            // 
            // btnAddGV
            // 
            this.btnAddGV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddGV.Location = new System.Drawing.Point(560, 202);
            this.btnAddGV.Name = "btnAddGV";
            this.btnAddGV.Size = new System.Drawing.Size(133, 44);
            this.btnAddGV.TabIndex = 4;
            this.btnAddGV.Values.Text = "Thêm GV";
            this.btnAddGV.Click += new System.EventHandler(this.btnAddGV_Click);
            // 
            // cbGV_Khoa
            // 
            this.cbGV_Khoa.FormattingEnabled = true;
            this.cbGV_Khoa.Items.AddRange(new object[] {
            "Tham gia",
            "Tổ chức"});
            this.cbGV_Khoa.Location = new System.Drawing.Point(688, 35);
            this.cbGV_Khoa.Name = "cbGV_Khoa";
            this.cbGV_Khoa.Size = new System.Drawing.Size(347, 32);
            this.cbGV_Khoa.TabIndex = 2;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(688, 92);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(347, 29);
            this.txtTenGV.TabIndex = 1;
            // 
            // txtDonvi
            // 
            this.txtDonvi.Location = new System.Drawing.Point(142, 141);
            this.txtDonvi.Name = "txtDonvi";
            this.txtDonvi.Size = new System.Drawing.Size(435, 29);
            this.txtDonvi.TabIndex = 1;
            // 
            // txtGVHoTenLot
            // 
            this.txtGVHoTenLot.Location = new System.Drawing.Point(142, 89);
            this.txtGVHoTenLot.Name = "txtGVHoTenLot";
            this.txtGVHoTenLot.Size = new System.Drawing.Size(435, 29);
            this.txtGVHoTenLot.TabIndex = 1;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(142, 39);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(259, 29);
            this.txtMaGV.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(607, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Khoa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(607, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên";
            // 
            // lblDonvi
            // 
            this.lblDonvi.AutoSize = true;
            this.lblDonvi.Location = new System.Drawing.Point(16, 144);
            this.lblDonvi.Name = "lblDonvi";
            this.lblDonvi.Size = new System.Drawing.Size(67, 25);
            this.lblDonvi.TabIndex = 0;
            this.lblDonvi.Text = "Đơn vị";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "Họ và tên lót";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "Mã GV";
            // 
            // btnAddHD
            // 
            this.btnAddHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddHD.Location = new System.Drawing.Point(376, 14);
            this.btnAddHD.Name = "btnAddHD";
            this.btnAddHD.Size = new System.Drawing.Size(203, 54);
            this.btnAddHD.TabIndex = 4;
            this.btnAddHD.Values.Text = "Thêm Hoạt Động";
            this.btnAddHD.Click += new System.EventHandler(this.btnAddHD_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1063, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 54);
            this.btnExit.TabIndex = 4;
            this.btnExit.Values.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddHD);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 844);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1244, 80);
            this.panel2.TabIndex = 5;
            // 
            // MaGV
            // 
            this.MaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaGV.Frozen = true;
            this.MaGV.HeaderText = "Mã Giảng Viên";
            this.MaGV.MinimumWidth = 9;
            this.MaGV.Name = "MaGV";
            this.MaGV.ReadOnly = true;
            this.MaGV.Width = 195;
            // 
            // HoTenLot
            // 
            this.HoTenLot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HoTenLot.HeaderText = "Họ và Tên Lót";
            this.HoTenLot.MinimumWidth = 9;
            this.HoTenLot.Name = "HoTenLot";
            this.HoTenLot.ReadOnly = true;
            this.HoTenLot.Width = 185;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 9;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 90;
            // 
            // GVKhoa
            // 
            this.GVKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GVKhoa.HeaderText = "Khoa";
            this.GVKhoa.MinimumWidth = 9;
            this.GVKhoa.Name = "GVKhoa";
            this.GVKhoa.ReadOnly = true;
            this.GVKhoa.Width = 105;
            // 
            // GV_DonVi
            // 
            this.GV_DonVi.HeaderText = "Đơn vị";
            this.GV_DonVi.MinimumWidth = 9;
            this.GV_DonVi.Name = "GV_DonVi";
            this.GV_DonVi.ReadOnly = true;
            this.GV_DonVi.Width = 175;
            // 
            // GVKHoa_DB
            // 
            this.GVKHoa_DB.HeaderText = "GVKHoa_DB";
            this.GVKHoa_DB.MinimumWidth = 9;
            this.GVKHoa_DB.Name = "GVKHoa_DB";
            this.GVKHoa_DB.ReadOnly = true;
            this.GVKHoa_DB.Visible = false;
            this.GVKHoa_DB.Width = 175;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 970);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 25);
            this.label14.TabIndex = 3;
            this.label14.Text = "Giảng viên";
            // 
            // btnGVShow
            // 
            this.btnGVShow.Location = new System.Drawing.Point(184, 962);
            this.btnGVShow.Name = "btnGVShow";
            this.btnGVShow.Size = new System.Drawing.Size(142, 43);
            this.btnGVShow.TabIndex = 4;
            this.btnGVShow.Text = "Ẩn";
            this.btnGVShow.UseVisualStyleBackColor = true;
            this.btnGVShow.Click += new System.EventHandler(this.btnGVShow_Click);
            // 
            // btnGVExcel
            // 
            this.btnGVExcel.Location = new System.Drawing.Point(332, 961);
            this.btnGVExcel.Name = "btnGVExcel";
            this.btnGVExcel.Size = new System.Drawing.Size(142, 43);
            this.btnGVExcel.TabIndex = 4;
            this.btnGVExcel.Text = "Import Excel";
            this.btnGVExcel.UseVisualStyleBackColor = true;
            this.btnGVExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 924);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmAddHoatDong";
            this.Text = "frmAddHoatDong";
            this.Load += new System.EventHandler(this.frmAddHoatDong_Load);
            this.gbGeneralInfo.ResumeLayout(false);
            this.gbGeneralInfo.PerformLayout();
            this.gbSinhVien.ResumeLayout(false);
            this.gbSinhVien.PerformLayout();
            this.gbSVList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbGVList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GV)).EndInit();
            this.gbHD_GV.ResumeLayout(false);
            this.gbHD_GV.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox gbGeneralInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.TextBox txtTenHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.GroupBox gbSinhVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbSVList;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.TextBox txtSVHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSVDel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSVEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddSV;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvSinhVien;
        private System.Windows.Forms.TextBox txtSVNotes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnShowSV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExcelSV;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSVClear;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddHD;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSVFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes_SV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DB_Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DB_Role;
        private System.Windows.Forms.GroupBox gbHD_GV;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelGV;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEditGV;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFindGV;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClearGV;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddGV;
        private System.Windows.Forms.ComboBox cbGV_Khoa;
        private System.Windows.Forms.TextBox txtGVHoTenLot;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.GroupBox gbGVList;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_GV;
        private System.Windows.Forms.TextBox txtDonvi;
        private System.Windows.Forms.Label lblDonvi;
        private System.Windows.Forms.Button btnGVExcel;
        private System.Windows.Forms.Button btnGVShow;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV_DonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVKHoa_DB;
    }
}