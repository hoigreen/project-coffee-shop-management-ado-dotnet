namespace BaoCaoCuoiKy.User_Control
{
    partial class UC_ADMIN_WORKTIME
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_calam = new System.Windows.Forms.DataGridView();
            this.col_ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cancelSave = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelControl = new Guna.UI2.WinForms.Guna2Panel();
            this.textBoxSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxId = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelDataList = new Guna.UI2.WinForms.Guna2Panel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_calam)).BeginInit();
            this.panelControl.SuspendLayout();
            this.panelDataList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_calam
            // 
            this.dg_calam.AllowUserToAddRows = false;
            this.dg_calam.BackgroundColor = System.Drawing.Color.White;
            this.dg_calam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_calam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_calam.ColumnHeadersHeight = 40;
            this.dg_calam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_calam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ma,
            this.col_ten,
            this.col_thoigian,
            this.col_luong});
            this.dg_calam.Location = new System.Drawing.Point(18, 58);
            this.dg_calam.Margin = new System.Windows.Forms.Padding(4);
            this.dg_calam.Name = "dg_calam";
            this.dg_calam.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_calam.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_calam.RowHeadersWidth = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            this.dg_calam.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_calam.Size = new System.Drawing.Size(1608, 468);
            this.dg_calam.TabIndex = 0;
            this.dg_calam.SelectionChanged += new System.EventHandler(this.DgCaLam_SelectionChanged);
            // 
            // col_ma
            // 
            this.col_ma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ma.HeaderText = "Mã ca";
            this.col_ma.Name = "col_ma";
            // 
            // col_ten
            // 
            this.col_ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ten.HeaderText = "Tên ca";
            this.col_ten.Name = "col_ten";
            // 
            // col_thoigian
            // 
            this.col_thoigian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_thoigian.HeaderText = "Thời gian";
            this.col_thoigian.Name = "col_thoigian";
            // 
            // col_luong
            // 
            this.col_luong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_luong.HeaderText = "Lương";
            this.col_luong.Name = "col_luong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã ca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên ca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(834, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thời gian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1232, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lương";
            // 
            // btn_save
            // 
            this.btn_save.BorderRadius = 12;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.Green;
            this.btn_save.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(583, 195);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(140, 50);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Lưu";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancelSave
            // 
            this.btn_cancelSave.BorderRadius = 12;
            this.btn_cancelSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancelSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancelSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancelSave.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelSave.ForeColor = System.Drawing.Color.White;
            this.btn_cancelSave.Location = new System.Drawing.Point(753, 195);
            this.btn_cancelSave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelSave.Name = "btn_cancelSave";
            this.btn_cancelSave.Size = new System.Drawing.Size(140, 50);
            this.btn_cancelSave.TabIndex = 14;
            this.btn_cancelSave.Text = "Không lưu";
            this.btn_cancelSave.Click += new System.EventHandler(this.btn_cancelSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(21, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 42);
            this.label5.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(383, 42);
            this.label6.TabIndex = 16;
            this.label6.Text = "QUẢN LÝ CA LÀM VIỆC";
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.White;
            this.panelControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl.BorderRadius = 16;
            this.panelControl.BorderThickness = 1;
            this.panelControl.Controls.Add(this.textBoxSalary);
            this.panelControl.Controls.Add(this.textBoxTime);
            this.panelControl.Controls.Add(this.textBoxName);
            this.panelControl.Controls.Add(this.textBoxId);
            this.panelControl.Controls.Add(this.btn_cancelSave);
            this.panelControl.Controls.Add(this.btn_save);
            this.panelControl.Controls.Add(this.btnClear);
            this.panelControl.Controls.Add(this.label4);
            this.panelControl.Controls.Add(this.btnCreate);
            this.panelControl.Controls.Add(this.btnDelete);
            this.panelControl.Controls.Add(this.btnEdit);
            this.panelControl.Controls.Add(this.label3);
            this.panelControl.Controls.Add(this.label8);
            this.panelControl.Controls.Add(this.label9);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Location = new System.Drawing.Point(28, 150);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1646, 267);
            this.panelControl.TabIndex = 23;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.BorderColor = System.Drawing.Color.Green;
            this.textBoxSalary.BorderRadius = 10;
            this.textBoxSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSalary.DefaultText = "";
            this.textBoxSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSalary.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalary.ForeColor = System.Drawing.Color.Black;
            this.textBoxSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSalary.Location = new System.Drawing.Point(1235, 113);
            this.textBoxSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.PasswordChar = '\0';
            this.textBoxSalary.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBoxSalary.PlaceholderText = "Nhập vào mức lương";
            this.textBoxSalary.SelectedText = "";
            this.textBoxSalary.Size = new System.Drawing.Size(391, 43);
            this.textBoxSalary.TabIndex = 37;
            // 
            // textBoxTime
            // 
            this.textBoxTime.BorderColor = System.Drawing.Color.Green;
            this.textBoxTime.BorderRadius = 10;
            this.textBoxTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTime.DefaultText = "";
            this.textBoxTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTime.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTime.ForeColor = System.Drawing.Color.Black;
            this.textBoxTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxTime.Location = new System.Drawing.Point(837, 113);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.PasswordChar = '\0';
            this.textBoxTime.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBoxTime.PlaceholderText = "Nhập thời gian làm việc";
            this.textBoxTime.SelectedText = "";
            this.textBoxTime.Size = new System.Drawing.Size(373, 43);
            this.textBoxTime.TabIndex = 36;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderColor = System.Drawing.Color.Green;
            this.textBoxName.BorderRadius = 10;
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.DefaultText = "";
            this.textBoxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxName.Location = new System.Drawing.Point(424, 113);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBoxName.PlaceholderText = "Nhập tên ca";
            this.textBoxName.SelectedText = "";
            this.textBoxName.Size = new System.Drawing.Size(377, 43);
            this.textBoxName.TabIndex = 35;
            // 
            // textBoxId
            // 
            this.textBoxId.BorderColor = System.Drawing.Color.Green;
            this.textBoxId.BorderRadius = 10;
            this.textBoxId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxId.DefaultText = "";
            this.textBoxId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxId.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.ForeColor = System.Drawing.Color.Black;
            this.textBoxId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxId.Location = new System.Drawing.Point(18, 113);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.PasswordChar = '\0';
            this.textBoxId.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBoxId.PlaceholderText = "Nhập mã ca";
            this.textBoxId.SelectedText = "";
            this.textBoxId.Size = new System.Drawing.Size(373, 43);
            this.textBoxId.TabIndex = 34;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 12;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(921, 195);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 50);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Xoá thông tin";
            this.btnClear.UseTransparentBackground = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.BorderRadius = 12;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.FillColor = System.Drawing.Color.LimeGreen;
            this.btnCreate.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(1050, 18);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(180, 45);
            this.btnCreate.TabIndex = 32;
            this.btnCreate.Text = "Thêm ca";
            this.btnCreate.UseTransparentBackground = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 12;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1249, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 45);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Xoá ca";
            this.btnDelete.UseTransparentBackground = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 12;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnEdit.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(1446, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 45);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.UseTransparentBackground = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(14, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Thông tin chi tiết ca làm việc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 88);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 6;
            // 
            // panelDataList
            // 
            this.panelDataList.BackColor = System.Drawing.Color.White;
            this.panelDataList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelDataList.BorderRadius = 16;
            this.panelDataList.BorderThickness = 1;
            this.panelDataList.Controls.Add(this.label11);
            this.panelDataList.Controls.Add(this.dg_calam);
            this.panelDataList.Location = new System.Drawing.Point(28, 443);
            this.panelDataList.Name = "panelDataList";
            this.panelDataList.Size = new System.Drawing.Size(1646, 544);
            this.panelDataList.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(14, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "Danh sách ca làm việc";
            // 
            // UC_ADMIN_WORKTIME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panelDataList);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ADMIN_WORKTIME";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.UC_QuanLyCaLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_calam)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelDataList.ResumeLayout(false);
            this.panelDataList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_calam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2Button btn_cancelSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel panelControl;
        private Guna.UI2.WinForms.Guna2TextBox textBoxTime;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxId;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Panel panelDataList;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_thoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_luong;
    }
}
