namespace BaoCaoCuoiKy.User_Control
{
    partial class UC_ADMIN_MENU
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
            this.dg_menu = new System.Windows.Forms.DataGridView();
            this.col_ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cancelSave = new Guna.UI2.WinForms.Guna2Button();
            this.panelControl = new Guna.UI2.WinForms.Guna2Panel();
            this.comboBoxType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textBoxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxId = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxSortByType = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_menu)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_menu
            // 
            this.dg_menu.AllowUserToAddRows = false;
            this.dg_menu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_menu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_menu.ColumnHeadersHeight = 40;
            this.dg_menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ma,
            this.col_ten,
            this.col_gia,
            this.col_loai});
            this.dg_menu.GridColor = System.Drawing.Color.Black;
            this.dg_menu.Location = new System.Drawing.Point(28, 498);
            this.dg_menu.Margin = new System.Windows.Forms.Padding(4);
            this.dg_menu.Name = "dg_menu";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_menu.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_menu.RowTemplate.Height = 32;
            this.dg_menu.Size = new System.Drawing.Size(1626, 474);
            this.dg_menu.TabIndex = 0;
            this.dg_menu.SelectionChanged += new System.EventHandler(this.DgMenu_SelectionChanged);
            // 
            // col_ma
            // 
            this.col_ma.HeaderText = "Mã Món";
            this.col_ma.Name = "col_ma";
            // 
            // col_ten
            // 
            this.col_ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_ten.HeaderText = "Tên";
            this.col_ten.Name = "col_ten";
            // 
            // col_gia
            // 
            this.col_gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_gia.HeaderText = "Đơn giá";
            this.col_gia.Name = "col_gia";
            // 
            // col_loai
            // 
            this.col_loai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_loai.HeaderText = "Danh mục";
            this.col_loai.Name = "col_loai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ THỰC ĐƠN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 448);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Lọc theo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(834, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã món";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(14, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Thông tin chi tiết của món";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1235, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Danh mục";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BorderRadius = 12;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.Green;
            this.btn_save.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(580, 195);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(140, 50);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseTransparentBackground = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancelSave
            // 
            this.btn_cancelSave.BorderRadius = 12;
            this.btn_cancelSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancelSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancelSave.FillColor = System.Drawing.Color.Sienna;
            this.btn_cancelSave.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelSave.ForeColor = System.Drawing.Color.White;
            this.btn_cancelSave.Location = new System.Drawing.Point(753, 195);
            this.btn_cancelSave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelSave.Name = "btn_cancelSave";
            this.btn_cancelSave.Size = new System.Drawing.Size(140, 50);
            this.btn_cancelSave.TabIndex = 21;
            this.btn_cancelSave.Text = "Không lưu";
            this.btn_cancelSave.Click += new System.EventHandler(this.btn_cancelSave_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.White;
            this.panelControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl.BorderRadius = 16;
            this.panelControl.BorderThickness = 1;
            this.panelControl.Controls.Add(this.comboBoxType);
            this.panelControl.Controls.Add(this.textBoxPrice);
            this.panelControl.Controls.Add(this.textBoxName);
            this.panelControl.Controls.Add(this.textBoxId);
            this.panelControl.Controls.Add(this.btnClear);
            this.panelControl.Controls.Add(this.btnCreate);
            this.panelControl.Controls.Add(this.btnDelete);
            this.panelControl.Controls.Add(this.btnEdit);
            this.panelControl.Controls.Add(this.btn_cancelSave);
            this.panelControl.Controls.Add(this.btn_save);
            this.panelControl.Controls.Add(this.label5);
            this.panelControl.Controls.Add(this.label7);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Controls.Add(this.label3);
            this.panelControl.Controls.Add(this.label4);
            this.panelControl.Location = new System.Drawing.Point(28, 149);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1626, 267);
            this.panelControl.TabIndex = 22;
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxType.BorderColor = System.Drawing.Color.Green;
            this.comboBoxType.BorderRadius = 10;
            this.comboBoxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxType.Font = new System.Drawing.Font("Roboto", 12F);
            this.comboBoxType.ForeColor = System.Drawing.Color.Black;
            this.comboBoxType.ItemHeight = 36;
            this.comboBoxType.Location = new System.Drawing.Point(1235, 113);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(380, 42);
            this.comboBoxType.TabIndex = 37;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BorderColor = System.Drawing.Color.Green;
            this.textBoxPrice.BorderRadius = 10;
            this.textBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPrice.DefaultText = "";
            this.textBoxPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPrice.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.ForeColor = System.Drawing.Color.Black;
            this.textBoxPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPrice.Location = new System.Drawing.Point(837, 113);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.PasswordChar = '\0';
            this.textBoxPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBoxPrice.PlaceholderText = "Nhập giá món ...";
            this.textBoxPrice.SelectedText = "";
            this.textBoxPrice.Size = new System.Drawing.Size(373, 43);
            this.textBoxPrice.TabIndex = 36;
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
            this.textBoxName.PlaceholderText = "Nhập tên món ...";
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
            this.textBoxId.PlaceholderText = "Nhập mã món ...";
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
            this.btnCreate.Location = new System.Drawing.Point(1039, 16);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(180, 45);
            this.btnCreate.TabIndex = 32;
            this.btnCreate.Text = "Thêm món";
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
            this.btnDelete.Location = new System.Drawing.Point(1238, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 45);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Xoá món";
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
            this.btnEdit.Location = new System.Drawing.Point(1435, 16);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 45);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.UseTransparentBackground = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // comboBoxSortByType
            // 
            this.comboBoxSortByType.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxSortByType.BorderColor = System.Drawing.Color.Green;
            this.comboBoxSortByType.BorderRadius = 10;
            this.comboBoxSortByType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSortByType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortByType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSortByType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSortByType.Font = new System.Drawing.Font("Roboto", 12F);
            this.comboBoxSortByType.ForeColor = System.Drawing.Color.Black;
            this.comboBoxSortByType.ItemHeight = 30;
            this.comboBoxSortByType.Location = new System.Drawing.Point(99, 439);
            this.comboBoxSortByType.Name = "comboBoxSortByType";
            this.comboBoxSortByType.Size = new System.Drawing.Size(380, 36);
            this.comboBoxSortByType.TabIndex = 38;
            this.comboBoxSortByType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortByType_SelectedIndexChanged);
            // 
            // UC_ADMIN_MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.comboBoxSortByType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_menu);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ADMIN_MENU";
            this.Padding = new System.Windows.Forms.Padding(16, 17, 16, 17);
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.UC_QuanLyMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_menu)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2Button btn_cancelSave;
        private Guna.UI2.WinForms.Guna2Panel panelControl;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2TextBox textBoxId;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxType;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPrice;
        private Guna.UI2.WinForms.Guna2TextBox textBoxName;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxSortByType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_loai;
    }
}
