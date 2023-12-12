namespace BaoCaoCuoiKy.User_Control
{
    partial class UC_QuanLyNgayCong
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
            this.dg_ngayCong = new System.Windows.Forms.DataGridView();
            this.col_maCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tenCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelControl = new Guna.UI2.WinForms.Guna2Panel();
            this.dateTimePickerWorkDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.textBoxStaffName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxStaffId = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxShiftName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxShiftId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClearFilter = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxShift = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxMonth = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ngayCong)).BeginInit();
            this.panelControl.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_ngayCong
            // 
            this.dg_ngayCong.AllowUserToAddRows = false;
            this.dg_ngayCong.BackgroundColor = System.Drawing.Color.White;
            this.dg_ngayCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ngayCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_maCa,
            this.col_tenCa,
            this.col_maNV,
            this.col_tenNV,
            this.col_ngay});
            this.dg_ngayCong.Location = new System.Drawing.Point(18, 177);
            this.dg_ngayCong.Margin = new System.Windows.Forms.Padding(4);
            this.dg_ngayCong.Name = "dg_ngayCong";
            this.dg_ngayCong.Size = new System.Drawing.Size(1597, 421);
            this.dg_ngayCong.TabIndex = 0;
            this.dg_ngayCong.SelectionChanged += new System.EventHandler(this.DgNgayCong_SelectionChanged);
            // 
            // col_maCa
            // 
            this.col_maCa.HeaderText = "Mã ca";
            this.col_maCa.Name = "col_maCa";
            // 
            // col_tenCa
            // 
            this.col_tenCa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_tenCa.HeaderText = "Tên ca";
            this.col_tenCa.Name = "col_tenCa";
            // 
            // col_maNV
            // 
            this.col_maNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_maNV.HeaderText = "Mã nhân viên";
            this.col_maNV.Name = "col_maNV";
            // 
            // col_tenNV
            // 
            this.col_tenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_tenNV.HeaderText = "Tên nhân viên";
            this.col_tenNV.Name = "col_tenNV";
            // 
            // col_ngay
            // 
            this.col_ngay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ngay.HeaderText = "Ngày làm";
            this.col_ngay.Name = "col_ngay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(973, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1300, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày làm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 483);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tháng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 483);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ca";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(29, 56);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(365, 42);
            this.lblHeader.TabIndex = 26;
            this.lblHeader.Text = "QUẢN LÝ NGÀY CÔNG";
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.White;
            this.panelControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl.BorderRadius = 16;
            this.panelControl.BorderThickness = 1;
            this.panelControl.Controls.Add(this.dateTimePickerWorkDate);
            this.panelControl.Controls.Add(this.textBoxStaffName);
            this.panelControl.Controls.Add(this.textBoxStaffId);
            this.panelControl.Controls.Add(this.textBoxShiftName);
            this.panelControl.Controls.Add(this.textBoxShiftId);
            this.panelControl.Controls.Add(this.label10);
            this.panelControl.Controls.Add(this.label11);
            this.panelControl.Controls.Add(this.label12);
            this.panelControl.Controls.Add(this.label13);
            this.panelControl.Controls.Add(this.label5);
            this.panelControl.Controls.Add(this.label4);
            this.panelControl.Controls.Add(this.label3);
            this.panelControl.Location = new System.Drawing.Point(36, 144);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1636, 199);
            this.panelControl.TabIndex = 27;
            // 
            // dateTimePickerWorkDate
            // 
            this.dateTimePickerWorkDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePickerWorkDate.BorderColor = System.Drawing.Color.Green;
            this.dateTimePickerWorkDate.BorderRadius = 12;
            this.dateTimePickerWorkDate.BorderThickness = 1;
            this.dateTimePickerWorkDate.Checked = true;
            this.dateTimePickerWorkDate.FillColor = System.Drawing.Color.White;
            this.dateTimePickerWorkDate.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.dateTimePickerWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerWorkDate.Location = new System.Drawing.Point(1303, 113);
            this.dateTimePickerWorkDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerWorkDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerWorkDate.Name = "dateTimePickerWorkDate";
            this.dateTimePickerWorkDate.Size = new System.Drawing.Size(312, 43);
            this.dateTimePickerWorkDate.TabIndex = 42;
            this.dateTimePickerWorkDate.Value = new System.DateTime(2023, 12, 10, 10, 26, 18, 168);
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
            this.textBoxStaffName.Location = new System.Drawing.Point(976, 113);
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
            this.textBoxStaffId.Location = new System.Drawing.Point(657, 113);
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
            // textBoxShiftName
            // 
            this.textBoxShiftName.BorderColor = System.Drawing.Color.Green;
            this.textBoxShiftName.BorderRadius = 10;
            this.textBoxShiftName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxShiftName.DefaultText = "";
            this.textBoxShiftName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxShiftName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxShiftName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxShiftName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxShiftName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxShiftName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxShiftName.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShiftName.ForeColor = System.Drawing.Color.Black;
            this.textBoxShiftName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxShiftName.Location = new System.Drawing.Point(324, 113);
            this.textBoxShiftName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxShiftName.Name = "textBoxShiftName";
            this.textBoxShiftName.PasswordChar = '\0';
            this.textBoxShiftName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBoxShiftName.PlaceholderText = "Nhập tên ca";
            this.textBoxShiftName.ReadOnly = true;
            this.textBoxShiftName.SelectedText = "";
            this.textBoxShiftName.Size = new System.Drawing.Size(318, 43);
            this.textBoxShiftName.TabIndex = 35;
            // 
            // textBoxShiftId
            // 
            this.textBoxShiftId.BorderColor = System.Drawing.Color.Green;
            this.textBoxShiftId.BorderRadius = 10;
            this.textBoxShiftId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxShiftId.DefaultText = "";
            this.textBoxShiftId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxShiftId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxShiftId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxShiftId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxShiftId.FillColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxShiftId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxShiftId.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShiftId.ForeColor = System.Drawing.Color.Black;
            this.textBoxShiftId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxShiftId.Location = new System.Drawing.Point(18, 113);
            this.textBoxShiftId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxShiftId.Name = "textBoxShiftId";
            this.textBoxShiftId.PasswordChar = '\0';
            this.textBoxShiftId.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBoxShiftId.PlaceholderText = "Nhập mã ca";
            this.textBoxShiftId.ReadOnly = true;
            this.textBoxShiftId.SelectedText = "";
            this.textBoxShiftId.Size = new System.Drawing.Size(290, 43);
            this.textBoxShiftId.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(14, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Thông tin chi tiết ngày công";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(321, 91);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "Tên ca";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 91);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "Mã ca";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderRadius = 16;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnClearFilter);
            this.guna2Panel1.Controls.Add(this.comboBoxShift);
            this.guna2Panel1.Controls.Add(this.comboBoxMonth);
            this.guna2Panel1.Controls.Add(this.label14);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.dg_ngayCong);
            this.guna2Panel1.Location = new System.Drawing.Point(36, 373);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1636, 616);
            this.guna2Panel1.TabIndex = 43;
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
            this.btnClearFilter.Location = new System.Drawing.Point(801, 99);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(180, 42);
            this.btnClearFilter.TabIndex = 48;
            this.btnClearFilter.Text = "Xoá bộ lọc";
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // comboBoxShift
            // 
            this.comboBoxShift.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxShift.BorderColor = System.Drawing.Color.Green;
            this.comboBoxShift.BorderRadius = 10;
            this.comboBoxShift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShift.FillColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxShift.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxShift.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxShift.Font = new System.Drawing.Font("Roboto", 12F);
            this.comboBoxShift.ForeColor = System.Drawing.Color.Black;
            this.comboBoxShift.ItemHeight = 36;
            this.comboBoxShift.Location = new System.Drawing.Point(508, 99);
            this.comboBoxShift.Name = "comboBoxShift";
            this.comboBoxShift.Size = new System.Drawing.Size(248, 42);
            this.comboBoxShift.TabIndex = 47;
            this.comboBoxShift.SelectedIndexChanged += new System.EventHandler(this.comboBoxShift_SelectedIndexChanged);
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(374, 110);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 18);
            this.label14.TabIndex = 45;
            this.label14.Text = "Chọn ca làm việc:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 44;
            this.label9.Text = "Chọn tháng:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Danh sách ngày công";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 6;
            // 
            // UC_QuanLyNgayCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_QuanLyNgayCong";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.UC_QuanLyNgayCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ngayCong)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_ngayCong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHeader;
        private Guna.UI2.WinForms.Guna2Panel panelControl;
        private Guna.UI2.WinForms.Guna2TextBox textBoxStaffName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxStaffId;
        private Guna.UI2.WinForms.Guna2TextBox textBoxShiftName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxShiftId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerWorkDate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tenCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2Button btnClearFilter;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxShift;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxMonth;
    }
}
