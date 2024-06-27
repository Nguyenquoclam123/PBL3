namespace PBL3_20_5
{
    partial class QuanLyTaiKhoan
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
            this.textBox_ChucVu = new System.Windows.Forms.TextBox();
            this.textBox_SoDienThoai = new System.Windows.Forms.TextBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.textBox_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label_ChucVu = new System.Windows.Forms.Label();
            this.label_SoDienThoai = new System.Windows.Forms.Label();
            this.label_Matkhau = new System.Windows.Forms.Label();
            this.label_TenTaiKhoan = new System.Windows.Forms.Label();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.label_VaiTro = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1185, 246);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // textBox_ChucVu
            // 
            this.textBox_ChucVu.Location = new System.Drawing.Point(649, 133);
            this.textBox_ChucVu.Name = "textBox_ChucVu";
            this.textBox_ChucVu.Size = new System.Drawing.Size(248, 22);
            this.textBox_ChucVu.TabIndex = 29;
            // 
            // textBox_SoDienThoai
            // 
            this.textBox_SoDienThoai.Location = new System.Drawing.Point(139, 130);
            this.textBox_SoDienThoai.Name = "textBox_SoDienThoai";
            this.textBox_SoDienThoai.Size = new System.Drawing.Size(198, 22);
            this.textBox_SoDienThoai.TabIndex = 28;
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(649, 39);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(248, 22);
            this.textBox_MatKhau.TabIndex = 26;
            // 
            // textBox_TenTaiKhoan
            // 
            this.textBox_TenTaiKhoan.Location = new System.Drawing.Point(139, 36);
            this.textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            this.textBox_TenTaiKhoan.Size = new System.Drawing.Size(198, 22);
            this.textBox_TenTaiKhoan.TabIndex = 25;
            // 
            // label_ChucVu
            // 
            this.label_ChucVu.AutoSize = true;
            this.label_ChucVu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_ChucVu.Location = new System.Drawing.Point(529, 136);
            this.label_ChucVu.Name = "label_ChucVu";
            this.label_ChucVu.Size = new System.Drawing.Size(69, 19);
            this.label_ChucVu.TabIndex = 24;
            this.label_ChucVu.Text = "Chức vụ";
            // 
            // label_SoDienThoai
            // 
            this.label_SoDienThoai.AutoSize = true;
            this.label_SoDienThoai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_SoDienThoai.Location = new System.Drawing.Point(16, 136);
            this.label_SoDienThoai.Name = "label_SoDienThoai";
            this.label_SoDienThoai.Size = new System.Drawing.Size(105, 19);
            this.label_SoDienThoai.TabIndex = 22;
            this.label_SoDienThoai.Text = "Số điện thoại";
            // 
            // label_Matkhau
            // 
            this.label_Matkhau.AutoSize = true;
            this.label_Matkhau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_Matkhau.Location = new System.Drawing.Point(529, 42);
            this.label_Matkhau.Name = "label_Matkhau";
            this.label_Matkhau.Size = new System.Drawing.Size(78, 19);
            this.label_Matkhau.TabIndex = 21;
            this.label_Matkhau.Text = "Mật khẩu";
            this.label_Matkhau.Click += new System.EventHandler(this.label_Matkhau_Click);
            // 
            // label_TenTaiKhoan
            // 
            this.label_TenTaiKhoan.AutoSize = true;
            this.label_TenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_TenTaiKhoan.Location = new System.Drawing.Point(16, 42);
            this.label_TenTaiKhoan.Name = "label_TenTaiKhoan";
            this.label_TenTaiKhoan.Size = new System.Drawing.Size(108, 19);
            this.label_TenTaiKhoan.TabIndex = 20;
            this.label_TenTaiKhoan.Text = "Tên tài khoản";
            // 
            // button_Them
            // 
            this.button_Them.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Them.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Them.Location = new System.Drawing.Point(996, 19);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(193, 42);
            this.button_Them.TabIndex = 31;
            this.button_Them.Text = "Thêm Tài Khoản";
            this.button_Them.UseVisualStyleBackColor = false;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click_1);
            // 
            // button_Sua
            // 
            this.button_Sua.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Sua.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Sua.ForeColor = System.Drawing.Color.Black;
            this.button_Sua.Location = new System.Drawing.Point(996, 113);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(193, 42);
            this.button_Sua.TabIndex = 32;
            this.button_Sua.Text = "Sửa Tài Khoản";
            this.button_Sua.UseVisualStyleBackColor = false;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click_1);
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_Xoa.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Xoa.ForeColor = System.Drawing.Color.Red;
            this.button_Xoa.Location = new System.Drawing.Point(996, 205);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(193, 42);
            this.button_Xoa.TabIndex = 33;
            this.button_Xoa.Text = "Xóa Tài Khoản";
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click_1);
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_TimKiem.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_TimKiem.Location = new System.Drawing.Point(649, 214);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(122, 33);
            this.button_TimKiem.TabIndex = 34;
            this.button_TimKiem.Text = "Tìm kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = false;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // label_VaiTro
            // 
            this.label_VaiTro.AutoSize = true;
            this.label_VaiTro.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.label_VaiTro.Location = new System.Drawing.Point(16, 231);
            this.label_VaiTro.Name = "label_VaiTro";
            this.label_VaiTro.Size = new System.Drawing.Size(62, 19);
            this.label_VaiTro.TabIndex = 35;
            this.label_VaiTro.Text = "Vai Trò";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tất cả",
            "Admin",
            "Manager",
            "Renter"});
            this.comboBox1.Location = new System.Drawing.Point(139, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 24);
            this.comboBox1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 37;
            this.label1.Text = "Danh Sách Tài Khoản";
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_VaiTro);
            this.Controls.Add(this.button_TimKiem);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_ChucVu);
            this.Controls.Add(this.textBox_SoDienThoai);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.textBox_TenTaiKhoan);
            this.Controls.Add(this.label_ChucVu);
            this.Controls.Add(this.label_SoDienThoai);
            this.Controls.Add(this.label_Matkhau);
            this.Controls.Add(this.label_TenTaiKhoan);
            this.Name = "QuanLyTaiKhoan";
            this.Size = new System.Drawing.Size(1284, 601);
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_ChucVu;
        private System.Windows.Forms.TextBox textBox_SoDienThoai;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.TextBox textBox_TenTaiKhoan;
        private System.Windows.Forms.Label label_ChucVu;
        private System.Windows.Forms.Label label_SoDienThoai;
        private System.Windows.Forms.Label label_Matkhau;
        private System.Windows.Forms.Label label_TenTaiKhoan;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.Label label_VaiTro;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;


    }
}
