namespace PBL3_20_5
{
    partial class QuanLiPhongTro
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbIDMotel = new System.Windows.Forms.ComboBox();
            this.lbIDMotel = new System.Windows.Forms.Label();
            this.lbIDRoom = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbIDRoom = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(368, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(808, 469);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý phòng trọ";
            // 
            // cbbIDMotel
            // 
            this.cbbIDMotel.FormattingEnabled = true;
            this.cbbIDMotel.Location = new System.Drawing.Point(141, 122);
            this.cbbIDMotel.Name = "cbbIDMotel";
            this.cbbIDMotel.Size = new System.Drawing.Size(190, 24);
            this.cbbIDMotel.TabIndex = 2;
            this.cbbIDMotel.SelectedIndexChanged += new System.EventHandler(this.cbbIDMotel_SelectedIndexChanged);
            // 
            // lbIDMotel
            // 
            this.lbIDMotel.AutoSize = true;
            this.lbIDMotel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDMotel.Location = new System.Drawing.Point(23, 122);
            this.lbIDMotel.Name = "lbIDMotel";
            this.lbIDMotel.Size = new System.Drawing.Size(96, 19);
            this.lbIDMotel.TabIndex = 3;
            this.lbIDMotel.Text = "Chọn dãy trọ";
            // 
            // lbIDRoom
            // 
            this.lbIDRoom.AutoSize = true;
            this.lbIDRoom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDRoom.Location = new System.Drawing.Point(19, 177);
            this.lbIDRoom.Name = "lbIDRoom";
            this.lbIDRoom.Size = new System.Drawing.Size(100, 19);
            this.lbIDRoom.TabIndex = 6;
            this.lbIDRoom.Text = "Mã phòng trọ";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(86, 229);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(33, 19);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Giá";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(44, 282);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(75, 19);
            this.lbStatus.TabIndex = 10;
            this.lbStatus.Text = "Trạng thái";
            // 
            // tbStatus
            // 
            this.tbStatus.FormattingEnabled = true;
            this.tbStatus.Items.AddRange(new object[] {
            "Chưa thuê",
            "Đã thuê"});
            this.tbStatus.Location = new System.Drawing.Point(141, 281);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(190, 24);
            this.tbStatus.TabIndex = 11;
            this.tbStatus.SelectedIndexChanged += new System.EventHandler(this.tbStatus_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 532);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 36);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(134, 532);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 36);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(252, 532);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(99, 36);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(141, 463);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 36);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbIDRoom
            // 
            this.tbIDRoom.Location = new System.Drawing.Point(141, 176);
            this.tbIDRoom.Name = "tbIDRoom";
            this.tbIDRoom.Size = new System.Drawing.Size(190, 22);
            this.tbIDRoom.TabIndex = 17;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(141, 228);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(190, 22);
            this.tbPrice.TabIndex = 18;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(141, 345);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(190, 79);
            this.tbDescription.TabIndex = 19;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(70, 345);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(49, 19);
            this.lbDescription.TabIndex = 20;
            this.lbDescription.Text = "Mô tả";
            // 
            // QuanLiPhongTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 580);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbIDRoom);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbIDRoom);
            this.Controls.Add(this.lbIDMotel);
            this.Controls.Add(this.cbbIDMotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuanLiPhongTro";
            this.Text = "QuanLiDayTro";
            this.Load += new System.EventHandler(this.QuanLiPhongTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbIDMotel;
        private System.Windows.Forms.Label lbIDMotel;
        private System.Windows.Forms.Label lbIDRoom;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ComboBox tbStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbIDRoom;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbDescription;
    }
}