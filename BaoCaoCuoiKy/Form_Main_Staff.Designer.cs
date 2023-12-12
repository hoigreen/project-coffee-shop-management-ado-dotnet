namespace BaoCaoCuoiKy
{
    partial class Form_Main_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main_Staff));
            this.panel_staff_container = new System.Windows.Forms.Panel();
            this.btnExitWindow = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblLogoDescription = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMethodSidebar = new System.Windows.Forms.Label();
            this.btnList = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_staff_container
            // 
            this.panel_staff_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panel_staff_container.CausesValidation = false;
            this.panel_staff_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_staff_container.Location = new System.Drawing.Point(240, 71);
            this.panel_staff_container.Name = "panel_staff_container";
            this.panel_staff_container.Size = new System.Drawing.Size(1680, 1009);
            this.panel_staff_container.TabIndex = 0;
            // 
            // btnExitWindow
            // 
            this.btnExitWindow.Animated = true;
            this.btnExitWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnExitWindow.BorderColor = System.Drawing.Color.IndianRed;
            this.btnExitWindow.BorderRadius = 10;
            this.btnExitWindow.BorderThickness = 2;
            this.btnExitWindow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExitWindow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExitWindow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExitWindow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExitWindow.FillColor = System.Drawing.Color.Red;
            this.btnExitWindow.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnExitWindow.ForeColor = System.Drawing.Color.White;
            this.btnExitWindow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExitWindow.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExitWindow.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.btnExitWindow.Location = new System.Drawing.Point(1781, 14);
            this.btnExitWindow.Name = "btnExitWindow";
            this.btnExitWindow.Size = new System.Drawing.Size(125, 42);
            this.btnExitWindow.TabIndex = 6;
            this.btnExitWindow.Text = "Trở lại";
            this.btnExitWindow.UseTransparentBackground = true;
            this.btnExitWindow.Click += new System.EventHandler(this.btnExitWindow_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHeader.Controls.Add(this.lblLogoDescription);
            this.panelHeader.Controls.Add(this.lblLogo);
            this.panelHeader.Controls.Add(this.guna2PictureBox2);
            this.panelHeader.Controls.Add(this.btnExitWindow);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1920, 71);
            this.panelHeader.TabIndex = 7;
            // 
            // lblLogoDescription
            // 
            this.lblLogoDescription.AutoSize = true;
            this.lblLogoDescription.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoDescription.Location = new System.Drawing.Point(106, 38);
            this.lblLogoDescription.Name = "lblLogoDescription";
            this.lblLogoDescription.Size = new System.Drawing.Size(136, 18);
            this.lblLogoDescription.TabIndex = 8;
            this.lblLogoDescription.Text = "Dành cho nhân viên";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLogo.Location = new System.Drawing.Point(88, 14);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(154, 19);
            this.lblLogo.TabIndex = 7;
            this.lblLogo.Text = "Quản lý quán coffee";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.BorderRadius = 10;
            this.guna2PictureBox2.Image = global::CoffeeShopManagement.Properties.Resources.Simple_Coffee_Cup_Logo_Template_Download_on_Pngtree;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(-2, -2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(91, 71);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BorderColor = System.Drawing.Color.Silver;
            this.panelSidebar.BorderRadius = 10;
            this.panelSidebar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.panelSidebar.BorderThickness = 1;
            this.panelSidebar.Controls.Add(this.lblMethodSidebar);
            this.panelSidebar.Controls.Add(this.btnList);
            this.panelSidebar.Controls.Add(this.btnCreate);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 71);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(240, 1009);
            this.panelSidebar.TabIndex = 8;
            // 
            // lblMethodSidebar
            // 
            this.lblMethodSidebar.AutoSize = true;
            this.lblMethodSidebar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethodSidebar.ForeColor = System.Drawing.Color.Blue;
            this.lblMethodSidebar.Location = new System.Drawing.Point(12, 30);
            this.lblMethodSidebar.Name = "lblMethodSidebar";
            this.lblMethodSidebar.Size = new System.Drawing.Size(103, 23);
            this.lblMethodSidebar.TabIndex = 12;
            this.lblMethodSidebar.Text = "Chức năng";
            // 
            // btnList
            // 
            this.btnList.Animated = true;
            this.btnList.BorderColor = System.Drawing.Color.Transparent;
            this.btnList.BorderRadius = 10;
            this.btnList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnList.FillColor = System.Drawing.Color.Transparent;
            this.btnList.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnList.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnList.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnList.Location = new System.Drawing.Point(-3, 69);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(237, 73);
            this.btnList.TabIndex = 10;
            this.btnList.Text = "Danh sách bàn";
            this.btnList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnList.TextOffset = new System.Drawing.Point(10, 0);
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Animated = true;
            this.btnCreate.BorderColor = System.Drawing.Color.Transparent;
            this.btnCreate.BorderRadius = 10;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.FillColor = System.Drawing.Color.Transparent;
            this.btnCreate.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreate.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCreate.Location = new System.Drawing.Point(-3, 148);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(237, 69);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Tạo hoá đơn";
            this.btnCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCreate.TextOffset = new System.Drawing.Point(10, 0);
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Form_Main_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel_staff_container);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main_Staff";
            this.Text = "Quản lý quán coffee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Main_Staff_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_staff_container;
        private Guna.UI2.WinForms.Guna2Button btnExitWindow;
        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI2.WinForms.Guna2Panel panelSidebar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label lblLogoDescription;
        private System.Windows.Forms.Label lblLogo;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2Button btnList;
        private System.Windows.Forms.Label lblMethodSidebar;
    }
}