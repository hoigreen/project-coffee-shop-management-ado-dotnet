namespace BaoCaoCuoiKy.User_Control_Admin
{
    partial class UC_QuanLyThongKe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_nhanvien = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_menu = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_hoadon = new System.Windows.Forms.Label();
            this.dg_thongke = new System.Windows.Forms.DataGridView();
            this.col_thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tongDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tongthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_thongke)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_nhanvien);
            this.groupBox1.Location = new System.Drawing.Point(39, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số lượng nhân viên";
            // 
            // lb_nhanvien
            // 
            this.lb_nhanvien.AutoSize = true;
            this.lb_nhanvien.Location = new System.Drawing.Point(89, 59);
            this.lb_nhanvien.Name = "lb_nhanvien";
            this.lb_nhanvien.Size = new System.Drawing.Size(35, 13);
            this.lb_nhanvien.TabIndex = 0;
            this.lb_nhanvien.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_menu);
            this.groupBox2.Location = new System.Drawing.Point(322, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số lượng món ăn";
            // 
            // lb_menu
            // 
            this.lb_menu.AutoSize = true;
            this.lb_menu.Location = new System.Drawing.Point(89, 59);
            this.lb_menu.Name = "lb_menu";
            this.lb_menu.Size = new System.Drawing.Size(35, 13);
            this.lb_menu.TabIndex = 0;
            this.lb_menu.Text = "label2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_hoadon);
            this.groupBox3.Location = new System.Drawing.Point(601, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 125);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng hóa đơn";
            // 
            // lb_hoadon
            // 
            this.lb_hoadon.AutoSize = true;
            this.lb_hoadon.Location = new System.Drawing.Point(89, 59);
            this.lb_hoadon.Name = "lb_hoadon";
            this.lb_hoadon.Size = new System.Drawing.Size(35, 13);
            this.lb_hoadon.TabIndex = 0;
            this.lb_hoadon.Text = "label3";
            // 
            // dg_thongke
            // 
            this.dg_thongke.AllowUserToAddRows = false;
            this.dg_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_thongke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_thang,
            this.col_nam,
            this.col_tongDon,
            this.col_tongthu});
            this.dg_thongke.Location = new System.Drawing.Point(59, 216);
            this.dg_thongke.Name = "dg_thongke";
            this.dg_thongke.Size = new System.Drawing.Size(648, 229);
            this.dg_thongke.TabIndex = 2;
            // 
            // col_thang
            // 
            this.col_thang.HeaderText = "Tháng";
            this.col_thang.Name = "col_thang";
            // 
            // col_nam
            // 
            this.col_nam.HeaderText = "Năm";
            this.col_nam.Name = "col_nam";
            // 
            // col_tongDon
            // 
            this.col_tongDon.HeaderText = "Tổng hóa đơn";
            this.col_tongDon.Name = "col_tongDon";
            // 
            // col_tongthu
            // 
            this.col_tongthu.HeaderText = "Doanh thu";
            this.col_tongthu.Name = "col_tongthu";
            // 
            // UC_QuanLyThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dg_thongke);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_QuanLyThongKe";
            this.Size = new System.Drawing.Size(1163, 670);
            this.Load += new System.EventHandler(this.UC_QuanLyThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_thongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_nhanvien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_menu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_hoadon;
        private System.Windows.Forms.DataGridView dg_thongke;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tongDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tongthu;
    }
}
