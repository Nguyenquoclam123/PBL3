namespace PBL3_20_5
{
    partial class QuanLiDayTro
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
            this.lbID_Motel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbID_Manager = new System.Windows.Forms.Label();
            this.lbNumRoom = new System.Windows.Forms.Label();
            this.lbAdress = new System.Windows.Forms.Label();
            this.lbDes = new System.Windows.Forms.Label();
            this.tbFulllDescription = new System.Windows.Forms.TextBox();
            this.tbFullAddress = new System.Windows.Forms.TextBox();
            this.tbNumRoom = new System.Windows.Forms.TextBox();
            this.tbID_Manager = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbID_Motel = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(366, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(807, 469);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lbID_Motel
            // 
            this.lbID_Motel.AutoSize = true;
            this.lbID_Motel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID_Motel.Location = new System.Drawing.Point(47, 129);
            this.lbID_Motel.Name = "lbID_Motel";
            this.lbID_Motel.Size = new System.Drawing.Size(82, 19);
            this.lbID_Motel.TabIndex = 5;
            this.lbID_Motel.Text = "Mã dãy trọ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản lý dãy trọ";
            // 
            // lbID_Manager
            // 
            this.lbID_Manager.AutoSize = true;
            this.lbID_Manager.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID_Manager.Location = new System.Drawing.Point(47, 174);
            this.lbID_Manager.Name = "lbID_Manager";
            this.lbID_Manager.Size = new System.Drawing.Size(83, 19);
            this.lbID_Manager.TabIndex = 7;
            this.lbID_Manager.Text = "Mã chủ trọ";
            // 
            // lbNumRoom
            // 
            this.lbNumRoom.AutoSize = true;
            this.lbNumRoom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumRoom.Location = new System.Drawing.Point(14, 219);
            this.lbNumRoom.Name = "lbNumRoom";
            this.lbNumRoom.Size = new System.Drawing.Size(115, 19);
            this.lbNumRoom.TabIndex = 8;
            this.lbNumRoom.Text = "Số lượng phòng";
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdress.Location = new System.Drawing.Point(71, 272);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(58, 19);
            this.lbAdress.TabIndex = 9;
            this.lbAdress.Text = "Địa chỉ";
            // 
            // lbDes
            // 
            this.lbDes.AutoSize = true;
            this.lbDes.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDes.Location = new System.Drawing.Point(80, 319);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(49, 19);
            this.lbDes.TabIndex = 10;
            this.lbDes.Text = "Mô tả";
            // 
            // tbFulllDescription
            // 
            this.tbFulllDescription.Location = new System.Drawing.Point(143, 319);
            this.tbFulllDescription.Multiline = true;
            this.tbFulllDescription.Name = "tbFulllDescription";
            this.tbFulllDescription.Size = new System.Drawing.Size(190, 79);
            this.tbFulllDescription.TabIndex = 25;
            // 
            // tbFullAddress
            // 
            this.tbFullAddress.Location = new System.Drawing.Point(143, 271);
            this.tbFullAddress.Name = "tbFullAddress";
            this.tbFullAddress.Size = new System.Drawing.Size(190, 22);
            this.tbFullAddress.TabIndex = 24;
            // 
            // tbNumRoom
            // 
            this.tbNumRoom.Location = new System.Drawing.Point(143, 219);
            this.tbNumRoom.Name = "tbNumRoom";
            this.tbNumRoom.Size = new System.Drawing.Size(190, 22);
            this.tbNumRoom.TabIndex = 23;
            // 
            // tbID_Manager
            // 
            this.tbID_Manager.Enabled = false;
            this.tbID_Manager.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbID_Manager.Location = new System.Drawing.Point(143, 174);
            this.tbID_Manager.Name = "tbID_Manager";
            this.tbID_Manager.Size = new System.Drawing.Size(190, 22);
            this.tbID_Manager.TabIndex = 22;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(143, 463);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 36);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbID_Motel
            // 
            this.tbID_Motel.Location = new System.Drawing.Point(143, 128);
            this.tbID_Motel.Name = "tbID_Motel";
            this.tbID_Motel.Size = new System.Drawing.Size(190, 22);
            this.tbID_Motel.TabIndex = 26;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(261, 532);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(99, 36);
            this.btnDel.TabIndex = 29;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(143, 532);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 36);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(22, 532);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 36);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // QuanLiDayTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 580);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbID_Motel);
            this.Controls.Add(this.tbFulllDescription);
            this.Controls.Add(this.tbFullAddress);
            this.Controls.Add(this.tbNumRoom);
            this.Controls.Add(this.tbID_Manager);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.lbAdress);
            this.Controls.Add(this.lbNumRoom);
            this.Controls.Add(this.lbID_Manager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbID_Motel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuanLiDayTro";
            this.Text = "QuanLiPhongTro";
            this.Load += new System.EventHandler(this.QuanLiDayTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbID_Motel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbID_Manager;
        private System.Windows.Forms.Label lbNumRoom;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.TextBox tbFulllDescription;
        private System.Windows.Forms.TextBox tbFullAddress;
        private System.Windows.Forms.TextBox tbNumRoom;
        private System.Windows.Forms.TextBox tbID_Manager;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbID_Motel;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}