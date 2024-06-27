namespace PBL3_20_5
{
    partial class DanhSachBaiDang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbIDMotel = new System.Windows.Forms.Label();
            this.cbbIDMotel = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 34);
            this.label1.TabIndex = 32;
            this.label1.Text = "Danh sách bài đăng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 504);
            this.dataGridView1.TabIndex = 30;
            // 
            // lbIDMotel
            // 
            this.lbIDMotel.AutoSize = true;
            this.lbIDMotel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDMotel.Location = new System.Drawing.Point(915, 67);
            this.lbIDMotel.Name = "lbIDMotel";
            this.lbIDMotel.Size = new System.Drawing.Size(96, 19);
            this.lbIDMotel.TabIndex = 34;
            this.lbIDMotel.Text = "Chọn dãy trọ";
            this.lbIDMotel.Click += new System.EventHandler(this.lbIDMotel_Click);
            // 
            // cbbIDMotel
            // 
            this.cbbIDMotel.FormattingEnabled = true;
            this.cbbIDMotel.Location = new System.Drawing.Point(1033, 67);
            this.cbbIDMotel.Name = "cbbIDMotel";
            this.cbbIDMotel.Size = new System.Drawing.Size(141, 24);
            this.cbbIDMotel.TabIndex = 33;
            this.cbbIDMotel.SelectedIndexChanged += new System.EventHandler(this.cbbIDMotel_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(12, 55);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 36);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(117, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 36;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DanhSachBaiDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbIDMotel);
            this.Controls.Add(this.cbbIDMotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DanhSachBaiDang";
            this.Text = "DanhSachBaiDang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbIDMotel;
        private System.Windows.Forms.ComboBox cbbIDMotel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button1;
    }
}