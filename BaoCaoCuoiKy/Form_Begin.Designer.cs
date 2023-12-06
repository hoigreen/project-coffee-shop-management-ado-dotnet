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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nvien = new System.Windows.Forms.Button();
            this.btn_qly = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý quán cà phê";
            // 
            // btn_nvien
            // 
            this.btn_nvien.Location = new System.Drawing.Point(454, 315);
            this.btn_nvien.Name = "btn_nvien";
            this.btn_nvien.Size = new System.Drawing.Size(178, 73);
            this.btn_nvien.TabIndex = 1;
            this.btn_nvien.Text = "Nhân viên";
            this.btn_nvien.UseVisualStyleBackColor = true;
            this.btn_nvien.Click += new System.EventHandler(this.btn_nvien_Click);
            // 
            // btn_qly
            // 
            this.btn_qly.ForeColor = System.Drawing.Color.Red;
            this.btn_qly.Location = new System.Drawing.Point(766, 315);
            this.btn_qly.Name = "btn_qly";
            this.btn_qly.Size = new System.Drawing.Size(178, 73);
            this.btn_qly.TabIndex = 2;
            this.btn_qly.Text = "Quản lý";
            this.btn_qly.UseVisualStyleBackColor = true;
            this.btn_qly.Click += new System.EventHandler(this.btn_qly_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(597, 420);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(178, 73);
            this.btn_quit.TabIndex = 3;
            this.btn_quit.Text = "Thoát";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // Form_Begin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_qly);
            this.Controls.Add(this.btn_nvien);
            this.Controls.Add(this.label1);
            this.Name = "Form_Begin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Begin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nvien;
        private System.Windows.Forms.Button btn_qly;
        private System.Windows.Forms.Button btn_quit;
    }
}

