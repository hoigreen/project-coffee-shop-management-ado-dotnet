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
            this.btn_tao_hoadon = new System.Windows.Forms.Button();
            this.btn_ban = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_staff_container
            // 
            this.panel_staff_container.Location = new System.Drawing.Point(214, 44);
            this.panel_staff_container.Name = "panel_staff_container";
            this.panel_staff_container.Size = new System.Drawing.Size(1000, 661);
            this.panel_staff_container.TabIndex = 0;
            // 
            // btn_tao_hoadon
            // 
            this.btn_tao_hoadon.Location = new System.Drawing.Point(38, 93);
            this.btn_tao_hoadon.Name = "btn_tao_hoadon";
            this.btn_tao_hoadon.Size = new System.Drawing.Size(170, 95);
            this.btn_tao_hoadon.TabIndex = 1;
            this.btn_tao_hoadon.Text = "Tạo hóa đơn";
            this.btn_tao_hoadon.UseVisualStyleBackColor = true;
            this.btn_tao_hoadon.Click += new System.EventHandler(this.btn_tao_hoadon_Click);
            // 
            // btn_ban
            // 
            this.btn_ban.Location = new System.Drawing.Point(38, 219);
            this.btn_ban.Name = "btn_ban";
            this.btn_ban.Size = new System.Drawing.Size(170, 95);
            this.btn_ban.TabIndex = 2;
            this.btn_ban.Text = "Bàn";
            this.btn_ban.UseVisualStyleBackColor = true;
            this.btn_ban.Click += new System.EventHandler(this.btn_ban_Click);
            // 
            // Form_Main_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.btn_ban);
            this.Controls.Add(this.btn_tao_hoadon);
            this.Controls.Add(this.panel_staff_container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main_Staff";
            this.Text = "Form_Main_Staff";
            this.Load += new System.EventHandler(this.Form_Main_Staff_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_staff_container;
        private System.Windows.Forms.Button btn_tao_hoadon;
        private System.Windows.Forms.Button btn_ban;
    }
}