namespace PBL3_20_5
{
    partial class Thông_tin_tài_khoản
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
            this.textBox_Diachi = new System.Windows.Forms.TextBox();
            this.textBox_Tuoi = new System.Windows.Forms.TextBox();
            this.textBox_ten = new System.Windows.Forms.TextBox();
            this.label_diachi = new System.Windows.Forms.Label();
            this.label_Tuổi = new System.Windows.Forms.Label();
            this.label_Tên = new System.Windows.Forms.Label();
            this.textBox_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_SuaThongTin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Diachi
            // 
            this.textBox_Diachi.Location = new System.Drawing.Point(253, 227);
            this.textBox_Diachi.Name = "textBox_Diachi";
            this.textBox_Diachi.ReadOnly = true;
            this.textBox_Diachi.Size = new System.Drawing.Size(214, 22);
            this.textBox_Diachi.TabIndex = 27;
            // 
            // textBox_Tuoi
            // 
            this.textBox_Tuoi.Location = new System.Drawing.Point(253, 148);
            this.textBox_Tuoi.Name = "textBox_Tuoi";
            this.textBox_Tuoi.ReadOnly = true;
            this.textBox_Tuoi.Size = new System.Drawing.Size(214, 22);
            this.textBox_Tuoi.TabIndex = 26;
            // 
            // textBox_ten
            // 
            this.textBox_ten.Location = new System.Drawing.Point(253, 66);
            this.textBox_ten.Name = "textBox_ten";
            this.textBox_ten.ReadOnly = true;
            this.textBox_ten.Size = new System.Drawing.Size(214, 22);
            this.textBox_ten.TabIndex = 25;
            // 
            // label_diachi
            // 
            this.label_diachi.AutoSize = true;
            this.label_diachi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_diachi.Location = new System.Drawing.Point(103, 233);
            this.label_diachi.Name = "label_diachi";
            this.label_diachi.Size = new System.Drawing.Size(62, 19);
            this.label_diachi.TabIndex = 24;
            this.label_diachi.Text = "Địa chỉ";
            // 
            // label_Tuổi
            // 
            this.label_Tuổi.AutoSize = true;
            this.label_Tuổi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_Tuổi.Location = new System.Drawing.Point(103, 154);
            this.label_Tuổi.Name = "label_Tuổi";
            this.label_Tuổi.Size = new System.Drawing.Size(41, 19);
            this.label_Tuổi.TabIndex = 23;
            this.label_Tuổi.Text = "Tuổi";
            // 
            // label_Tên
            // 
            this.label_Tên.AutoSize = true;
            this.label_Tên.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_Tên.Location = new System.Drawing.Point(103, 72);
            this.label_Tên.Name = "label_Tên";
            this.label_Tên.Size = new System.Drawing.Size(78, 19);
            this.label_Tên.TabIndex = 22;
            this.label_Tên.Text = "Họ và tên";
            // 
            // textBox_SoDienThoai
            // 
            this.textBox_SoDienThoai.Location = new System.Drawing.Point(253, 310);
            this.textBox_SoDienThoai.Name = "textBox_SoDienThoai";
            this.textBox_SoDienThoai.ReadOnly = true;
            this.textBox_SoDienThoai.Size = new System.Drawing.Size(214, 22);
            this.textBox_SoDienThoai.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(103, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Số điện thoại";
            // 
            // label_SuaThongTin
            // 
            this.label_SuaThongTin.AutoSize = true;
            this.label_SuaThongTin.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SuaThongTin.Location = new System.Drawing.Point(590, 10);
            this.label_SuaThongTin.Name = "label_SuaThongTin";
            this.label_SuaThongTin.Size = new System.Drawing.Size(115, 19);
            this.label_SuaThongTin.TabIndex = 28;
            this.label_SuaThongTin.Text = "Sửa Thông Tin";
            this.label_SuaThongTin.Click += new System.EventHandler(this.label_SuaThongTin_Click);
            // 
            // Thông_tin_tài_khoản
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_SuaThongTin);
            this.Controls.Add(this.textBox_Diachi);
            this.Controls.Add(this.textBox_Tuoi);
            this.Controls.Add(this.textBox_ten);
            this.Controls.Add(this.label_diachi);
            this.Controls.Add(this.label_Tuổi);
            this.Controls.Add(this.label_Tên);
            this.Controls.Add(this.textBox_SoDienThoai);
            this.Controls.Add(this.label1);
            this.Name = "Thông_tin_tài_khoản";
            this.Size = new System.Drawing.Size(727, 410);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Diachi;
        private System.Windows.Forms.TextBox textBox_Tuoi;
        private System.Windows.Forms.TextBox textBox_ten;
        private System.Windows.Forms.Label label_diachi;
        private System.Windows.Forms.Label label_Tuổi;
        private System.Windows.Forms.Label label_Tên;
        private System.Windows.Forms.TextBox textBox_SoDienThoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_SuaThongTin;
    }
}
