namespace PBL3_20_5
{
    partial class DoiMatKhau
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
            this.l_MatKhauHienTai = new System.Windows.Forms.Label();
            this.l_MatKhauMoi = new System.Windows.Forms.Label();
            this.l_MatKhauMoiAgain = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.b_ThayDoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_MatKhauHienTai
            // 
            this.l_MatKhauHienTai.AutoSize = true;
            this.l_MatKhauHienTai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_MatKhauHienTai.Location = new System.Drawing.Point(87, 28);
            this.l_MatKhauHienTai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_MatKhauHienTai.Name = "l_MatKhauHienTai";
            this.l_MatKhauHienTai.Size = new System.Drawing.Size(145, 22);
            this.l_MatKhauHienTai.TabIndex = 0;
            this.l_MatKhauHienTai.Text = "Mật khẩu hiện tại";
            // 
            // l_MatKhauMoi
            // 
            this.l_MatKhauMoi.AutoSize = true;
            this.l_MatKhauMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_MatKhauMoi.Location = new System.Drawing.Point(112, 89);
            this.l_MatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_MatKhauMoi.Name = "l_MatKhauMoi";
            this.l_MatKhauMoi.Size = new System.Drawing.Size(118, 22);
            this.l_MatKhauMoi.TabIndex = 1;
            this.l_MatKhauMoi.Text = "Mật khẩu mới";
            // 
            // l_MatKhauMoiAgain
            // 
            this.l_MatKhauMoiAgain.AutoSize = true;
            this.l_MatKhauMoiAgain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_MatKhauMoiAgain.Location = new System.Drawing.Point(43, 151);
            this.l_MatKhauMoiAgain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_MatKhauMoiAgain.Name = "l_MatKhauMoiAgain";
            this.l_MatKhauMoiAgain.Size = new System.Drawing.Size(188, 22);
            this.l_MatKhauMoiAgain.TabIndex = 2;
            this.l_MatKhauMoiAgain.Text = "Nhập lại mật khẩu mới";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(260, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(220, 30);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(260, 80);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(220, 30);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(260, 146);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(220, 30);
            this.textBox3.TabIndex = 5;
            // 
            // b_ThayDoi
            // 
            this.b_ThayDoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ThayDoi.Location = new System.Drawing.Point(184, 223);
            this.b_ThayDoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_ThayDoi.Name = "b_ThayDoi";
            this.b_ThayDoi.Size = new System.Drawing.Size(171, 44);
            this.b_ThayDoi.TabIndex = 6;
            this.b_ThayDoi.Text = "Thay đổi";
            this.b_ThayDoi.UseVisualStyleBackColor = true;
            this.b_ThayDoi.Click += new System.EventHandler(this.b_ThayDoi_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(613, 316);
            this.Controls.Add(this.b_ThayDoi);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.l_MatKhauMoiAgain);
            this.Controls.Add(this.l_MatKhauMoi);
            this.Controls.Add(this.l_MatKhauHienTai);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_MatKhauHienTai;
        private System.Windows.Forms.Label l_MatKhauMoi;
        private System.Windows.Forms.Label l_MatKhauMoiAgain;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button b_ThayDoi;
    }
}