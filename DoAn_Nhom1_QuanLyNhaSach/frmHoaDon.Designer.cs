﻿namespace DoAn_Nhom1_QuanLyNhaSach
{
    partial class frmHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvHoaDon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.dtPickerNgayLap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblmaHD = new System.Windows.Forms.Label();
            this.btnChitiet = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.cmbMaNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMaHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(991, 696);
            this.Panel1.TabIndex = 3;
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.Controls.Add(this.dgvHoaDon);
            this.Panel3.Location = new System.Drawing.Point(0, 269);
            this.Panel3.Name = "Panel3";
            this.Panel3.ShadowDecoration.Parent = this.Panel3;
            this.Panel3.Size = new System.Drawing.Size(988, 427);
            this.Panel3.TabIndex = 1;
            // 
            // dgvHoaDon
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(988, 427);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHoaDon.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvHoaDon.ThemeStyle.ReadOnly = false;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.Controls.Add(this.btnLamMoi);
            this.Panel2.Controls.Add(this.dtPickerNgayLap);
            this.Panel2.Controls.Add(this.lblMaNV);
            this.Panel2.Controls.Add(this.lblNgayLap);
            this.Panel2.Controls.Add(this.lblmaHD);
            this.Panel2.Controls.Add(this.btnChitiet);
            this.Panel2.Controls.Add(this.btnSua);
            this.Panel2.Controls.Add(this.btnThem);
            this.Panel2.Controls.Add(this.btnXoa);
            this.Panel2.Controls.Add(this.cmbMaNV);
            this.Panel2.Controls.Add(this.txtMaHD);
            this.Panel2.Location = new System.Drawing.Point(24, 21);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(941, 229);
            this.Panel2.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.BorderRadius = 12;
            this.btnLamMoi.CheckedState.Parent = this.btnLamMoi;
            this.btnLamMoi.CustomImages.Parent = this.btnLamMoi;
            this.btnLamMoi.FillColor = System.Drawing.Color.DarkOrange;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.HoverState.Parent = this.btnLamMoi;
            this.btnLamMoi.Location = new System.Drawing.Point(686, 174);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShadowDecoration.Parent = this.btnLamMoi;
            this.btnLamMoi.Size = new System.Drawing.Size(169, 38);
            this.btnLamMoi.TabIndex = 72;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dtPickerNgayLap
            // 
            this.dtPickerNgayLap.BorderRadius = 15;
            this.dtPickerNgayLap.CheckedState.Parent = this.dtPickerNgayLap;
            this.dtPickerNgayLap.FillColor = System.Drawing.Color.Gainsboro;
            this.dtPickerNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtPickerNgayLap.HoverState.Parent = this.dtPickerNgayLap;
            this.dtPickerNgayLap.Location = new System.Drawing.Point(214, 93);
            this.dtPickerNgayLap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPickerNgayLap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPickerNgayLap.Name = "dtPickerNgayLap";
            this.dtPickerNgayLap.ShadowDecoration.Parent = this.dtPickerNgayLap;
            this.dtPickerNgayLap.Size = new System.Drawing.Size(208, 35);
            this.dtPickerNgayLap.TabIndex = 70;
            this.dtPickerNgayLap.Value = new System.DateTime(2023, 11, 11, 1, 32, 18, 66);
            this.dtPickerNgayLap.ValueChanged += new System.EventHandler(this.dtPickerNgayLap_ValueChanged);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMaNV.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMaNV.Location = new System.Drawing.Point(55, 155);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(107, 18);
            this.lblMaNV.TabIndex = 68;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNgayLap.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNgayLap.Location = new System.Drawing.Point(55, 103);
            this.lblNgayLap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(73, 18);
            this.lblNgayLap.TabIndex = 67;
            this.lblNgayLap.Text = "Ngày lập";
            // 
            // lblmaHD
            // 
            this.lblmaHD.AutoSize = true;
            this.lblmaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblmaHD.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblmaHD.Location = new System.Drawing.Point(55, 47);
            this.lblmaHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmaHD.Name = "lblmaHD";
            this.lblmaHD.Size = new System.Drawing.Size(97, 18);
            this.lblmaHD.TabIndex = 55;
            this.lblmaHD.Text = "Mã hóa đơn";
            // 
            // btnChitiet
            // 
            this.btnChitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChitiet.BorderRadius = 12;
            this.btnChitiet.CheckedState.Parent = this.btnChitiet;
            this.btnChitiet.CustomImages.Parent = this.btnChitiet;
            this.btnChitiet.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnChitiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChitiet.ForeColor = System.Drawing.Color.White;
            this.btnChitiet.HoverState.Parent = this.btnChitiet;
            this.btnChitiet.Location = new System.Drawing.Point(533, 90);
            this.btnChitiet.Name = "btnChitiet";
            this.btnChitiet.ShadowDecoration.Parent = this.btnChitiet;
            this.btnChitiet.Size = new System.Drawing.Size(132, 69);
            this.btnChitiet.TabIndex = 66;
            this.btnChitiet.Text = "Quản lý CTHD";
            this.btnChitiet.Click += new System.EventHandler(this.btnChitiet_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BorderRadius = 12;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Location = new System.Drawing.Point(686, 121);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(169, 38);
            this.btnSua.TabIndex = 65;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BorderRadius = 12;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.SteelBlue;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Location = new System.Drawing.Point(686, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(169, 38);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BorderRadius = 12;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.IndianRed;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(686, 68);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(169, 38);
            this.btnXoa.TabIndex = 64;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.BackColor = System.Drawing.Color.Transparent;
            this.cmbMaNV.BorderRadius = 15;
            this.cmbMaNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaNV.FocusedColor = System.Drawing.Color.Empty;
            this.cmbMaNV.FocusedState.Parent = this.cmbMaNV;
            this.cmbMaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.HoverState.Parent = this.cmbMaNV;
            this.cmbMaNV.ItemHeight = 30;
            this.cmbMaNV.ItemsAppearance.Parent = this.cmbMaNV;
            this.cmbMaNV.Location = new System.Drawing.Point(214, 147);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.ShadowDecoration.Parent = this.cmbMaNV;
            this.cmbMaNV.Size = new System.Drawing.Size(208, 36);
            this.cmbMaNV.TabIndex = 60;
            // 
            // txtMaHD
            // 
            this.txtMaHD.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtMaHD.BorderRadius = 10;
            this.txtMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHD.DefaultText = "";
            this.txtMaHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.DisabledState.Parent = this.txtMaHD;
            this.txtMaHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.FocusedState.Parent = this.txtMaHD;
            this.txtMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.ForeColor = System.Drawing.Color.Black;
            this.txtMaHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.HoverState.Parent = this.txtMaHD;
            this.txtMaHD.Location = new System.Drawing.Point(214, 35);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PasswordChar = '\0';
            this.txtMaHD.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMaHD.PlaceholderText = "Mã hoá đơn";
            this.txtMaHD.SelectedText = "";
            this.txtMaHD.ShadowDecoration.Parent = this.txtMaHD;
            this.txtMaHD.Size = new System.Drawing.Size(208, 36);
            this.txtMaHD.TabIndex = 48;
            this.txtMaHD.Leave += new System.EventHandler(this.txtMaHD_Leave);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 696);
            this.Controls.Add(this.Panel1);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2Panel Panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHoaDon;
        private Guna.UI2.WinForms.Guna2Panel Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMaNV;
        internal Guna.UI2.WinForms.Guna2TextBox txtMaHD;
        internal Guna.UI2.WinForms.Guna2Button btnChitiet;
        internal Guna.UI2.WinForms.Guna2Button btnSua;
        internal Guna.UI2.WinForms.Guna2Button btnThem;
        internal Guna.UI2.WinForms.Guna2Button btnXoa;
        private System.Windows.Forms.Label lblmaHD;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblNgayLap;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtPickerNgayLap;
        internal Guna.UI2.WinForms.Guna2Button btnLamMoi;
    }
}