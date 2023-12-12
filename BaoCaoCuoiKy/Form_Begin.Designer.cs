namespace BaoCaoCuoiKy
{
    partial class Form_Begin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Begin));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnExitWindow = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewStaff = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnViewAdmin = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(653, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(643, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý quán cà phê Tình Bạn";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1921, 125);
            this.panel1.TabIndex = 4;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::CoffeeShopManagement.Properties.Resources.Simple_Coffee_Cup_Logo_Template_Download_on_Pngtree;
            this.picLogo.InitialImage = global::CoffeeShopManagement.Properties.Resources.Simple_Coffee_Cup_Logo_Template_Download_on_Pngtree;
            this.picLogo.Location = new System.Drawing.Point(0, -3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(137, 128);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Green;
            this.lblQuestion.Location = new System.Drawing.Point(906, 295);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(184, 25);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "VAI TRÒ CỦA BẠN";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitWindow
            // 
            this.btnExitWindow.Animated = true;
            this.btnExitWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnExitWindow.BorderColor = System.Drawing.Color.IndianRed;
            this.btnExitWindow.BorderRadius = 12;
            this.btnExitWindow.BorderThickness = 1;
            this.btnExitWindow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExitWindow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExitWindow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExitWindow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExitWindow.FillColor = System.Drawing.Color.Red;
            this.btnExitWindow.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitWindow.ForeColor = System.Drawing.Color.White;
            this.btnExitWindow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExitWindow.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExitWindow.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.btnExitWindow.Location = new System.Drawing.Point(1716, 1019);
            this.btnExitWindow.Name = "btnExitWindow";
            this.btnExitWindow.Size = new System.Drawing.Size(192, 49);
            this.btnExitWindow.TabIndex = 10;
            this.btnExitWindow.Text = "Thoát hệ thống";
            this.btnExitWindow.Click += new System.EventHandler(this.btnExitWindow_Click);
            // 
            // btnViewStaff
            // 
            this.btnViewStaff.BorderColor = System.Drawing.Color.Transparent;
            this.btnViewStaff.BorderRadius = 40;
            this.btnViewStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewStaff.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(248)))));
            this.btnViewStaff.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(131)))), ((int)(((byte)(248)))));
            this.btnViewStaff.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStaff.ForeColor = System.Drawing.Color.White;
            this.btnViewStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnViewStaff.Image")));
            this.btnViewStaff.ImageSize = new System.Drawing.Size(140, 140);
            this.btnViewStaff.Location = new System.Drawing.Point(508, 389);
            this.btnViewStaff.Name = "btnViewStaff";
            this.btnViewStaff.Size = new System.Drawing.Size(423, 343);
            this.btnViewStaff.TabIndex = 6;
            this.btnViewStaff.Text = "Nhân viên";
            this.btnViewStaff.Click += new System.EventHandler(this.btnViewStaff_Click);
            // 
            // btnViewAdmin
            // 
            this.btnViewAdmin.BorderColor = System.Drawing.Color.Transparent;
            this.btnViewAdmin.BorderRadius = 40;
            this.btnViewAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewAdmin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.btnViewAdmin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(159)))), ((int)(((byte)(110)))));
            this.btnViewAdmin.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAdmin.ForeColor = System.Drawing.Color.White;
            this.btnViewAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnViewAdmin.Image")));
            this.btnViewAdmin.ImageSize = new System.Drawing.Size(140, 140);
            this.btnViewAdmin.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.btnViewAdmin.Location = new System.Drawing.Point(1061, 389);
            this.btnViewAdmin.Name = "btnViewAdmin";
            this.btnViewAdmin.Size = new System.Drawing.Size(423, 343);
            this.btnViewAdmin.TabIndex = 7;
            this.btnViewAdmin.Text = "Quản trị viên";
            this.btnViewAdmin.Click += new System.EventHandler(this.btnViewAdmin_Click);
            // 
            // Form_Begin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnViewAdmin);
            this.Controls.Add(this.btnViewStaff);
            this.Controls.Add(this.btnExitWindow);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Begin";
            this.Text = "Coffee Management CMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2Button btnExitWindow;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnViewStaff;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnViewAdmin;
    }
}

