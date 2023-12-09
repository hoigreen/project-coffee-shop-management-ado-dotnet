namespace BaoCaoCuoiKy
{
    partial class Form_Login_Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login_Admin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_loign_maNV = new System.Windows.Forms.TextBox();
            this.tb_login_mk = new System.Windows.Forms.TextBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Quản Lý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // tb_loign_maNV
            // 
            this.tb_loign_maNV.Location = new System.Drawing.Point(224, 121);
            this.tb_loign_maNV.Name = "tb_loign_maNV";
            this.tb_loign_maNV.Size = new System.Drawing.Size(100, 20);
            this.tb_loign_maNV.TabIndex = 2;
            this.tb_loign_maNV.Text = "ADMIN01";
            // 
            // tb_login_mk
            // 
            this.tb_login_mk.Location = new System.Drawing.Point(224, 213);
            this.tb_login_mk.Name = "tb_login_mk";
            this.tb_login_mk.Size = new System.Drawing.Size(100, 20);
            this.tb_login_mk.TabIndex = 3;
            this.tb_login_mk.Text = "123456";
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(224, 290);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 4;
            this.btn_huy.Text = "Thoát";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(346, 290);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Login_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.tb_login_mk);
            this.Controls.Add(this.tb_loign_maNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login_Admin";
            this.Text = "Đăng nhập dành cho Quản trị viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_loign_maNV;
        private System.Windows.Forms.TextBox tb_login_mk;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_login;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}