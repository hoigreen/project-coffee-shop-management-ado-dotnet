namespace CoffeeShopManagement.User_Control_Staff
{
    partial class UC_STAFF_TABLE
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
            this.lblTitleEmpty = new System.Windows.Forms.Label();
            this.lblTitleFull = new System.Windows.Forms.Label();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CircleProgressBar2 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.panelListTable = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // lblTitleEmpty
            // 
            this.lblTitleEmpty.AutoSize = true;
            this.lblTitleEmpty.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleEmpty.Location = new System.Drawing.Point(826, 93);
            this.lblTitleEmpty.Name = "lblTitleEmpty";
            this.lblTitleEmpty.Size = new System.Drawing.Size(46, 18);
            this.lblTitleEmpty.TabIndex = 0;
            this.lblTitleEmpty.Text = "Trống";
            this.lblTitleEmpty.Click += new System.EventHandler(this.lbTitleEmpty_Click);
            // 
            // lblTitleFull
            // 
            this.lblTitleFull.AutoSize = true;
            this.lblTitleFull.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleFull.Location = new System.Drawing.Point(915, 93);
            this.lblTitleFull.Name = "lblTitleFull";
            this.lblTitleFull.Size = new System.Drawing.Size(69, 18);
            this.lblTitleFull.TabIndex = 2;
            this.lblTitleFull.Text = "Có người";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(752, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 27);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Thông tin danh sách bàn";
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.BackColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.ForestGreen;
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.Violet;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(787, 85);
            this.guna2CircleProgressBar1.Minimum = 0;
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(33, 33);
            this.guna2CircleProgressBar1.TabIndex = 4;
            this.guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            // 
            // guna2CircleProgressBar2
            // 
            this.guna2CircleProgressBar2.BackColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar2.FillColor = System.Drawing.Color.Red;
            this.guna2CircleProgressBar2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar2.ForeColor = System.Drawing.Color.Violet;
            this.guna2CircleProgressBar2.Location = new System.Drawing.Point(881, 85);
            this.guna2CircleProgressBar2.Minimum = 0;
            this.guna2CircleProgressBar2.Name = "guna2CircleProgressBar2";
            this.guna2CircleProgressBar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar2.Size = new System.Drawing.Size(33, 33);
            this.guna2CircleProgressBar2.TabIndex = 5;
            this.guna2CircleProgressBar2.Text = "guna2CircleProgressBar2";
            // 
            // panelListTable
            // 
            this.panelListTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelListTable.BorderRadius = 20;
            this.panelListTable.BorderThickness = 2;
            this.panelListTable.Location = new System.Drawing.Point(54, 139);
            this.panelListTable.Margin = new System.Windows.Forms.Padding(10);
            this.panelListTable.Name = "panelListTable";
            this.panelListTable.Padding = new System.Windows.Forms.Padding(10);
            this.panelListTable.Size = new System.Drawing.Size(1573, 817);
            this.panelListTable.TabIndex = 0;
            this.panelListTable.Paint += new System.Windows.Forms.PaintEventHandler(this.panelListTable_Paint);
            // 
            // UC_STAFF_TABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelListTable);
            this.Controls.Add(this.guna2CircleProgressBar2);
            this.Controls.Add(this.guna2CircleProgressBar1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTitleFull);
            this.Controls.Add(this.lblTitleEmpty);
            this.Name = "UC_STAFF_TABLE";
            this.Size = new System.Drawing.Size(1898, 1000);
            this.Load += new System.EventHandler(this.UC_STAFF_TABLE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitleFull;
        private System.Windows.Forms.Label lblTitleEmpty;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar2;
        private Guna.UI2.WinForms.Guna2Panel panelListTable;
    }
}
