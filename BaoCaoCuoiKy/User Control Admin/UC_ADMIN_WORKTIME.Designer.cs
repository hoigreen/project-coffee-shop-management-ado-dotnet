namespace BaoCaoCuoiKy.User_Control
{
    partial class UC_ADMIN_WORKTIME
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
            this.dg_calam = new System.Windows.Forms.DataGridView();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_thoigian = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.col_ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_luong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_calam)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_calam
            // 
            this.dg_calam.AllowUserToAddRows = false;
            this.dg_calam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_calam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ma,
            this.col_ten,
            this.col_thoigian,
            this.col_luong});
            this.dg_calam.Location = new System.Drawing.Point(252, 80);
            this.dg_calam.Name = "dg_calam";
            this.dg_calam.Size = new System.Drawing.Size(449, 296);
            this.dg_calam.TabIndex = 0;
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(67, 121);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(100, 20);
            this.tb_ma.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã ca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên ca";
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(67, 206);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(100, 20);
            this.tb_ten.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thời gian";
            // 
            // tb_thoigian
            // 
            this.tb_thoigian.Location = new System.Drawing.Point(70, 283);
            this.tb_thoigian.Name = "tb_thoigian";
            this.tb_thoigian.Size = new System.Drawing.Size(100, 20);
            this.tb_thoigian.TabIndex = 5;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(76, 410);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Xóa thông tin";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(36, 482);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(149, 482);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(278, 494);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // col_ma
            // 
            this.col_ma.HeaderText = "Mã ca";
            this.col_ma.Name = "col_ma";
            // 
            // col_ten
            // 
            this.col_ten.HeaderText = "Tên ca";
            this.col_ten.Name = "col_ten";
            // 
            // col_thoigian
            // 
            this.col_thoigian.HeaderText = "Thời gian";
            this.col_thoigian.Name = "col_thoigian";
            // 
            // col_luong
            // 
            this.col_luong.HeaderText = "Lương";
            this.col_luong.Name = "col_luong";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lương";
            // 
            // tb_luong
            // 
            this.tb_luong.Location = new System.Drawing.Point(70, 366);
            this.tb_luong.Name = "tb_luong";
            this.tb_luong.Size = new System.Drawing.Size(100, 20);
            this.tb_luong.TabIndex = 11;
            // 
            // UC_QuanLyCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_luong);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_thoigian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.dg_calam);
            this.Name = "UC_QuanLyCaLam";
            this.Size = new System.Drawing.Size(1163, 670);
            this.Load += new System.EventHandler(this.UC_QuanLyCaLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_calam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_calam;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_thoigian;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_thoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_luong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_luong;
    }
}
