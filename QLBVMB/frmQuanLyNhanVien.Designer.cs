﻿namespace Plane_Ticket
{
    partial class frmQuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhanVien));
            this.gbxThaoTac = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbxDSNhanVien = new System.Windows.Forms.GroupBox();
            this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.gbxTTNhanVien = new System.Windows.Forms.GroupBox();
            this.rdbtnNVBanVe = new System.Windows.Forms.RadioButton();
            this.rdbtnNVQuanTri = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.gbxThaoTac.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxDSNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
            this.gbxTTNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxThaoTac
            // 
            this.gbxThaoTac.Controls.Add(this.btnThem);
            this.gbxThaoTac.Controls.Add(this.label5);
            this.gbxThaoTac.Controls.Add(this.label4);
            this.gbxThaoTac.Controls.Add(this.label3);
            this.gbxThaoTac.Controls.Add(this.btnSua);
            this.gbxThaoTac.Controls.Add(this.btnXoa);
            this.gbxThaoTac.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbxThaoTac.Location = new System.Drawing.Point(9, 459);
            this.gbxThaoTac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxThaoTac.Name = "gbxThaoTac";
            this.gbxThaoTac.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxThaoTac.Size = new System.Drawing.Size(285, 82);
            this.gbxThaoTac.TabIndex = 2;
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
            this.btnThem.TabIndex = 6;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sửa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Thêm";
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
            this.btnSua.TabIndex = 7;
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
            this.btnXoa.TabIndex = 8;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Location = new System.Drawing.Point(-4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 47);
            this.panel1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(326, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 41);
            this.label1.TabIndex = 39;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThoat.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnCancel;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1025, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(41, 41);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gbxDSNhanVien
            // 
            this.gbxDSNhanVien.Controls.Add(this.dtgvNhanVien);
            this.gbxDSNhanVien.Controls.Add(this.label2);
            this.gbxDSNhanVien.Controls.Add(this.txtTimKiem);
            this.gbxDSNhanVien.Controls.Add(this.btnTimKiem);
            this.gbxDSNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbxDSNhanVien.Location = new System.Drawing.Point(298, 52);
            this.gbxDSNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxDSNhanVien.Name = "gbxDSNhanVien";
            this.gbxDSNhanVien.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxDSNhanVien.Size = new System.Drawing.Size(773, 579);
            this.gbxDSNhanVien.TabIndex = 3;
            this.gbxDSNhanVien.TabStop = false;
            this.gbxDSNhanVien.Text = "Danh sách nhân viên";
            // 
            // dtgvNhanVien
            // 
            this.dtgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanVien.Location = new System.Drawing.Point(4, 51);
            this.dtgvNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvNhanVien.Name = "dtgvNhanVien";
            this.dtgvNhanVien.RowTemplate.Height = 24;
            this.dtgvNhanVien.Size = new System.Drawing.Size(760, 524);
            this.dtgvNhanVien.TabIndex = 10;
            this.dtgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNhanVien_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tìm kiếm ";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(608, 23);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(125, 23);
            this.txtTimKiem.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::Plane_Ticket.Properties.Resources.btnTimKiem;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Location = new System.Drawing.Point(739, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(25, 24);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gbxTTNhanVien
            // 
            this.gbxTTNhanVien.Controls.Add(this.rdbtnNVBanVe);
            this.gbxTTNhanVien.Controls.Add(this.rdbtnNVQuanTri);
            this.gbxTTNhanVien.Controls.Add(this.txtPassword);
            this.gbxTTNhanVien.Controls.Add(this.label8);
            this.gbxTTNhanVien.Controls.Add(this.txtUsername);
            this.gbxTTNhanVien.Controls.Add(this.label7);
            this.gbxTTNhanVien.Controls.Add(this.txtTenNhanVien);
            this.gbxTTNhanVien.Controls.Add(this.label6);
            this.gbxTTNhanVien.Controls.Add(this.label20);
            this.gbxTTNhanVien.Controls.Add(this.label9);
            this.gbxTTNhanVien.Controls.Add(this.txtMaNhanVien);
            this.gbxTTNhanVien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.gbxTTNhanVien.Location = new System.Drawing.Point(9, 52);
            this.gbxTTNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxTTNhanVien.Name = "gbxTTNhanVien";
            this.gbxTTNhanVien.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxTTNhanVien.Size = new System.Drawing.Size(285, 402);
            this.gbxTTNhanVien.TabIndex = 1;
            this.gbxTTNhanVien.TabStop = false;
            this.gbxTTNhanVien.Text = "Thông tin nhân viên";
            // 
            // rdbtnNVBanVe
            // 
            this.rdbtnNVBanVe.AutoSize = true;
            this.rdbtnNVBanVe.Location = new System.Drawing.Point(130, 177);
            this.rdbtnNVBanVe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbtnNVBanVe.Name = "rdbtnNVBanVe";
            this.rdbtnNVBanVe.Size = new System.Drawing.Size(67, 21);
            this.rdbtnNVBanVe.TabIndex = 5;
            this.rdbtnNVBanVe.TabStop = true;
            this.rdbtnNVBanVe.Text = "Bán vé";
            this.rdbtnNVBanVe.UseVisualStyleBackColor = true;
            // 
            // rdbtnNVQuanTri
            // 
            this.rdbtnNVQuanTri.AutoSize = true;
            this.rdbtnNVQuanTri.Location = new System.Drawing.Point(130, 155);
            this.rdbtnNVQuanTri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbtnNVQuanTri.Name = "rdbtnNVQuanTri";
            this.rdbtnNVQuanTri.Size = new System.Drawing.Size(79, 21);
            this.rdbtnNVQuanTri.TabIndex = 4;
            this.rdbtnNVQuanTri.TabStop = true;
            this.rdbtnNVQuanTri.Text = "Quản trị";
            this.rdbtnNVQuanTri.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(130, 119);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(151, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Loại nhân viên";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(130, 86);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(151, 23);
            this.txtUsername.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Password";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(130, 54);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(151, 23);
            this.txtTenNhanVien.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Username";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 17);
            this.label20.TabIndex = 15;
            this.label20.Text = "Mã nhân viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tên nhân viên";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(130, 23);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(151, 23);
            this.txtMaNhanVien.TabIndex = 17;
            this.txtMaNhanVien.TabStop = false;
            // 
            // frmQuanLyNhanVien
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1074, 642);
            this.Controls.Add(this.gbxThaoTac);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxDSNhanVien);
            this.Controls.Add(this.gbxTTNhanVien);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuanLyNhanVien";
            this.Text = "Quản lý nhân viên";
            this.Shown += new System.EventHandler(this.frmQuanLyNhanVien_Shown);
            this.gbxThaoTac.ResumeLayout(false);
            this.gbxThaoTac.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxDSNhanVien.ResumeLayout(false);
            this.gbxDSNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).EndInit();
            this.gbxTTNhanVien.ResumeLayout(false);
            this.gbxTTNhanVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxThaoTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbxDSNhanVien;
        private System.Windows.Forms.DataGridView dtgvNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox gbxTTNhanVien;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.RadioButton rdbtnNVBanVe;
        private System.Windows.Forms.RadioButton rdbtnNVQuanTri;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label6;
    }
}