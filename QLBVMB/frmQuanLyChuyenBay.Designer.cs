namespace Plane_Ticket
{
    partial class frmQuanLyChuyenBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyChuyenBay));
            this.txtThoiGianBay = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cboMaTuyenBay = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtMaChuyenBay = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cboMaMayBay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaHangVe = new System.Windows.Forms.ComboBox();
            this.txtTongSoGhe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxThaoTac = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbxDSChuyenBay = new System.Windows.Forms.GroupBox();
            this.dtgvChuyenBay = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.gbxTTChuyenBay = new System.Windows.Forms.GroupBox();
            this.dtpkThoiGianKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSanBayDen = new System.Windows.Forms.ComboBox();
            this.cboSanBayDi = new System.Windows.Forms.ComboBox();
            this.gbxThemHangVeChoChuyenBay = new System.Windows.Forms.GroupBox();
            this.btnThemHV = new System.Windows.Forms.Button();
            this.dtgvHangVe = new System.Windows.Forms.DataGridView();
            this.btnSuaHV = new System.Windows.Forms.Button();
            this.btnXoaHV = new System.Windows.Forms.Button();
            this.gbxThemSanBayTGChoChuyenBay = new System.Windows.Forms.GroupBox();
            this.btnThemSBTG = new System.Windows.Forms.Button();
            this.cboTenSanBayTG = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtThoiGianNghi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSuaSBTG = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dtgvSanBayTG = new System.Windows.Forms.DataGridView();
            this.btnXoaSBTG = new System.Windows.Forms.Button();
            this.gbxThaoTac.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxDSChuyenBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenBay)).BeginInit();
            this.gbxTTChuyenBay.SuspendLayout();
            this.gbxThemHangVeChoChuyenBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangVe)).BeginInit();
            this.gbxThemSanBayTGChoChuyenBay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanBayTG)).BeginInit();
            this.SuspendLayout();
            // 
            // txtThoiGianBay
            // 
            this.txtThoiGianBay.Location = new System.Drawing.Point(116, 216);
            this.txtThoiGianBay.Name = "txtThoiGianBay";
            this.txtThoiGianBay.Size = new System.Drawing.Size(132, 23);
            this.txtThoiGianBay.TabIndex = 29;
            this.txtThoiGianBay.CursorChanged += new System.EventHandler(this.gbxTTChuyenBay_CursorChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 219);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(91, 17);
            this.label26.TabIndex = 28;
            this.label26.Text = "Thời gian bay";
            this.label26.CursorChanged += new System.EventHandler(this.gbxTTChuyenBay_CursorChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 55);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(91, 17);
            this.label27.TabIndex = 26;
            this.label27.Text = "Mã tuyến bay";
            this.label27.CursorChanged += new System.EventHandler(this.gbxTTChuyenBay_CursorChanged);
            // 
            // cboMaTuyenBay
            // 
            this.cboMaTuyenBay.FormattingEnabled = true;
            this.cboMaTuyenBay.Location = new System.Drawing.Point(116, 50);
            this.cboMaTuyenBay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaTuyenBay.Name = "cboMaTuyenBay";
            this.cboMaTuyenBay.Size = new System.Drawing.Size(164, 25);
            this.cboMaTuyenBay.TabIndex = 36;
            this.cboMaTuyenBay.SelectionChangeCommitted += new System.EventHandler(this.cboMaTuyenBay_SelectionChangeCommitted);
            this.cboMaTuyenBay.CursorChanged += new System.EventHandler(this.gbxTTChuyenBay_CursorChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(7, 183);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 13);
            this.label25.TabIndex = 31;
            this.label25.Text = "Thời gian khởi hành";
            this.label25.CursorChanged += new System.EventHandler(this.gbxTTChuyenBay_CursorChanged);
            // 
            // txtMaChuyenBay
            // 
            this.txtMaChuyenBay.Location = new System.Drawing.Point(116, 20);
            this.txtMaChuyenBay.Name = "txtMaChuyenBay";
            this.txtMaChuyenBay.ReadOnly = true;
            this.txtMaChuyenBay.Size = new System.Drawing.Size(164, 23);
            this.txtMaChuyenBay.TabIndex = 33;
            this.txtMaChuyenBay.CursorChanged += new System.EventHandler(this.gbxTTChuyenBay_CursorChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 151);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(82, 17);
            this.label24.TabIndex = 30;
            this.label24.Text = "Mã máy bay";
            this.label24.CursorChanged += new System.EventHandler(this.gbxTTChuyenBay_CursorChanged);
            // 
            // cboMaMayBay
            // 
            this.cboMaMayBay.FormattingEnabled = true;
            this.cboMaMayBay.Location = new System.Drawing.Point(117, 146);
            this.cboMaMayBay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaMayBay.Name = "cboMaMayBay";
            this.cboMaMayBay.Size = new System.Drawing.Size(164, 25);
            this.cboMaMayBay.TabIndex = 36;
            this.cboMaMayBay.CursorChanged += new System.EventHandler(this.gbxTTChuyenBay_CursorChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã chuyến bay";
            this.label2.CursorChanged += new System.EventHandler(this.gbxTTChuyenBay_CursorChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Hạng vé";
            this.label3.Click += new System.EventHandler(this.gbxThemHangVeChoChuyenBay_CursorChanged);
            // 
            // cboMaHangVe
            // 
            this.cboMaHangVe.FormattingEnabled = true;
            this.cboMaHangVe.Location = new System.Drawing.Point(116, 17);
            this.cboMaHangVe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaHangVe.Name = "cboMaHangVe";
            this.cboMaHangVe.Size = new System.Drawing.Size(194, 25);
            this.cboMaHangVe.TabIndex = 36;
            this.cboMaHangVe.Click += new System.EventHandler(this.gbxThemHangVeChoChuyenBay_CursorChanged);
            // 
            // txtTongSoGhe
            // 
            this.txtTongSoGhe.Location = new System.Drawing.Point(116, 44);
            this.txtTongSoGhe.Name = "txtTongSoGhe";
            this.txtTongSoGhe.Size = new System.Drawing.Size(194, 23);
            this.txtTongSoGhe.TabIndex = 29;
            this.txtTongSoGhe.Click += new System.EventHandler(this.gbxThemHangVeChoChuyenBay_CursorChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Số ghế của hạng vé";
            this.label4.Click += new System.EventHandler(this.gbxThemHangVeChoChuyenBay_CursorChanged);
            // 
            // gbxThaoTac
            // 
            this.gbxThaoTac.Controls.Add(this.btnThem);
            this.gbxThaoTac.Controls.Add(this.label5);
            this.gbxThaoTac.Controls.Add(this.label6);
            this.gbxThaoTac.Controls.Add(this.label7);
            this.gbxThaoTac.Controls.Add(this.btnSua);
            this.gbxThaoTac.Controls.Add(this.btnXoa);
            this.gbxThaoTac.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbxThaoTac.Location = new System.Drawing.Point(9, 316);
            this.gbxThaoTac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxThaoTac.Name = "gbxThaoTac";
            this.gbxThaoTac.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxThaoTac.Size = new System.Drawing.Size(285, 82);
            this.gbxThaoTac.TabIndex = 70;
            this.gbxThaoTac.TabStop = false;
            this.gbxThaoTac.Text = "Thao tác";
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnThem;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(28, 18);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(41, 41);
            this.btnThem.TabIndex = 42;
            this.btnThem.UseCompatibleTextRendering = true;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Xóa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sửa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(125, 18);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(41, 41);
            this.btnSua.TabIndex = 41;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnXoa;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(218, 18);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(41, 41);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 47);
            this.panel1.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(342, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(394, 41);
            this.label8.TabIndex = 39;
            this.label8.Text = "QUẢN LÝ CHUYẾN BAY";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThoat.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnCancel;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1054, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(41, 41);
            this.btnThoat.TabIndex = 40;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gbxDSChuyenBay
            // 
            this.gbxDSChuyenBay.Controls.Add(this.dtgvChuyenBay);
            this.gbxDSChuyenBay.Controls.Add(this.label9);
            this.gbxDSChuyenBay.Controls.Add(this.txtTimKiem);
            this.gbxDSChuyenBay.Controls.Add(this.btnTimKiem);
            this.gbxDSChuyenBay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbxDSChuyenBay.Location = new System.Drawing.Point(18, 403);
            this.gbxDSChuyenBay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxDSChuyenBay.Name = "gbxDSChuyenBay";
            this.gbxDSChuyenBay.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxDSChuyenBay.Size = new System.Drawing.Size(1081, 375);
            this.gbxDSChuyenBay.TabIndex = 68;
            this.gbxDSChuyenBay.TabStop = false;
            this.gbxDSChuyenBay.Text = "Danh sách chuyến bay";
            // 
            // dtgvChuyenBay
            // 
            this.dtgvChuyenBay.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChuyenBay.Location = new System.Drawing.Point(4, 51);
            this.dtgvChuyenBay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvChuyenBay.Name = "dtgvChuyenBay";
            this.dtgvChuyenBay.RowTemplate.Height = 24;
            this.dtgvChuyenBay.Size = new System.Drawing.Size(1073, 318);
            this.dtgvChuyenBay.TabIndex = 47;
            this.dtgvChuyenBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChuyenBay_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(759, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tìm kiếm ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(888, 24);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(125, 23);
            this.txtTimKiem.TabIndex = 17;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnTimKiem;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(1033, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(25, 24);
            this.btnTimKiem.TabIndex = 40;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gbxTTChuyenBay
            // 
            this.gbxTTChuyenBay.Controls.Add(this.dtpkThoiGianKhoiHanh);
            this.gbxTTChuyenBay.Controls.Add(this.txtMaChuyenBay);
            this.gbxTTChuyenBay.Controls.Add(this.cboMaMayBay);
            this.gbxTTChuyenBay.Controls.Add(this.label15);
            this.gbxTTChuyenBay.Controls.Add(this.label14);
            this.gbxTTChuyenBay.Controls.Add(this.label27);
            this.gbxTTChuyenBay.Controls.Add(this.label2);
            this.gbxTTChuyenBay.Controls.Add(this.label1);
            this.gbxTTChuyenBay.Controls.Add(this.cboSanBayDen);
            this.gbxTTChuyenBay.Controls.Add(this.cboSanBayDi);
            this.gbxTTChuyenBay.Controls.Add(this.cboMaTuyenBay);
            this.gbxTTChuyenBay.Controls.Add(this.label26);
            this.gbxTTChuyenBay.Controls.Add(this.label24);
            this.gbxTTChuyenBay.Controls.Add(this.txtThoiGianBay);
            this.gbxTTChuyenBay.Controls.Add(this.label25);
            this.gbxTTChuyenBay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbxTTChuyenBay.Location = new System.Drawing.Point(9, 52);
            this.gbxTTChuyenBay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxTTChuyenBay.Name = "gbxTTChuyenBay";
            this.gbxTTChuyenBay.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxTTChuyenBay.Size = new System.Drawing.Size(285, 259);
            this.gbxTTChuyenBay.TabIndex = 67;
            this.gbxTTChuyenBay.TabStop = false;
            this.gbxTTChuyenBay.Text = "Thông tin chuyến bay";
            this.gbxTTChuyenBay.CursorChanged += new System.EventHandler(this.gbxTTChuyenBay_CursorChanged);
            // 
            // dtpkThoiGianKhoiHanh
            // 
            this.dtpkThoiGianKhoiHanh.CustomFormat = "dd/MM/yyyy - h:mm:ss tt ";
            this.dtpkThoiGianKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkThoiGianKhoiHanh.Location = new System.Drawing.Point(117, 183);
            this.dtpkThoiGianKhoiHanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpkThoiGianKhoiHanh.Name = "dtpkThoiGianKhoiHanh";
            this.dtpkThoiGianKhoiHanh.Size = new System.Drawing.Size(164, 23);
            this.dtpkThoiGianKhoiHanh.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "Sân bay đến";
            this.label15.CursorChanged += new System.EventHandler(this.gbxTTChuyenBay_CursorChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Sân bay đi";
            this.label14.CursorChanged += new System.EventHandler(this.gbxTTChuyenBay_CursorChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "phút";
            this.label1.Click += new System.EventHandler(this.gbxThemHangVeChoChuyenBay_CursorChanged);
            // 
            // cboSanBayDen
            // 
            this.cboSanBayDen.FormattingEnabled = true;
            this.cboSanBayDen.Location = new System.Drawing.Point(116, 113);
            this.cboSanBayDen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSanBayDen.Name = "cboSanBayDen";
            this.cboSanBayDen.Size = new System.Drawing.Size(164, 25);
            this.cboSanBayDen.TabIndex = 36;
            this.cboSanBayDen.SelectionChangeCommitted += new System.EventHandler(this.cboSanBayDi_SelectionChangeCommitted);
            this.cboSanBayDen.CursorChanged += new System.EventHandler(this.gbxTTChuyenBay_CursorChanged);
            // 
            // cboSanBayDi
            // 
            this.cboSanBayDi.FormattingEnabled = true;
            this.cboSanBayDi.Location = new System.Drawing.Point(116, 81);
            this.cboSanBayDi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSanBayDi.Name = "cboSanBayDi";
            this.cboSanBayDi.Size = new System.Drawing.Size(164, 25);
            this.cboSanBayDi.TabIndex = 36;
            this.cboSanBayDi.SelectionChangeCommitted += new System.EventHandler(this.cboSanBayDi_SelectionChangeCommitted);
            this.cboSanBayDi.CursorChanged += new System.EventHandler(this.gbxTTChuyenBay_CursorChanged);
            // 
            // gbxThemHangVeChoChuyenBay
            // 
            this.gbxThemHangVeChoChuyenBay.Controls.Add(this.btnThemHV);
            this.gbxThemHangVeChoChuyenBay.Controls.Add(this.dtgvHangVe);
            this.gbxThemHangVeChoChuyenBay.Controls.Add(this.btnSuaHV);
            this.gbxThemHangVeChoChuyenBay.Controls.Add(this.cboMaHangVe);
            this.gbxThemHangVeChoChuyenBay.Controls.Add(this.btnXoaHV);
            this.gbxThemHangVeChoChuyenBay.Controls.Add(this.txtTongSoGhe);
            this.gbxThemHangVeChoChuyenBay.Controls.Add(this.label4);
            this.gbxThemHangVeChoChuyenBay.Controls.Add(this.label3);
            this.gbxThemHangVeChoChuyenBay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbxThemHangVeChoChuyenBay.Location = new System.Drawing.Point(373, 52);
            this.gbxThemHangVeChoChuyenBay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxThemHangVeChoChuyenBay.Name = "gbxThemHangVeChoChuyenBay";
            this.gbxThemHangVeChoChuyenBay.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxThemHangVeChoChuyenBay.Size = new System.Drawing.Size(341, 341);
            this.gbxThemHangVeChoChuyenBay.TabIndex = 71;
            this.gbxThemHangVeChoChuyenBay.TabStop = false;
            this.gbxThemHangVeChoChuyenBay.Text = "Thêm hạng vé cho chuyến bay";
            this.gbxThemHangVeChoChuyenBay.CursorChanged += new System.EventHandler(this.gbxThemHangVeChoChuyenBay_CursorChanged);
            // 
            // btnThemHV
            // 
            this.btnThemHV.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnThem;
            this.btnThemHV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemHV.FlatAppearance.BorderSize = 0;
            this.btnThemHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHV.Location = new System.Drawing.Point(45, 99);
            this.btnThemHV.Name = "btnThemHV";
            this.btnThemHV.Size = new System.Drawing.Size(33, 32);
            this.btnThemHV.TabIndex = 42;
            this.btnThemHV.UseCompatibleTextRendering = true;
            this.btnThemHV.UseVisualStyleBackColor = true;
            this.btnThemHV.Click += new System.EventHandler(this.btnThemHV_Click);
            // 
            // dtgvHangVe
            // 
            this.dtgvHangVe.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvHangVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHangVe.Location = new System.Drawing.Point(4, 141);
            this.dtgvHangVe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvHangVe.Name = "dtgvHangVe";
            this.dtgvHangVe.RowTemplate.Height = 24;
            this.dtgvHangVe.Size = new System.Drawing.Size(333, 182);
            this.dtgvHangVe.TabIndex = 47;
            this.dtgvHangVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHangVe_CellClick);
            this.dtgvHangVe.Click += new System.EventHandler(this.gbxThemHangVeChoChuyenBay_CursorChanged);
            // 
            // btnSuaHV
            // 
            this.btnSuaHV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaHV.BackgroundImage")));
            this.btnSuaHV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaHV.FlatAppearance.BorderSize = 0;
            this.btnSuaHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaHV.Location = new System.Drawing.Point(142, 99);
            this.btnSuaHV.Name = "btnSuaHV";
            this.btnSuaHV.Size = new System.Drawing.Size(33, 32);
            this.btnSuaHV.TabIndex = 41;
            this.btnSuaHV.UseVisualStyleBackColor = true;
            this.btnSuaHV.Click += new System.EventHandler(this.btnSuaHV_Click);
            // 
            // btnXoaHV
            // 
            this.btnXoaHV.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnXoa;
            this.btnXoaHV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaHV.FlatAppearance.BorderSize = 0;
            this.btnXoaHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHV.Location = new System.Drawing.Point(235, 99);
            this.btnXoaHV.Name = "btnXoaHV";
            this.btnXoaHV.Size = new System.Drawing.Size(33, 32);
            this.btnXoaHV.TabIndex = 41;
            this.btnXoaHV.UseVisualStyleBackColor = true;
            this.btnXoaHV.Click += new System.EventHandler(this.btnXoaHV_Click);
            // 
            // gbxThemSanBayTGChoChuyenBay
            // 
            this.gbxThemSanBayTGChoChuyenBay.Controls.Add(this.btnThemSBTG);
            this.gbxThemSanBayTGChoChuyenBay.Controls.Add(this.cboTenSanBayTG);
            this.gbxThemSanBayTGChoChuyenBay.Controls.Add(this.label11);
            this.gbxThemSanBayTGChoChuyenBay.Controls.Add(this.txtGhiChu);
            this.gbxThemSanBayTGChoChuyenBay.Controls.Add(this.txtThoiGianNghi);
            this.gbxThemSanBayTGChoChuyenBay.Controls.Add(this.label12);
            this.gbxThemSanBayTGChoChuyenBay.Controls.Add(this.btnSuaSBTG);
            this.gbxThemSanBayTGChoChuyenBay.Controls.Add(this.label13);
            this.gbxThemSanBayTGChoChuyenBay.Controls.Add(this.dtgvSanBayTG);
            this.gbxThemSanBayTGChoChuyenBay.Controls.Add(this.btnXoaSBTG);
            this.gbxThemSanBayTGChoChuyenBay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbxThemSanBayTGChoChuyenBay.Location = new System.Drawing.Point(764, 52);
            this.gbxThemSanBayTGChoChuyenBay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxThemSanBayTGChoChuyenBay.Name = "gbxThemSanBayTGChoChuyenBay";
            this.gbxThemSanBayTGChoChuyenBay.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxThemSanBayTGChoChuyenBay.Size = new System.Drawing.Size(339, 323);
            this.gbxThemSanBayTGChoChuyenBay.TabIndex = 71;
            this.gbxThemSanBayTGChoChuyenBay.TabStop = false;
            this.gbxThemSanBayTGChoChuyenBay.Text = "Thêm sân bay TG cho chuyến bay";
            this.gbxThemSanBayTGChoChuyenBay.CursorChanged += new System.EventHandler(this.gbxThemSanBayTGChoChuyenBay_CursorChanged);
            // 
            // btnThemSBTG
            // 
            this.btnThemSBTG.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnThem;
            this.btnThemSBTG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemSBTG.FlatAppearance.BorderSize = 0;
            this.btnThemSBTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSBTG.Location = new System.Drawing.Point(45, 99);
            this.btnThemSBTG.Name = "btnThemSBTG";
            this.btnThemSBTG.Size = new System.Drawing.Size(33, 32);
            this.btnThemSBTG.TabIndex = 42;
            this.btnThemSBTG.UseCompatibleTextRendering = true;
            this.btnThemSBTG.UseVisualStyleBackColor = true;
            this.btnThemSBTG.Click += new System.EventHandler(this.btnThemSBTG_Click);
            // 
            // cboTenSanBayTG
            // 
            this.cboTenSanBayTG.FormattingEnabled = true;
            this.cboTenSanBayTG.Location = new System.Drawing.Point(112, 17);
            this.cboTenSanBayTG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTenSanBayTG.Name = "cboTenSanBayTG";
            this.cboTenSanBayTG.Size = new System.Drawing.Size(200, 25);
            this.cboTenSanBayTG.TabIndex = 53;
            this.cboTenSanBayTG.CursorChanged += new System.EventHandler(this.gbxThemSanBayTGChoChuyenBay_CursorChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 48;
            this.label11.Text = "Tên sân bay";
            this.label11.CursorChanged += new System.EventHandler(this.gbxThemSanBayTGChoChuyenBay_CursorChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(112, 73);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(200, 23);
            this.txtGhiChu.TabIndex = 51;
            this.txtGhiChu.CursorChanged += new System.EventHandler(this.gbxThemSanBayTGChoChuyenBay_CursorChanged);
            // 
            // txtThoiGianNghi
            // 
            this.txtThoiGianNghi.Location = new System.Drawing.Point(112, 46);
            this.txtThoiGianNghi.Name = "txtThoiGianNghi";
            this.txtThoiGianNghi.Size = new System.Drawing.Size(200, 23);
            this.txtThoiGianNghi.TabIndex = 52;
            this.txtThoiGianNghi.CursorChanged += new System.EventHandler(this.gbxThemSanBayTGChoChuyenBay_CursorChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 49;
            this.label12.Text = "Ghi chú";
            this.label12.CursorChanged += new System.EventHandler(this.gbxThemSanBayTGChoChuyenBay_CursorChanged);
            // 
            // btnSuaSBTG
            // 
            this.btnSuaSBTG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaSBTG.BackgroundImage")));
            this.btnSuaSBTG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaSBTG.FlatAppearance.BorderSize = 0;
            this.btnSuaSBTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaSBTG.Location = new System.Drawing.Point(142, 99);
            this.btnSuaSBTG.Name = "btnSuaSBTG";
            this.btnSuaSBTG.Size = new System.Drawing.Size(33, 32);
            this.btnSuaSBTG.TabIndex = 41;
            this.btnSuaSBTG.UseVisualStyleBackColor = true;
            this.btnSuaSBTG.Click += new System.EventHandler(this.btnSuaSBTG_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 17);
            this.label13.TabIndex = 50;
            this.label13.Text = "Thời gian nghỉ";
            this.label13.CursorChanged += new System.EventHandler(this.gbxThemSanBayTGChoChuyenBay_CursorChanged);
            // 
            // dtgvSanBayTG
            // 
            this.dtgvSanBayTG.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvSanBayTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanBayTG.Location = new System.Drawing.Point(4, 141);
            this.dtgvSanBayTG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvSanBayTG.Name = "dtgvSanBayTG";
            this.dtgvSanBayTG.RowTemplate.Height = 24;
            this.dtgvSanBayTG.Size = new System.Drawing.Size(331, 177);
            this.dtgvSanBayTG.TabIndex = 47;
            this.dtgvSanBayTG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSanBayTG_CellClick);
            this.dtgvSanBayTG.CursorChanged += new System.EventHandler(this.gbxThemSanBayTGChoChuyenBay_CursorChanged);
            // 
            // btnXoaSBTG
            // 
            this.btnXoaSBTG.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnXoa;
            this.btnXoaSBTG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaSBTG.FlatAppearance.BorderSize = 0;
            this.btnXoaSBTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSBTG.Location = new System.Drawing.Point(235, 99);
            this.btnXoaSBTG.Name = "btnXoaSBTG";
            this.btnXoaSBTG.Size = new System.Drawing.Size(33, 32);
            this.btnXoaSBTG.TabIndex = 41;
            this.btnXoaSBTG.UseVisualStyleBackColor = true;
            this.btnXoaSBTG.Click += new System.EventHandler(this.btnXoaSBTG_Click);
            // 
            // frmQuanLyChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 687);
            this.Controls.Add(this.gbxThemSanBayTGChoChuyenBay);
            this.Controls.Add(this.gbxThemHangVeChoChuyenBay);
            this.Controls.Add(this.gbxThaoTac);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxDSChuyenBay);
            this.Controls.Add(this.gbxTTChuyenBay);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuanLyChuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm chuyến bay";
            this.Shown += new System.EventHandler(this.frmQuanLyChuyenBay_Shown);
            this.gbxThaoTac.ResumeLayout(false);
            this.gbxThaoTac.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxDSChuyenBay.ResumeLayout(false);
            this.gbxDSChuyenBay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenBay)).EndInit();
            this.gbxTTChuyenBay.ResumeLayout(false);
            this.gbxTTChuyenBay.PerformLayout();
            this.gbxThemHangVeChoChuyenBay.ResumeLayout(false);
            this.gbxThemHangVeChoChuyenBay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangVe)).EndInit();
            this.gbxThemSanBayTGChoChuyenBay.ResumeLayout(false);
            this.gbxThemSanBayTGChoChuyenBay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanBayTG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtThoiGianBay;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cboMaTuyenBay;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtMaChuyenBay;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cboMaMayBay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMaHangVe;
        private System.Windows.Forms.TextBox txtTongSoGhe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxThaoTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbxDSChuyenBay;
        private System.Windows.Forms.DataGridView dtgvChuyenBay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox gbxTTChuyenBay;
        private System.Windows.Forms.GroupBox gbxThemHangVeChoChuyenBay;
        private System.Windows.Forms.Button btnThemHV;
        private System.Windows.Forms.DataGridView dtgvHangVe;
        private System.Windows.Forms.Button btnSuaHV;
        private System.Windows.Forms.Button btnXoaHV;
        private System.Windows.Forms.GroupBox gbxThemSanBayTGChoChuyenBay;
        private System.Windows.Forms.DataGridView dtgvSanBayTG;
        private System.Windows.Forms.Button btnThemSBTG;
        private System.Windows.Forms.ComboBox cboTenSanBayTG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtThoiGianNghi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSuaSBTG;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnXoaSBTG;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboSanBayDen;
        private System.Windows.Forms.ComboBox cboSanBayDi;
        private System.Windows.Forms.DateTimePicker dtpkThoiGianKhoiHanh;
        private System.Windows.Forms.Label label1;
    }
}