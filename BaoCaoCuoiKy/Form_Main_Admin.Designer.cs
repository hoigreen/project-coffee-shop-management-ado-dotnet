using System.Drawing;

namespace BaoCaoCuoiKy
{
    partial class Form_Main_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main_Admin));
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel_container = new System.Windows.Forms.Panel();
            this.btn_qly_menu = new System.Windows.Forms.Button();
            this.btn_qly_nhanvien = new System.Windows.Forms.Button();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.btn_qly_hoadon = new System.Windows.Forms.Button();
            this.btn_qly_ngaycong = new System.Windows.Forms.Button();
            this.btn_qly_calam = new System.Windows.Forms.Button();
            this.lb_ma_admin = new System.Windows.Forms.Label();
            this.lb_name_admin = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_nav.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Red;
            this.btn_logout.Location = new System.Drawing.Point(1193, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_logout.Size = new System.Drawing.Size(179, 53);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Đăng xuất";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_container
            // 
            this.panel_container.Location = new System.Drawing.Point(220, 90);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1163, 670);
            this.panel_container.TabIndex = 6;
            // 
            // btn_qly_menu
            // 
            this.btn_qly_menu.Location = new System.Drawing.Point(0, 0);
            this.btn_qly_menu.Name = "btn_qly_menu";
            this.btn_qly_menu.Size = new System.Drawing.Size(220, 80);
            this.btn_qly_menu.TabIndex = 7;
            this.btn_qly_menu.Text = "Quản lý Menu";
            this.btn_qly_menu.UseVisualStyleBackColor = true;
            this.btn_qly_menu.Click += new System.EventHandler(this.btn_qly_menu_Click);
            // 
            // btn_qly_nhanvien
            // 
            this.btn_qly_nhanvien.Location = new System.Drawing.Point(0, 80);
            this.btn_qly_nhanvien.Name = "btn_qly_nhanvien";
            this.btn_qly_nhanvien.Size = new System.Drawing.Size(220, 80);
            this.btn_qly_nhanvien.TabIndex = 8;
            this.btn_qly_nhanvien.Text = "Quản lý nhân viên";
            this.btn_qly_nhanvien.UseVisualStyleBackColor = true;
            this.btn_qly_nhanvien.Click += new System.EventHandler(this.btn_qly_nhanvien_Click);
            // 
            // panel_nav
            // 
            this.panel_nav.Controls.Add(this.btn_thongke);
            this.panel_nav.Controls.Add(this.btn_qly_hoadon);
            this.panel_nav.Controls.Add(this.btn_qly_ngaycong);
            this.panel_nav.Controls.Add(this.btn_qly_calam);
            this.panel_nav.Controls.Add(this.btn_qly_nhanvien);
            this.panel_nav.Controls.Add(this.btn_qly_menu);
            this.panel_nav.Location = new System.Drawing.Point(0, 90);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(220, 670);
            this.panel_nav.TabIndex = 7;
            // 
            // btn_thongke
            // 
            this.btn_thongke.Location = new System.Drawing.Point(0, 400);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(220, 80);
            this.btn_thongke.TabIndex = 12;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // btn_qly_hoadon
            // 
            this.btn_qly_hoadon.Location = new System.Drawing.Point(0, 320);
            this.btn_qly_hoadon.Name = "btn_qly_hoadon";
            this.btn_qly_hoadon.Size = new System.Drawing.Size(220, 80);
            this.btn_qly_hoadon.TabIndex = 11;
            this.btn_qly_hoadon.Text = "Quản lý hóa đơn";
            this.btn_qly_hoadon.UseVisualStyleBackColor = true;
            this.btn_qly_hoadon.Click += new System.EventHandler(this.btn_qly_hoadon_Click);
            // 
            // btn_qly_ngaycong
            // 
            this.btn_qly_ngaycong.Location = new System.Drawing.Point(0, 240);
            this.btn_qly_ngaycong.Name = "btn_qly_ngaycong";
            this.btn_qly_ngaycong.Size = new System.Drawing.Size(220, 80);
            this.btn_qly_ngaycong.TabIndex = 10;
            this.btn_qly_ngaycong.Text = "Quản lý ngày công";
            this.btn_qly_ngaycong.UseVisualStyleBackColor = true;
            this.btn_qly_ngaycong.Click += new System.EventHandler(this.btn_qly_ngaycong_Click);
            // 
            // btn_qly_calam
            // 
            this.btn_qly_calam.Location = new System.Drawing.Point(0, 160);
            this.btn_qly_calam.Name = "btn_qly_calam";
            this.btn_qly_calam.Size = new System.Drawing.Size(220, 80);
            this.btn_qly_calam.TabIndex = 9;
            this.btn_qly_calam.Text = "Quản lý ca làm";
            this.btn_qly_calam.UseVisualStyleBackColor = true;
            this.btn_qly_calam.Click += new System.EventHandler(this.btn_qly_calam_Click);
            // 
            // lb_ma_admin
            // 
            this.lb_ma_admin.AutoSize = true;
            this.lb_ma_admin.Location = new System.Drawing.Point(15, 32);
            this.lb_ma_admin.Name = "lb_ma_admin";
            this.lb_ma_admin.Size = new System.Drawing.Size(50, 13);
            this.lb_ma_admin.TabIndex = 2;
            this.lb_ma_admin.Text = "maAdmin";
            // 
            // lb_name_admin
            // 
            this.lb_name_admin.AutoSize = true;
            this.lb_name_admin.Location = new System.Drawing.Point(71, 32);
            this.lb_name_admin.Name = "lb_name_admin";
            this.lb_name_admin.Size = new System.Drawing.Size(62, 13);
            this.lb_name_admin.TabIndex = 3;
            this.lb_name_admin.Text = "nameAdmin";
            // 
            // panel_header
            // 
            this.panel_header.Controls.Add(this.lb_ma_admin);
            this.panel_header.Controls.Add(this.btn_logout);
            this.panel_header.Controls.Add(this.lb_name_admin);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1383, 90);
            this.panel_header.TabIndex = 8;
            // 
            // Form_Main_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_nav);
            this.Controls.Add(this.panel_container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Main_Admin";
            this.Load += new System.EventHandler(this.Form_Main_Admin_Load);
            this.panel_nav.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Button btn_qly_menu;
        private System.Windows.Forms.Button btn_qly_nhanvien;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Label lb_ma_admin;
        private System.Windows.Forms.Label lb_name_admin;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button btn_qly_calam;
        private System.Windows.Forms.Button btn_qly_ngaycong;
        private System.Windows.Forms.Button btn_qly_hoadon;
        private System.Windows.Forms.Button btn_thongke;
    }
}