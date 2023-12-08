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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_nvien = new System.Windows.Forms.Button();
            this.btn_qly = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(779, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(442, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý quán cà phê";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_nvien
            // 
            this.btn_nvien.Location = new System.Drawing.Point(562, 350);
            this.btn_nvien.Name = "btn_nvien";
            this.btn_nvien.Size = new System.Drawing.Size(423, 343);
            this.btn_nvien.TabIndex = 1;
            this.btn_nvien.Text = "Nhân viên";
            this.btn_nvien.UseVisualStyleBackColor = true;
            this.btn_nvien.Click += new System.EventHandler(this.btn_nvien_Click);
            // 
            // btn_qly
            // 
            this.btn_qly.ForeColor = System.Drawing.Color.Red;
            this.btn_qly.Location = new System.Drawing.Point(1054, 350);
            this.btn_qly.Name = "btn_qly";
            this.btn_qly.Size = new System.Drawing.Size(431, 343);
            this.btn_qly.TabIndex = 2;
            this.btn_qly.Text = "Quản lý";
            this.btn_qly.UseVisualStyleBackColor = true;
            this.btn_qly.Click += new System.EventHandler(this.btn_qly_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(1730, 995);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(178, 73);
            this.btn_quit.TabIndex = 3;
            this.btn_quit.Text = "Thoát";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1921, 125);
            this.panel1.TabIndex = 4;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Green;
            this.lblQuestion.Location = new System.Drawing.Point(919, 250);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(169, 25);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Bạn có vai trò là:";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion.Click += new System.EventHandler(this.label1_Click);
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
            this.picLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form_Begin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_qly);
            this.Controls.Add(this.btn_nvien);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Begin";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Begin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn_nvien;
        private System.Windows.Forms.Button btn_qly;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

