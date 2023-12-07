namespace BaoCaoCuoiKy.User_Control
{
    partial class UC_ADMIN_STAFF
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
            this.label1 = new System.Windows.Forms.Label();
            this.dg_nhanvien = new System.Windows.Forms.DataGridView();
            this.col_ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_dienthoai = new System.Windows.Forms.TextBox();
            this.tb_chucvu = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.dt_ngayvaolam = new System.Windows.Forms.DateTimePicker();
            this.dg_ngaycong = new System.Windows.Forms.DataGridView();
            this.col_maCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tenCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ngaycong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÂN VIÊN";
            // 
            // dg_nhanvien
            // 
            this.dg_nhanvien.AllowUserToAddRows = false;
            this.dg_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ma,
            this.col_ten,
            this.col_dt,
            this.col_gt,
            this.col_ns,
            this.col_cv,
            this.col_dc,
            this.col_nvl});
            this.dg_nhanvien.Location = new System.Drawing.Point(289, 26);
            this.dg_nhanvien.Name = "dg_nhanvien";
            this.dg_nhanvien.Size = new System.Drawing.Size(857, 312);
            this.dg_nhanvien.TabIndex = 1;
            // 
            // col_ma
            // 
            this.col_ma.HeaderText = "Mã ";
            this.col_ma.Name = "col_ma";
            // 
            // col_ten
            // 
            this.col_ten.HeaderText = "Họ Tên";
            this.col_ten.Name = "col_ten";
            // 
            // col_dt
            // 
            this.col_dt.HeaderText = "Điện Thoại";
            this.col_dt.Name = "col_dt";
            // 
            // col_gt
            // 
            this.col_gt.HeaderText = "Giới Tính";
            this.col_gt.Name = "col_gt";
            // 
            // col_ns
            // 
            this.col_ns.HeaderText = "Ngày Sinh";
            this.col_ns.Name = "col_ns";
            // 
            // col_cv
            // 
            this.col_cv.HeaderText = "Chức vụ";
            this.col_cv.Name = "col_cv";
            // 
            // col_dc
            // 
            this.col_dc.HeaderText = "Địa Chỉ";
            this.col_dc.Name = "col_dc";
            // 
            // col_nvl
            // 
            this.col_nvl.HeaderText = "Ngày vào làm";
            this.col_nvl.Name = "col_nvl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ĐIện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Chức vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 515);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ngày vào làm";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(17, 622);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(98, 622);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(198, 621);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(98, 586);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(116, 23);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Xóa thông tin";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(57, 97);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(100, 20);
            this.tb_ma.TabIndex = 14;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(57, 162);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(100, 20);
            this.tb_ten.TabIndex = 15;
            // 
            // tb_dienthoai
            // 
            this.tb_dienthoai.Location = new System.Drawing.Point(57, 220);
            this.tb_dienthoai.Name = "tb_dienthoai";
            this.tb_dienthoai.Size = new System.Drawing.Size(100, 20);
            this.tb_dienthoai.TabIndex = 16;
            // 
            // tb_chucvu
            // 
            this.tb_chucvu.Location = new System.Drawing.Point(57, 402);
            this.tb_chucvu.Name = "tb_chucvu";
            this.tb_chucvu.Size = new System.Drawing.Size(100, 20);
            this.tb_chucvu.TabIndex = 17;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(66, 468);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(100, 20);
            this.tb_diachi.TabIndex = 18;
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Location = new System.Drawing.Point(57, 287);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(121, 21);
            this.cb_gioitinh.TabIndex = 19;
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dt_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaysinh.Location = new System.Drawing.Point(57, 342);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(200, 20);
            this.dt_ngaysinh.TabIndex = 20;
            // 
            // dt_ngayvaolam
            // 
            this.dt_ngayvaolam.CustomFormat = "dd/MM/yyyy";
            this.dt_ngayvaolam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngayvaolam.Location = new System.Drawing.Point(48, 548);
            this.dt_ngayvaolam.Name = "dt_ngayvaolam";
            this.dt_ngayvaolam.Size = new System.Drawing.Size(200, 20);
            this.dt_ngayvaolam.TabIndex = 21;
            // 
            // dg_ngaycong
            // 
            this.dg_ngaycong.AllowUserToAddRows = false;
            this.dg_ngaycong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ngaycong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_maCa,
            this.col_tenCa,
            this.col_ngayLam});
            this.dg_ngaycong.Location = new System.Drawing.Point(488, 376);
            this.dg_ngaycong.Name = "dg_ngaycong";
            this.dg_ngaycong.Size = new System.Drawing.Size(380, 247);
            this.dg_ngaycong.TabIndex = 22;
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
            // col_ngayLam
            // 
            this.col_ngayLam.HeaderText = "Ngày làm";
            this.col_ngayLam.Name = "col_ngayLam";
            // 
            // UC_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dg_ngaycong);
            this.Controls.Add(this.dt_ngayvaolam);
            this.Controls.Add(this.dt_ngaysinh);
            this.Controls.Add(this.cb_gioitinh);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.tb_chucvu);
            this.Controls.Add(this.tb_dienthoai);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_nhanvien);
            this.Controls.Add(this.label1);
            this.Name = "UC_QuanLyNhanVien";
            this.Size = new System.Drawing.Size(1163, 670);
            this.Load += new System.EventHandler(this.UC_QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ngaycong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_nhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_dienthoai;
        private System.Windows.Forms.TextBox tb_chucvu;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.DateTimePicker dt_ngayvaolam;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ns;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nvl;
        private System.Windows.Forms.DataGridView dg_ngaycong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tenCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngayLam;
    }
}
