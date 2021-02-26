namespace PhanMemQLTV
{
    partial class frmQLDocGia
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
            this.components = new System.ComponentModel.Container();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSDocGia = new System.Windows.Forms.DataGridView();
            this.colMaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChiDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLoaiDG = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNhapGioiTinh = new System.Windows.Forms.Label();
            this.lblNhapDiaChi = new System.Windows.Forms.Label();
            this.lblNhapSDT = new System.Windows.Forms.Label();
            this.lblNhapNgaySinh = new System.Windows.Forms.Label();
            this.lblNhapTenDG = new System.Windows.Forms.Label();
            this.dtmNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNDTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radTenDG = new System.Windows.Forms.RadioButton();
            this.radMaDG = new System.Windows.Forms.RadioButton();
            this.btnLoadDS = new System.Windows.Forms.Button();
            this.errTenDG = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTenTK = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMK = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDC = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errGT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errLoaiDG = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDocGia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errTenDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoaiDG)).BeginInit();
            this.SuspendLayout();
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(465, 29);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(165, 27);
            this.cboGioiTinh.TabIndex = 3;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(465, 88);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(165, 27);
            this.txtSoDT.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số Điện Thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa Chỉ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới Tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Sinh :";
            // 
            // txtTenDG
            // 
            this.txtTenDG.Location = new System.Drawing.Point(134, 57);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(169, 27);
            this.txtTenDG.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Độc Giả :";
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(134, 28);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(169, 27);
            this.txtMaDG.TabIndex = 0;
            this.txtMaDG.TextChanged += new System.EventHandler(this.txtMaDG_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Độc Giả :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewDSDocGia);
            this.groupBox2.Location = new System.Drawing.Point(14, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 212);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Độc Giả";
            // 
            // dataGridViewDSDocGia
            // 
            this.dataGridViewDSDocGia.AllowUserToAddRows = false;
            this.dataGridViewDSDocGia.AllowUserToDeleteRows = false;
            this.dataGridViewDSDocGia.AllowUserToResizeRows = false;
            this.dataGridViewDSDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDG,
            this.colTenDG,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colSDT,
            this.colLoaiDG,
            this.colTenTK,
            this.colMK,
            this.colDiaChiDG,
            this.colGhiChu});
            this.dataGridViewDSDocGia.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewDSDocGia.Name = "dataGridViewDSDocGia";
            this.dataGridViewDSDocGia.ReadOnly = true;
            this.dataGridViewDSDocGia.RowHeadersWidth = 51;
            this.dataGridViewDSDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDSDocGia.Size = new System.Drawing.Size(747, 184);
            this.dataGridViewDSDocGia.TabIndex = 2;
            this.dataGridViewDSDocGia.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSDocGia_RowEnter);
            // 
            // colMaDG
            // 
            this.colMaDG.DataPropertyName = "MaDG";
            this.colMaDG.HeaderText = "Mã ĐG";
            this.colMaDG.MinimumWidth = 6;
            this.colMaDG.Name = "colMaDG";
            this.colMaDG.ReadOnly = true;
            this.colMaDG.Width = 55;
            // 
            // colTenDG
            // 
            this.colTenDG.DataPropertyName = "TenDG";
            this.colTenDG.HeaderText = "Tên ĐG";
            this.colTenDG.MinimumWidth = 6;
            this.colTenDG.Name = "colTenDG";
            this.colTenDG.ReadOnly = true;
            this.colTenDG.Width = 115;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinhDG";
            this.colGioiTinh.HeaderText = "Giới Tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.ReadOnly = true;
            this.colGioiTinh.Width = 45;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinhDG";
            this.colNgaySinh.HeaderText = "Ngày Sinh";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.ReadOnly = true;
            this.colNgaySinh.Width = 80;
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SDTDG";
            this.colSDT.HeaderText = "Số ĐT";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            this.colSDT.ReadOnly = true;
            this.colSDT.Width = 85;
            // 
            // colLoaiDG
            // 
            this.colLoaiDG.DataPropertyName = "LoaiDG";
            this.colLoaiDG.HeaderText = "Loại ĐG";
            this.colLoaiDG.MinimumWidth = 6;
            this.colLoaiDG.Name = "colLoaiDG";
            this.colLoaiDG.ReadOnly = true;
            this.colLoaiDG.Width = 75;
            // 
            // colTenTK
            // 
            this.colTenTK.DataPropertyName = "TenTaiKhoanDG";
            this.colTenTK.HeaderText = "Tên TK";
            this.colTenTK.MinimumWidth = 6;
            this.colTenTK.Name = "colTenTK";
            this.colTenTK.ReadOnly = true;
            this.colTenTK.Width = 50;
            // 
            // colMK
            // 
            this.colMK.DataPropertyName = "MatKhauDG";
            this.colMK.HeaderText = "Mật Khẩu";
            this.colMK.MinimumWidth = 6;
            this.colMK.Name = "colMK";
            this.colMK.ReadOnly = true;
            this.colMK.Width = 50;
            // 
            // colDiaChiDG
            // 
            this.colDiaChiDG.DataPropertyName = "DiaChiDG";
            this.colDiaChiDG.HeaderText = "Địa Chỉ";
            this.colDiaChiDG.MinimumWidth = 6;
            this.colDiaChiDG.Name = "colDiaChiDG";
            this.colDiaChiDG.ReadOnly = true;
            this.colDiaChiDG.Width = 134;
            // 
            // colGhiChu
            // 
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi Chú";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            this.colGhiChu.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLoaiDG);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTenTK);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblNhapGioiTinh);
            this.groupBox1.Controls.Add(this.lblNhapDiaChi);
            this.groupBox1.Controls.Add(this.lblNhapSDT);
            this.groupBox1.Controls.Add(this.lblNhapNgaySinh);
            this.groupBox1.Controls.Add(this.lblNhapTenDG);
            this.groupBox1.Controls.Add(this.dtmNgaySinh);
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSoDT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenDG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaDG);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(63, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Độc Giả";
            // 
            // cboLoaiDG
            // 
            this.cboLoaiDG.FormattingEnabled = true;
            this.cboLoaiDG.Items.AddRange(new object[] {
            "Sinh viên",
            "Giáo viên",
            "Khách"});
            this.cboLoaiDG.Location = new System.Drawing.Point(465, 116);
            this.cboLoaiDG.Name = "cboLoaiDG";
            this.cboLoaiDG.Size = new System.Drawing.Size(164, 27);
            this.cboLoaiDG.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Loại ĐG:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(465, 148);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(165, 27);
            this.txtGhiChu.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ghi Chú:";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Enabled = false;
            this.txtTenTK.Location = new System.Drawing.Point(134, 115);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(169, 27);
            this.txtTenTK.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tên TK:";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(134, 144);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(169, 27);
            this.txtMK.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mật Khẩu:";
            // 
            // lblNhapGioiTinh
            // 
            this.lblNhapGioiTinh.AutoSize = true;
            this.lblNhapGioiTinh.Location = new System.Drawing.Point(449, 50);
            this.lblNhapGioiTinh.Name = "lblNhapGioiTinh";
            this.lblNhapGioiTinh.Size = new System.Drawing.Size(0, 19);
            this.lblNhapGioiTinh.TabIndex = 6;
            // 
            // lblNhapDiaChi
            // 
            this.lblNhapDiaChi.AutoSize = true;
            this.lblNhapDiaChi.Location = new System.Drawing.Point(449, 89);
            this.lblNhapDiaChi.Name = "lblNhapDiaChi";
            this.lblNhapDiaChi.Size = new System.Drawing.Size(0, 19);
            this.lblNhapDiaChi.TabIndex = 6;
            // 
            // lblNhapSDT
            // 
            this.lblNhapSDT.AutoSize = true;
            this.lblNhapSDT.Location = new System.Drawing.Point(449, 128);
            this.lblNhapSDT.Name = "lblNhapSDT";
            this.lblNhapSDT.Size = new System.Drawing.Size(0, 19);
            this.lblNhapSDT.TabIndex = 6;
            // 
            // lblNhapNgaySinh
            // 
            this.lblNhapNgaySinh.AutoSize = true;
            this.lblNhapNgaySinh.Location = new System.Drawing.Point(114, 92);
            this.lblNhapNgaySinh.Name = "lblNhapNgaySinh";
            this.lblNhapNgaySinh.Size = new System.Drawing.Size(0, 19);
            this.lblNhapNgaySinh.TabIndex = 6;
            // 
            // lblNhapTenDG
            // 
            this.lblNhapTenDG.AutoSize = true;
            this.lblNhapTenDG.Location = new System.Drawing.Point(114, 64);
            this.lblNhapTenDG.Name = "lblNhapTenDG";
            this.lblNhapTenDG.Size = new System.Drawing.Size(0, 19);
            this.lblNhapTenDG.TabIndex = 6;
            // 
            // dtmNgaySinh
            // 
            this.dtmNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtmNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgaySinh.Location = new System.Drawing.Point(134, 86);
            this.dtmNgaySinh.Name = "dtmNgaySinh";
            this.dtmNgaySinh.Size = new System.Drawing.Size(169, 27);
            this.dtmNgaySinh.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(465, 58);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(165, 27);
            this.txtDiaChi.TabIndex = 4;
            // 
            // btnLuu
            // 
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(440, 350);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(66, 27);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(373, 350);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 27);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(299, 350);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 27);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(309, 115);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(77, 33);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Trang Chủ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(512, 350);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(69, 27);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(229, 350);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 27);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(63, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 97);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm Độc Giả";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNDTimKiem);
            this.groupBox5.Location = new System.Drawing.Point(270, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(360, 60);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nhập thông tin cần Tìm Kiếm";
            // 
            // txtNDTimKiem
            // 
            this.txtNDTimKiem.Location = new System.Drawing.Point(11, 24);
            this.txtNDTimKiem.Name = "txtNDTimKiem";
            this.txtNDTimKiem.Size = new System.Drawing.Size(332, 27);
            this.txtNDTimKiem.TabIndex = 0;
            this.txtNDTimKiem.TextChanged += new System.EventHandler(this.txtNDTimKiem_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radTenDG);
            this.groupBox4.Controls.Add(this.radMaDG);
            this.groupBox4.Location = new System.Drawing.Point(30, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 60);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm Theo";
            // 
            // radTenDG
            // 
            this.radTenDG.AutoSize = true;
            this.radTenDG.Location = new System.Drawing.Point(104, 24);
            this.radTenDG.Name = "radTenDG";
            this.radTenDG.Size = new System.Drawing.Size(83, 23);
            this.radTenDG.TabIndex = 1;
            this.radTenDG.TabStop = true;
            this.radTenDG.Text = "Tên ĐG";
            this.radTenDG.UseVisualStyleBackColor = true;
            // 
            // radMaDG
            // 
            this.radMaDG.AutoSize = true;
            this.radMaDG.Location = new System.Drawing.Point(18, 24);
            this.radMaDG.Name = "radMaDG";
            this.radMaDG.Size = new System.Drawing.Size(80, 23);
            this.radMaDG.TabIndex = 0;
            this.radMaDG.TabStop = true;
            this.radMaDG.Text = "Mã ĐG";
            this.radMaDG.UseVisualStyleBackColor = true;
            // 
            // btnLoadDS
            // 
            this.btnLoadDS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadDS.Location = new System.Drawing.Point(392, 116);
            this.btnLoadDS.Name = "btnLoadDS";
            this.btnLoadDS.Size = new System.Drawing.Size(83, 32);
            this.btnLoadDS.TabIndex = 1;
            this.btnLoadDS.Text = "Làm mới";
            this.btnLoadDS.UseVisualStyleBackColor = true;
            this.btnLoadDS.Click += new System.EventHandler(this.btnLoadDS_Click);
            // 
            // errTenDG
            // 
            this.errTenDG.ContainerControl = this;
            // 
            // errTenTK
            // 
            this.errTenTK.ContainerControl = this;
            // 
            // errMK
            // 
            this.errMK.ContainerControl = this;
            // 
            // errDC
            // 
            this.errDC.ContainerControl = this;
            // 
            // errSDT
            // 
            this.errSDT.ContainerControl = this;
            // 
            // errGT
            // 
            this.errGT.ContainerControl = this;
            // 
            // errLoaiDG
            // 
            this.errLoaiDG.ContainerControl = this;
            // 
            // frmQLDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(785, 607);
            this.Controls.Add(this.btnLoadDS);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmQLDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmQLDocGia_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDocGia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errTenDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLoaiDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewDSDocGia;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtmNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNDTimKiem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radTenDG;
        private System.Windows.Forms.RadioButton radMaDG;
        private System.Windows.Forms.Button btnLoadDS;
        private System.Windows.Forms.Label lblNhapGioiTinh;
        private System.Windows.Forms.Label lblNhapDiaChi;
        private System.Windows.Forms.Label lblNhapSDT;
        private System.Windows.Forms.Label lblNhapNgaySinh;
        private System.Windows.Forms.Label lblNhapTenDG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboLoaiDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChiDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.ErrorProvider errTenDG;
        private System.Windows.Forms.ErrorProvider errTenTK;
        private System.Windows.Forms.ErrorProvider errMK;
        private System.Windows.Forms.ErrorProvider errDC;
        private System.Windows.Forms.ErrorProvider errSDT;
        private System.Windows.Forms.ErrorProvider errGT;
        private System.Windows.Forms.ErrorProvider errLoaiDG;
    }
}