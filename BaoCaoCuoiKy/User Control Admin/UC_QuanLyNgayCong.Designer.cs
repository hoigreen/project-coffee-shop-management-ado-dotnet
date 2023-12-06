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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_maCa = new System.Windows.Forms.TextBox();
            this.tb_tenCa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_maNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.dt_ngayLam = new System.Windows.Forms.DateTimePicker();
            this.cb_thang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_ca = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ngayCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_ngayCong
            // 
            this.dg_ngayCong.AllowUserToAddRows = false;
            this.dg_ngayCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ngayCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_maCa,
            this.col_tenCa,
            this.col_maNV,
            this.col_tenNV,
            this.col_ngay});
            this.dg_ngayCong.Location = new System.Drawing.Point(418, 114);
            this.dg_ngayCong.Name = "dg_ngayCong";
            this.dg_ngayCong.Size = new System.Drawing.Size(555, 362);
            this.dg_ngayCong.TabIndex = 0;
            // 
            // col_maCa
            // 
            this.col_maCa.HeaderText = "Mã ca";
            this.col_maCa.Name = "col_maCa";
            // 
            // col_tenCa
            // 
            this.col_tenCa.HeaderText = "Tên ca";
            this.col_tenCa.Name = "col_tenCa";
            // 
            // col_maNV
            // 
            this.col_maNV.HeaderText = "Mã nhân viên";
            this.col_maNV.Name = "col_maNV";
            // 
            // col_tenNV
            // 
            this.col_tenNV.HeaderText = "Tên nhân viên";
            this.col_tenNV.Name = "col_tenNV";
            // 
            // col_ngay
            // 
            this.col_ngay.HeaderText = "Ngày làm";
            this.col_ngay.Name = "col_ngay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã ca";
            // 
            // tb_maCa
            // 
            this.tb_maCa.Location = new System.Drawing.Point(92, 145);
            this.tb_maCa.Name = "tb_maCa";
            this.tb_maCa.Size = new System.Drawing.Size(100, 20);
            this.tb_maCa.TabIndex = 2;
            // 
            // tb_tenCa
            // 
            this.tb_tenCa.Location = new System.Drawing.Point(92, 219);
            this.tb_tenCa.Name = "tb_tenCa";
            this.tb_tenCa.Size = new System.Drawing.Size(100, 20);
            this.tb_tenCa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên ca";
            // 
            // tb_maNV
            // 
            this.tb_maNV.Location = new System.Drawing.Point(92, 293);
            this.tb_maNV.Name = "tb_maNV";
            this.tb_maNV.Size = new System.Drawing.Size(100, 20);
            this.tb_maNV.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã nhân viên";
            // 
            // tb_tenNV
            // 
            this.tb_tenNV.Location = new System.Drawing.Point(101, 371);
            this.tb_tenNV.Name = "tb_tenNV";
            this.tb_tenNV.Size = new System.Drawing.Size(100, 20);
            this.tb_tenNV.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày làm";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(92, 529);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(192, 23);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Xóa thông tin";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // dt_ngayLam
            // 
            this.dt_ngayLam.CustomFormat = "dd/MM/yyyy";
            this.dt_ngayLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngayLam.Location = new System.Drawing.Point(92, 456);
            this.dt_ngayLam.Name = "dt_ngayLam";
            this.dt_ngayLam.Size = new System.Drawing.Size(200, 20);
            this.dt_ngayLam.TabIndex = 12;
            // 
            // cb_thang
            // 
            this.cb_thang.FormattingEnabled = true;
            this.cb_thang.Location = new System.Drawing.Point(418, 49);
            this.cb_thang.Name = "cb_thang";
            this.cb_thang.Size = new System.Drawing.Size(121, 21);
            this.cb_thang.TabIndex = 13;
            this.cb_thang.SelectedIndexChanged += new System.EventHandler(this.cb_thang_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tháng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ca";
            // 
            // cb_ca
            // 
            this.cb_ca.FormattingEnabled = true;
            this.cb_ca.Location = new System.Drawing.Point(583, 49);
            this.cb_ca.Name = "cb_ca";
            this.cb_ca.Size = new System.Drawing.Size(254, 21);
            this.cb_ca.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Tất cả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_QuanLyNgayCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_ca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_thang);
            this.Controls.Add(this.dt_ngayLam);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_tenNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_maNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_tenCa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_maCa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_ngayCong);
            this.Name = "UC_QuanLyNgayCong";
            this.Size = new System.Drawing.Size(1163, 670);
            this.Load += new System.EventHandler(this.UC_QuanLyNgayCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ngayCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_ngayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tenCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_maCa;
        private System.Windows.Forms.TextBox tb_tenCa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_maNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tenNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DateTimePicker dt_ngayLam;
        private System.Windows.Forms.ComboBox cb_thang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_ca;
        private System.Windows.Forms.Button button1;
    }
}
