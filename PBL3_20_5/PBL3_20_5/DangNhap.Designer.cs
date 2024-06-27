namespace PBL3_20_5
{
    partial class DangNhap
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
            this.t_TaiKhoan = new System.Windows.Forms.TextBox();
            this.t_MatKhau = new System.Windows.Forms.TextBox();
            this.l_TaiKhoan = new System.Windows.Forms.Label();
            this.b_DangKy = new System.Windows.Forms.Button();
            this.b_DangNhap = new System.Windows.Forms.Button();
            this.b_QMK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l_MatKhau = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // t_TaiKhoan
            // 
            this.t_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_TaiKhoan.Location = new System.Drawing.Point(321, 304);
            this.t_TaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.t_TaiKhoan.Name = "t_TaiKhoan";
            this.t_TaiKhoan.Size = new System.Drawing.Size(357, 35);
            this.t_TaiKhoan.TabIndex = 0;
            // 
            // t_MatKhau
            // 
            this.t_MatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_MatKhau.Location = new System.Drawing.Point(321, 363);
            this.t_MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.t_MatKhau.Name = "t_MatKhau";
            this.t_MatKhau.PasswordChar = '*';
            this.t_MatKhau.Size = new System.Drawing.Size(357, 35);
            this.t_MatKhau.TabIndex = 1;
            // 
            // l_TaiKhoan
            // 
            this.l_TaiKhoan.AutoSize = true;
            this.l_TaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.l_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TaiKhoan.Location = new System.Drawing.Point(136, 307);
            this.l_TaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_TaiKhoan.Name = "l_TaiKhoan";
            this.l_TaiKhoan.Size = new System.Drawing.Size(144, 27);
            this.l_TaiKhoan.TabIndex = 2;
            this.l_TaiKhoan.Text = "Tên tài khoản";
            // 
            // b_DangKy
            // 
            this.b_DangKy.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_DangKy.Location = new System.Drawing.Point(141, 414);
            this.b_DangKy.Margin = new System.Windows.Forms.Padding(4);
            this.b_DangKy.Name = "b_DangKy";
            this.b_DangKy.Size = new System.Drawing.Size(143, 52);
            this.b_DangKy.TabIndex = 4;
            this.b_DangKy.Text = "Đăng ký";
            this.b_DangKy.UseVisualStyleBackColor = true;
            this.b_DangKy.Click += new System.EventHandler(this.b_DangKy_Click);
            // 
            // b_DangNhap
            // 
            this.b_DangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_DangNhap.Location = new System.Drawing.Point(321, 414);
            this.b_DangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.b_DangNhap.Name = "b_DangNhap";
            this.b_DangNhap.Size = new System.Drawing.Size(143, 52);
            this.b_DangNhap.TabIndex = 5;
            this.b_DangNhap.Text = "Đăng nhập";
            this.b_DangNhap.UseVisualStyleBackColor = true;
            this.b_DangNhap.Click += new System.EventHandler(this.b_DangNhap_Click);
            // 
            // b_QMK
            // 
            this.b_QMK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_QMK.Location = new System.Drawing.Point(501, 414);
            this.b_QMK.Margin = new System.Windows.Forms.Padding(4);
            this.b_QMK.Name = "b_QMK";
            this.b_QMK.Size = new System.Drawing.Size(179, 52);
            this.b_QMK.TabIndex = 6;
            this.b_QMK.Text = "Quên mật khẩu";
            this.b_QMK.UseVisualStyleBackColor = true;
            this.b_QMK.Click += new System.EventHandler(this.b_QMK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PBL3_20_5.Properties.Resources.gif;
            this.pictureBox1.Location = new System.Drawing.Point(141, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // l_MatKhau
            // 
            this.l_MatKhau.AutoSize = true;
            this.l_MatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.l_MatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_MatKhau.Location = new System.Drawing.Point(136, 366);
            this.l_MatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_MatKhau.Name = "l_MatKhau";
            this.l_MatKhau.Size = new System.Drawing.Size(104, 27);
            this.l_MatKhau.TabIndex = 8;
            this.l_MatKhau.Text = "Mật khẩu";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PBL3_20_5.Properties.Resources._446024572_7091268064306090_4003654307199488778_n;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(634, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 35);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::PBL3_20_5.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l_MatKhau);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_QMK);
            this.Controls.Add(this.b_DangNhap);
            this.Controls.Add(this.b_DangKy);
            this.Controls.Add(this.l_TaiKhoan);
            this.Controls.Add(this.t_MatKhau);
            this.Controls.Add(this.t_TaiKhoan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangNhap";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_TaiKhoan;
        private System.Windows.Forms.TextBox t_MatKhau;
        private System.Windows.Forms.Label l_TaiKhoan;
        private System.Windows.Forms.Button b_DangKy;
        private System.Windows.Forms.Button b_DangNhap;
        private System.Windows.Forms.Button b_QMK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_MatKhau;
        private System.Windows.Forms.Button button1;
    }
}