namespace BaoCaoCuoiKy.User_Control
{
    partial class UC_ADMIN_ORDER
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_hoadon = new System.Windows.Forms.DataGridView();
            this.col_maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_chitiethoadon = new System.Windows.Forms.DataGridView();
            this.col_maMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelControl = new Guna.UI2.WinForms.Guna2Panel();
            this.dateTimePickerPayment = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.textBoxTotalPayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxStaffName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxStaffId = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxOrderId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClearFilter = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxMonth = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_chitiethoadon)).BeginInit();
            this.panelControl.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_hoadon
            // 
            this.dg_hoadon.AllowUserToAddRows = false;
            this.dg_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_maHD,
            this.col_ten,
            this.col_maNV,
            this.col_ngay,
            this.col_tong});
            this.dg_hoadon.Location = new System.Drawing.Point(19, 163);
            this.dg_hoadon.Margin = new System.Windows.Forms.Padding(4);
            this.dg_hoadon.Name = "dg_hoadon";
            this.dg_hoadon.Size = new System.Drawing.Size(911, 459);
            this.dg_hoadon.TabIndex = 0;
            this.dg_hoadon.SelectionChanged += new System.EventHandler(this.DgHoaDon_SelectionChanged);
            // 
            // col_maHD
            // 
            this.col_maHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_maHD.HeaderText = "Mã hóa đơn";
            this.col_maHD.Name = "col_maHD";
            // 
            // col_ten
            // 
            this.col_ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ten.HeaderText = "Nhân viên thanh toán";
            this.col_ten.Name = "col_ten";
            // 
            // col_maNV
            // 
            this.col_maNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_maNV.HeaderText = "Mã nhân viên";
            this.col_maNV.Name = "col_maNV";
            // 
            // col_ngay
            // 
            this.col_ngay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ngay.HeaderText = "Ngày thanh toán";
            this.col_ngay.Name = "col_ngay";
            // 
            // col_tong
            // 
            this.col_tong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_tong.HeaderText = "Tổng hóa đơn";
            this.col_tong.Name = "col_tong";
            // 
            // dg_chitiethoadon
            // 
            this.dg_chitiethoadon.AllowUserToAddRows = false;
            this.dg_chitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_chitiethoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_maMon,
            this.col_tenMon,
            this.col_soLuong,
            this.col_donGia,
            this.col_thanhTien});
            this.dg_chitiethoadon.Location = new System.Drawing.Point(18, 64);
            this.dg_chitiethoadon.Margin = new System.Windows.Forms.Padding(4);
            this.dg_chitiethoadon.Name = "dg_chitiethoadon";
            this.dg_chitiethoadon.Size = new System.Drawing.Size(639, 558);
            this.dg_chitiethoadon.TabIndex = 1;
            // 
            // col_maMon
            // 
            this.col_maMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_maMon.HeaderText = "Mã món ăn";
            this.col_maMon.Name = "col_maMon";
            // 
            // col_tenMon
            // 
            this.col_tenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_tenMon.HeaderText = "Tên món ăn";
            this.col_tenMon.Name = "col_tenMon";
            // 
            // col_soLuong
            // 
            this.col_soLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_soLuong.HeaderText = "Số lượng";
            this.col_soLuong.Name = "col_soLuong";
            // 
            // col_donGia
            // 
            this.col_donGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_donGia.HeaderText = "Đơn giá";
            this.col_donGia.Name = "col_donGia";
            // 
            // col_thanhTien
            // 
            this.col_thanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_thanhTien.HeaderText = "Thành tiền";
            this.col_thanhTien.Name = "col_thanhTien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhân viên thanh toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(975, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày thanh toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1300, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng thanh toán";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(22, 54);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(353, 42);
            this.lblHeader.TabIndex = 27;
            this.lblHeader.Text = "THỐNG KÊ HOÁ ĐƠN";
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.White;
            this.panelControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl.BorderRadius = 16;
            this.panelControl.BorderThickness = 1;
            this.panelControl.Controls.Add(this.dateTimePickerPayment);
            this.panelControl.Controls.Add(this.textBoxTotalPayment);
            this.panelControl.Controls.Add(this.textBoxStaffName);
            this.panelControl.Controls.Add(this.textBoxStaffId);
            this.panelControl.Controls.Add(this.textBoxOrderId);
            this.panelControl.Controls.Add(this.label5);
            this.panelControl.Controls.Add(this.label10);
            this.panelControl.Controls.Add(this.label11);
            this.panelControl.Controls.Add(this.label4);
            this.panelControl.Controls.Add(this.label9);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Location = new System.Drawing.Point(29, 145);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1636, 179);
            this.panelControl.TabIndex = 28;
            // 
            // dateTimePickerPayment
            // 
            this.dateTimePickerPayment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePickerPayment.BorderColor = System.Drawing.Color.Green;
            this.dateTimePickerPayment.BorderRadius = 12;
            this.dateTimePickerPayment.BorderThickness = 1;
            this.dateTimePickerPayment.Checked = true;
            this.dateTimePickerPayment.FillColor = System.Drawing.Color.White;
            this.dateTimePickerPayment.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.dateTimePickerPayment.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerPayment.Location = new System.Drawing.Point(969, 92);
            this.dateTimePickerPayment.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerPayment.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerPayment.Name = "dateTimePickerPayment";
            this.dateTimePickerPayment.Size = new System.Drawing.Size(312, 43);
            this.dateTimePickerPayment.TabIndex = 42;
            this.dateTimePickerPayment.Value = new System.DateTime(2023, 12, 10, 10, 26, 18, 168);
            // 
            // textBoxTotalPayment
            // 
            this.textBoxTotalPayment.BorderColor = System.Drawing.Color.Green;
            this.textBoxTotalPayment.BorderRadius = 10;
            this.textBoxTotalPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTotalPayment.DefaultText = "";
            this.textBoxTotalPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTotalPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTotalPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTotalPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTotalPayment.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTotalPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTotalPayment.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalPayment.ForeColor = System.Drawing.Color.Black;
            this.textBoxTotalPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTotalPayment.Location = new System.Drawing.Point(1303, 92);
            this.textBoxTotalPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTotalPayment.Name = "textBoxTotalPayment";
            this.textBoxTotalPayment.PasswordChar = '\0';
            this.textBoxTotalPayment.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBoxTotalPayment.PlaceholderText = "Tổng tiền";
            this.textBoxTotalPayment.ReadOnly = true;
            this.textBoxTotalPayment.SelectedText = "";
            this.textBoxTotalPayment.Size = new System.Drawing.Size(318, 43);
            this.textBoxTotalPayment.TabIndex = 35;
            // 
            // textBoxStaffName
            // 
            this.textBoxStaffName.BorderColor = System.Drawing.Color.Green;
            this.textBoxStaffName.BorderRadius = 10;
            this.textBoxStaffName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxStaffName.DefaultText = "";
            this.textBoxStaffName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxStaffName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxStaffName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxStaffName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxStaffName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxStaffName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxStaffName.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStaffName.ForeColor = System.Drawing.Color.Black;
            this.textBoxStaffName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxStaffName.Location = new System.Drawing.Point(644, 92);
            this.textBoxStaffName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStaffName.Name = "textBoxStaffName";
            this.textBoxStaffName.PasswordChar = '\0';
            this.textBoxStaffName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBoxStaffName.PlaceholderText = "Tên nhân viên";
            this.textBoxStaffName.ReadOnly = true;
            this.textBoxStaffName.SelectedText = "";
            this.textBoxStaffName.Size = new System.Drawing.Size(315, 43);
            this.textBoxStaffName.TabIndex = 37;
            // 
            // textBoxStaffId
            // 
            this.textBoxStaffId.BorderColor = System.Drawing.Color.Green;
            this.textBoxStaffId.BorderRadius = 10;
            this.textBoxStaffId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxStaffId.DefaultText = "";
            this.textBoxStaffId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxStaffId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxStaffId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxStaffId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxStaffId.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxStaffId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxStaffId.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStaffId.ForeColor = System.Drawing.Color.Black;
            this.textBoxStaffId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxStaffId.Location = new System.Drawing.Point(324, 92);
            this.textBoxStaffId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxStaffId.Name = "textBoxStaffId";
            this.textBoxStaffId.PasswordChar = '\0';
            this.textBoxStaffId.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBoxStaffId.PlaceholderText = "Mã nhân viên";
            this.textBoxStaffId.ReadOnly = true;
            this.textBoxStaffId.SelectedText = "";
            this.textBoxStaffId.Size = new System.Drawing.Size(303, 43);
            this.textBoxStaffId.TabIndex = 36;
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.BorderColor = System.Drawing.Color.Green;
            this.textBoxOrderId.BorderRadius = 10;
            this.textBoxOrderId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxOrderId.DefaultText = "";
            this.textBoxOrderId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxOrderId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxOrderId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxOrderId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxOrderId.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxOrderId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxOrderId.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrderId.ForeColor = System.Drawing.Color.Black;
            this.textBoxOrderId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxOrderId.Location = new System.Drawing.Point(18, 92);
            this.textBoxOrderId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.PasswordChar = '\0';
            this.textBoxOrderId.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBoxOrderId.PlaceholderText = "Mã hoá đơn";
            this.textBoxOrderId.ReadOnly = true;
            this.textBoxOrderId.SelectedText = "";
            this.textBoxOrderId.Size = new System.Drawing.Size(290, 43);
            this.textBoxOrderId.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(14, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Thông tin chi tiết hoá đơn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 88);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 18);
            this.label11.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mã nhân viên";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderRadius = 16;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnClearFilter);
            this.guna2Panel1.Controls.Add(this.comboBoxMonth);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.dg_hoadon);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label12);
            this.guna2Panel1.Location = new System.Drawing.Point(29, 354);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(945, 636);
            this.guna2Panel1.TabIndex = 44;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BorderRadius = 12;
            this.btnClearFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearFilter.FillColor = System.Drawing.Color.Red;
            this.btnClearFilter.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClearFilter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClearFilter.Location = new System.Drawing.Point(376, 99);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(180, 42);
            this.btnClearFilter.TabIndex = 48;
            this.btnClearFilter.Text = "Xoá bộ lọc";
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxMonth.BorderColor = System.Drawing.Color.Green;
            this.comboBoxMonth.BorderRadius = 10;
            this.comboBoxMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxMonth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxMonth.Font = new System.Drawing.Font("Roboto", 12F);
            this.comboBoxMonth.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMonth.ItemHeight = 36;
            this.comboBoxMonth.Location = new System.Drawing.Point(110, 99);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(248, 42);
            this.comboBoxMonth.TabIndex = 46;
            this.comboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonth_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Chọn tháng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 43;
            this.label8.Text = "Lọc theo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(14, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Danh sách hoá đơn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 88);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 18);
            this.label12.TabIndex = 6;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel2.BorderRadius = 16;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.dg_chitiethoadon);
            this.guna2Panel2.Controls.Add(this.label18);
            this.guna2Panel2.Controls.Add(this.label19);
            this.guna2Panel2.Location = new System.Drawing.Point(993, 354);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(672, 636);
            this.guna2Panel2.TabIndex = 49;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(14, 16);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 23);
            this.label18.TabIndex = 23;
            this.label18.Text = "Chi tiết món";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 88);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 18);
            this.label19.TabIndex = 6;
            // 
            // UC_ADMIN_ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ADMIN_ORDER";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.UC_QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_chitiethoadon)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_hoadon;
        private System.Windows.Forms.DataGridView dg_chitiethoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHeader;
        private Guna.UI2.WinForms.Guna2Panel panelControl;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerPayment;
        private Guna.UI2.WinForms.Guna2TextBox textBoxStaffName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxStaffId;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTotalPayment;
        private Guna.UI2.WinForms.Guna2TextBox textBoxOrderId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnClearFilter;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_thanhTien;
    }
}
