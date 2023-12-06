namespace BaoCaoCuoiKy.User_Control
{
    partial class UC_QuanLyMenu
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
            this.dg_menu = new System.Windows.Forms.DataGridView();
            this.col_ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radio_all = new System.Windows.Forms.RadioButton();
            this.radio_drink = new System.Windows.Forms.RadioButton();
            this.radio_food = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cb_loai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_menu
            // 
            this.dg_menu.AllowUserToAddRows = false;
            this.dg_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ma,
            this.col_ten,
            this.col_gia,
            this.col_loai});
            this.dg_menu.Location = new System.Drawing.Point(348, 70);
            this.dg_menu.Name = "dg_menu";
            this.dg_menu.Size = new System.Drawing.Size(790, 583);
            this.dg_menu.TabIndex = 0;
            // 
            // col_ma
            // 
            this.col_ma.HeaderText = "Mã Món";
            this.col_ma.Name = "col_ma";
            // 
            // col_ten
            // 
            this.col_ten.HeaderText = "Tên";
            this.col_ten.Name = "col_ten";
            this.col_ten.Width = 200;
            // 
            // col_gia
            // 
            this.col_gia.HeaderText = "Đơn giá";
            this.col_gia.Name = "col_gia";
            this.col_gia.Width = 150;
            // 
            // col_loai
            // 
            this.col_loai.HeaderText = "Loại";
            this.col_loai.Name = "col_loai";
            // 
            // radio_all
            // 
            this.radio_all.AutoSize = true;
            this.radio_all.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.radio_all.Location = new System.Drawing.Point(594, 32);
            this.radio_all.Name = "radio_all";
            this.radio_all.Size = new System.Drawing.Size(85, 28);
            this.radio_all.TabIndex = 1;
            this.radio_all.TabStop = true;
            this.radio_all.Text = "Tất cả";
            this.radio_all.UseVisualStyleBackColor = true;
            this.radio_all.CheckedChanged += new System.EventHandler(this.radio_all_CheckedChanged);
            // 
            // radio_drink
            // 
            this.radio_drink.AutoSize = true;
            this.radio_drink.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.radio_drink.Location = new System.Drawing.Point(684, 32);
            this.radio_drink.Name = "radio_drink";
            this.radio_drink.Size = new System.Drawing.Size(127, 28);
            this.radio_drink.TabIndex = 3;
            this.radio_drink.TabStop = true;
            this.radio_drink.Text = "Nước uống";
            this.radio_drink.UseVisualStyleBackColor = true;
            this.radio_drink.CheckedChanged += new System.EventHandler(this.radio_drink_CheckedChanged);
            // 
            // radio_food
            // 
            this.radio_food.AutoSize = true;
            this.radio_food.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_food.Location = new System.Drawing.Point(844, 32);
            this.radio_food.Name = "radio_food";
            this.radio_food.Size = new System.Drawing.Size(81, 28);
            this.radio_food.TabIndex = 4;
            this.radio_food.TabStop = true;
            this.radio_food.Text = "Đồ ăn";
            this.radio_food.UseVisualStyleBackColor = true;
            this.radio_food.CheckedChanged += new System.EventHandler(this.radio_food_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "MENU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Loại";
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(36, 138);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(238, 20);
            this.tb_ma.TabIndex = 10;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(36, 207);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(238, 20);
            this.tb_ten.TabIndex = 11;
            // 
            // tb_gia
            // 
            this.tb_gia.Location = new System.Drawing.Point(36, 271);
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.Size = new System.Drawing.Size(238, 20);
            this.tb_gia.TabIndex = 12;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(16, 504);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 14;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(116, 504);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(221, 504);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 56);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(36, 418);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(155, 23);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "Xóa thông tin";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // cb_loai
            // 
            this.cb_loai.FormattingEnabled = true;
            this.cb_loai.Location = new System.Drawing.Point(36, 338);
            this.cb_loai.Name = "cb_loai";
            this.cb_loai.Size = new System.Drawing.Size(238, 21);
            this.cb_loai.TabIndex = 18;
            // 
            // UC_QuanLyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cb_loai);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.tb_gia);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio_food);
            this.Controls.Add(this.radio_drink);
            this.Controls.Add(this.radio_all);
            this.Controls.Add(this.dg_menu);
            this.Name = "UC_QuanLyMenu";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.Size = new System.Drawing.Size(1163, 670);
            this.Load += new System.EventHandler(this.UC_QuanLyMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_loai;
        private System.Windows.Forms.RadioButton radio_all;
        private System.Windows.Forms.RadioButton radio_drink;
        private System.Windows.Forms.RadioButton radio_food;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_gia;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cb_loai;
    }
}
