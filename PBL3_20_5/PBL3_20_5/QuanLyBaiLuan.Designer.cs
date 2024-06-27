namespace PBL3_20_5
{
    partial class QuanLyBaiLuan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_TenTaiKhoan = new System.Windows.Forms.Label();
            this.label_BinhLuan = new System.Windows.Forms.Label();
            this.label_Ngay = new System.Windows.Forms.Label();
            this.textBox_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.textBox_BinhLuan = new System.Windows.Forms.TextBox();
            this.textBox_Ngay = new System.Windows.Forms.TextBox();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.label_Baidang = new System.Windows.Forms.Label();
            this.textBox_BaiDang = new System.Windows.Forms.TextBox();
            this.label_IdComment = new System.Windows.Forms.Label();
            this.textBox_IdComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_XemchitietBaiDang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1151, 227);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_TenTaiKhoan
            // 
            this.label_TenTaiKhoan.AutoSize = true;
            this.label_TenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label_TenTaiKhoan.Location = new System.Drawing.Point(218, 39);
            this.label_TenTaiKhoan.Name = "label_TenTaiKhoan";
            this.label_TenTaiKhoan.Size = new System.Drawing.Size(117, 20);
            this.label_TenTaiKhoan.TabIndex = 10;
            this.label_TenTaiKhoan.Text = "Tên tài khoản";
            // 
            // label_BinhLuan
            // 
            this.label_BinhLuan.AutoSize = true;
            this.label_BinhLuan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label_BinhLuan.Location = new System.Drawing.Point(620, 39);
            this.label_BinhLuan.Name = "label_BinhLuan";
            this.label_BinhLuan.Size = new System.Drawing.Size(85, 20);
            this.label_BinhLuan.TabIndex = 11;
            this.label_BinhLuan.Text = "Bình luận";
            this.label_BinhLuan.Click += new System.EventHandler(this.label_BinhLuan_Click);
            // 
            // label_Ngay
            // 
            this.label_Ngay.AutoSize = true;
            this.label_Ngay.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label_Ngay.Location = new System.Drawing.Point(363, 189);
            this.label_Ngay.Name = "label_Ngay";
            this.label_Ngay.Size = new System.Drawing.Size(49, 20);
            this.label_Ngay.TabIndex = 12;
            this.label_Ngay.Text = "Ngày";
            // 
            // textBox_TenTaiKhoan
            // 
            this.textBox_TenTaiKhoan.Location = new System.Drawing.Point(353, 37);
            this.textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            this.textBox_TenTaiKhoan.Size = new System.Drawing.Size(172, 22);
            this.textBox_TenTaiKhoan.TabIndex = 13;
            // 
            // textBox_BinhLuan
            // 
            this.textBox_BinhLuan.Location = new System.Drawing.Point(761, 15);
            this.textBox_BinhLuan.Multiline = true;
            this.textBox_BinhLuan.Name = "textBox_BinhLuan";
            this.textBox_BinhLuan.Size = new System.Drawing.Size(327, 44);
            this.textBox_BinhLuan.TabIndex = 14;
            // 
            // textBox_Ngay
            // 
            this.textBox_Ngay.Location = new System.Drawing.Point(503, 187);
            this.textBox_Ngay.Name = "textBox_Ngay";
            this.textBox_Ngay.Size = new System.Drawing.Size(291, 22);
            this.textBox_Ngay.TabIndex = 15;
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Xoa.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Xoa.ForeColor = System.Drawing.Color.Red;
            this.button_Xoa.Location = new System.Drawing.Point(951, 167);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(162, 42);
            this.button_Xoa.TabIndex = 17;
            this.button_Xoa.Text = "Xóa Bình Luận";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click_1);
            // 
            // label_Baidang
            // 
            this.label_Baidang.AutoSize = true;
            this.label_Baidang.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.label_Baidang.Location = new System.Drawing.Point(20, 192);
            this.label_Baidang.Name = "label_Baidang";
            this.label_Baidang.Size = new System.Drawing.Size(81, 20);
            this.label_Baidang.TabIndex = 18;
            this.label_Baidang.Text = "Bài Đăng";
            // 
            // textBox_BaiDang
            // 
            this.textBox_BaiDang.Location = new System.Drawing.Point(134, 187);
            this.textBox_BaiDang.Name = "textBox_BaiDang";
            this.textBox_BaiDang.Size = new System.Drawing.Size(113, 22);
            this.textBox_BaiDang.TabIndex = 19;
            // 
            // label_IdComment
            // 
            this.label_IdComment.AutoSize = true;
            this.label_IdComment.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IdComment.Location = new System.Drawing.Point(20, 39);
            this.label_IdComment.Name = "label_IdComment";
            this.label_IdComment.Size = new System.Drawing.Size(29, 20);
            this.label_IdComment.TabIndex = 20;
            this.label_IdComment.Text = "ID";
            // 
            // textBox_IdComment
            // 
            this.textBox_IdComment.Location = new System.Drawing.Point(64, 37);
            this.textBox_IdComment.Name = "textBox_IdComment";
            this.textBox_IdComment.Size = new System.Drawing.Size(90, 22);
            this.textBox_IdComment.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "Danh Sách Bình Luận";
            // 
            // button_XemchitietBaiDang
            // 
            this.button_XemchitietBaiDang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_XemchitietBaiDang.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_XemchitietBaiDang.ForeColor = System.Drawing.Color.Black;
            this.button_XemchitietBaiDang.Location = new System.Drawing.Point(951, 265);
            this.button_XemchitietBaiDang.Name = "button_XemchitietBaiDang";
            this.button_XemchitietBaiDang.Size = new System.Drawing.Size(179, 42);
            this.button_XemchitietBaiDang.TabIndex = 39;
            this.button_XemchitietBaiDang.Text = "Xem Chi Tiết Bài Đăng";
            this.button_XemchitietBaiDang.UseVisualStyleBackColor = false;
            this.button_XemchitietBaiDang.Click += new System.EventHandler(this.button_XemchitietBaiDang_Click);
            // 
            // QuanLyBaiLuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_XemchitietBaiDang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_IdComment);
            this.Controls.Add(this.label_IdComment);
            this.Controls.Add(this.textBox_BaiDang);
            this.Controls.Add(this.label_Baidang);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.textBox_Ngay);
            this.Controls.Add(this.textBox_BinhLuan);
            this.Controls.Add(this.textBox_TenTaiKhoan);
            this.Controls.Add(this.label_Ngay);
            this.Controls.Add(this.label_BinhLuan);
            this.Controls.Add(this.label_TenTaiKhoan);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuanLyBaiLuan";
            this.Size = new System.Drawing.Size(1283, 599);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_TenTaiKhoan;
        private System.Windows.Forms.Label label_BinhLuan;
        private System.Windows.Forms.Label label_Ngay;
        private System.Windows.Forms.TextBox textBox_TenTaiKhoan;
        private System.Windows.Forms.TextBox textBox_BinhLuan;
        private System.Windows.Forms.TextBox textBox_Ngay;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Label label_Baidang;
        private System.Windows.Forms.TextBox textBox_BaiDang;
        private System.Windows.Forms.Label label_IdComment;
        private System.Windows.Forms.TextBox textBox_IdComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_XemchitietBaiDang;


    }
}
