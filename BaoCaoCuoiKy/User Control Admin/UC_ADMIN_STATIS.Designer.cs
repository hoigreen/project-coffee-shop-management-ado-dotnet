namespace BaoCaoCuoiKy.User_Control_Admin
{
    partial class UC_ADMIN_STATIS
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_thongke)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_nhanvien);
            this.groupBox1.Location = new System.Drawing.Point(435, 383);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(374, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số lượng nhân viên";
            // 
            // lb_nhanvien
            // 
            this.lb_nhanvien.AutoSize = true;
            this.lb_nhanvien.Location = new System.Drawing.Point(119, 82);
            this.lb_nhanvien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nhanvien.Name = "lb_nhanvien";
            this.lb_nhanvien.Size = new System.Drawing.Size(48, 18);
            this.lb_nhanvien.TabIndex = 0;
            this.lb_nhanvien.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_menu);
            this.groupBox2.Location = new System.Drawing.Point(857, 383);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(374, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số lượng món ăn";
            // 
            // lb_menu
            // 
            this.lb_menu.AutoSize = true;
            this.lb_menu.Location = new System.Drawing.Point(119, 82);
            this.lb_menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_menu.Name = "lb_menu";
            this.lb_menu.Size = new System.Drawing.Size(48, 18);
            this.lb_menu.TabIndex = 0;
            this.lb_menu.Text = "label2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_hoadon);
            this.groupBox3.Location = new System.Drawing.Point(1281, 383);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(370, 173);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng hóa đơn";
            // 
            // lb_hoadon
            // 
            this.lb_hoadon.AutoSize = true;
            this.lb_hoadon.Location = new System.Drawing.Point(119, 82);
            this.lb_hoadon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_hoadon.Name = "lb_hoadon";
            this.lb_hoadon.Size = new System.Drawing.Size(48, 18);
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
            this.dg_thongke.Location = new System.Drawing.Point(52, 612);
            this.dg_thongke.Margin = new System.Windows.Forms.Padding(4);
            this.dg_thongke.Name = "dg_thongke";
            this.dg_thongke.Size = new System.Drawing.Size(864, 317);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "TRANG THỐNG KÊ";
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(248)))));
            this.guna2GradientPanel3.Location = new System.Drawing.Point(857, 136);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.Size = new System.Drawing.Size(374, 226);
            this.guna2GradientPanel3.TabIndex = 9;
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.guna2GradientPanel4.Location = new System.Drawing.Point(1281, 136);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.Size = new System.Drawing.Size(370, 226);
            this.guna2GradientPanel4.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(22, 383);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(374, 173);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Số lượng nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(76)))));
            this.guna2GradientPanel2.BorderRadius = 10;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(435, 136);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(374, 226);
            this.guna2GradientPanel2.TabIndex = 8;
            // 
            // UC_ADMIN_STATIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.guna2GradientPanel4);
            this.Controls.Add(this.guna2GradientPanel3);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_thongke);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ADMIN_STATIS";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.UC_QuanLyThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_thongke)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
    }
}
