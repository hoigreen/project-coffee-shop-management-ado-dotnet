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
            this.tb_maHD = new System.Windows.Forms.TextBox();
            this.tb_tenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_maNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_ngay = new System.Windows.Forms.DateTimePicker();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_locThang = new System.Windows.Forms.ComboBox();
            this.btn_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_chitiethoadon)).BeginInit();
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
            this.dg_hoadon.Location = new System.Drawing.Point(365, 70);
            this.dg_hoadon.Name = "dg_hoadon";
            this.dg_hoadon.Size = new System.Drawing.Size(771, 358);
            this.dg_hoadon.TabIndex = 0;
            // 
            // col_maHD
            // 
            this.col_maHD.HeaderText = "Mã hóa đơn";
            this.col_maHD.Name = "col_maHD";
            // 
            // col_ten
            // 
            this.col_ten.HeaderText = "Nhân viên thanh toán";
            this.col_ten.Name = "col_ten";
            this.col_ten.Width = 200;
            // 
            // col_maNV
            // 
            this.col_maNV.HeaderText = "Mã nhân viên";
            this.col_maNV.Name = "col_maNV";
            // 
            // col_ngay
            // 
            this.col_ngay.HeaderText = "Ngày thanh toán";
            this.col_ngay.Name = "col_ngay";
            this.col_ngay.Width = 200;
            // 
            // col_tong
            // 
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
            this.dg_chitiethoadon.Location = new System.Drawing.Point(553, 434);
            this.dg_chitiethoadon.Name = "dg_chitiethoadon";
            this.dg_chitiethoadon.Size = new System.Drawing.Size(583, 217);
            this.dg_chitiethoadon.TabIndex = 1;
            // 
            // col_maMon
            // 
            this.col_maMon.HeaderText = "Mã món ăn";
            this.col_maMon.Name = "col_maMon";
            // 
            // col_tenMon
            // 
            this.col_tenMon.HeaderText = "Tên món ăn";
            this.col_tenMon.Name = "col_tenMon";
            // 
            // col_soLuong
            // 
            this.col_soLuong.HeaderText = "Số lượng";
            this.col_soLuong.Name = "col_soLuong";
            // 
            // col_donGia
            // 
            this.col_donGia.HeaderText = "Đơn giá";
            this.col_donGia.Name = "col_donGia";
            // 
            // col_thanhTien
            // 
            this.col_thanhTien.HeaderText = "Thành tiền";
            this.col_thanhTien.Name = "col_thanhTien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hóa đơn";
            // 
            // tb_maHD
            // 
            this.tb_maHD.Location = new System.Drawing.Point(31, 53);
            this.tb_maHD.Name = "tb_maHD";
            this.tb_maHD.Size = new System.Drawing.Size(100, 20);
            this.tb_maHD.TabIndex = 3;
            // 
            // tb_tenNV
            // 
            this.tb_tenNV.Location = new System.Drawing.Point(31, 120);
            this.tb_tenNV.Name = "tb_tenNV";
            this.tb_tenNV.Size = new System.Drawing.Size(100, 20);
            this.tb_tenNV.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhân viên thanh toán";
            // 
            // tb_maNV
            // 
            this.tb_maNV.Location = new System.Drawing.Point(31, 192);
            this.tb_maNV.Name = "tb_maNV";
            this.tb_maNV.Size = new System.Drawing.Size(100, 20);
            this.tb_maNV.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày thanh toán";
            // 
            // tb_tong
            // 
            this.tb_tong.Location = new System.Drawing.Point(31, 318);
            this.tb_tong.Name = "tb_tong";
            this.tb_tong.Size = new System.Drawing.Size(100, 20);
            this.tb_tong.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng thanh toán";
            // 
            // dt_ngay
            // 
            this.dt_ngay.CustomFormat = "dd/MM/yyyy";
            this.dt_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngay.Location = new System.Drawing.Point(31, 268);
            this.dt_ngay.Name = "dt_ngay";
            this.dt_ngay.Size = new System.Drawing.Size(200, 20);
            this.dt_ngay.TabIndex = 12;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(56, 415);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(175, 23);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Xóa thông tin";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Theo tháng";
            // 
            // cb_locThang
            // 
            this.cb_locThang.FormattingEnabled = true;
            this.cb_locThang.Items.AddRange(new object[] {
            "--",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_locThang.Location = new System.Drawing.Point(446, 20);
            this.cb_locThang.Name = "cb_locThang";
            this.cb_locThang.Size = new System.Drawing.Size(121, 21);
            this.cb_locThang.TabIndex = 17;
            this.cb_locThang.SelectedIndexChanged += new System.EventHandler(this.cb_locThang_SelectedIndexChanged);
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(586, 20);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(75, 23);
            this.btn_all.TabIndex = 18;
            this.btn_all.Text = "Tất cả";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // UC_QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.cb_locThang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dt_ngay);
            this.Controls.Add(this.tb_tong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_maNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_tenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_maHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_chitiethoadon);
            this.Controls.Add(this.dg_hoadon);
            this.Name = "UC_QuanLyHoaDon";
            this.Size = new System.Drawing.Size(1163, 670);
            this.Load += new System.EventHandler(this.UC_QuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_chitiethoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_hoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tong;
        private System.Windows.Forms.DataGridView dg_chitiethoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_thanhTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_maHD;
        private System.Windows.Forms.TextBox tb_tenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_maNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_tong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_ngay;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_locThang;
        private System.Windows.Forms.Button btn_all;
    }
}
