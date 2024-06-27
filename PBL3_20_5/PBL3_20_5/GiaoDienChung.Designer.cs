using DTO;
using System;
using System.Windows.Forms;

namespace PBL3_20_5
{
    partial class GiaoDienChung
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
            this.b_DangKy = new System.Windows.Forms.Button();
            this.b_DangNhap = new System.Windows.Forms.Button();
            this.b_TimKiem = new System.Windows.Forms.Button();
            this.b_DatPhong = new System.Windows.Forms.Button();
            this.b_Pos = new System.Windows.Forms.Button();
            this.b_Cos = new System.Windows.Forms.Button();
            this.t_Pos1 = new System.Windows.Forms.TextBox();
            this.cb_Cos = new System.Windows.Forms.ComboBox();
            this.datagridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.b_Comment = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnPostMotel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.pbArow = new System.Windows.Forms.PictureBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnComment = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.cbbCost = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnComment = new System.Windows.Forms.Panel();
            this.btnsubm = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbUserComment = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnDetail = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.datagridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // b_DangKy
            // 
            this.b_DangKy.Location = new System.Drawing.Point(880, 2);
            this.b_DangKy.Name = "b_DangKy";
            this.b_DangKy.Size = new System.Drawing.Size(100, 23);
            this.b_DangKy.TabIndex = 0;
            this.b_DangKy.Text = "Đăng ký";
            this.b_DangKy.UseVisualStyleBackColor = true;
            // 
            // b_DangNhap
            // 
            this.b_DangNhap.Location = new System.Drawing.Point(984, 2);
            this.b_DangNhap.Name = "b_DangNhap";
            this.b_DangNhap.Size = new System.Drawing.Size(97, 23);
            this.b_DangNhap.TabIndex = 1;
            this.b_DangNhap.Text = "Đăng nhập";
            this.b_DangNhap.UseVisualStyleBackColor = true;
            // 
            // b_TimKiem
            // 
            this.b_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_TimKiem.Location = new System.Drawing.Point(2, 2);
            this.b_TimKiem.Name = "b_TimKiem";
            this.b_TimKiem.Size = new System.Drawing.Size(156, 43);
            this.b_TimKiem.TabIndex = 2;
            this.b_TimKiem.Text = "Tìm kiếm";
            this.b_TimKiem.UseVisualStyleBackColor = true;
            // 
            // b_DatPhong
            // 
            this.b_DatPhong.Location = new System.Drawing.Point(756, 22);
            this.b_DatPhong.Name = "b_DatPhong";
            this.b_DatPhong.Size = new System.Drawing.Size(118, 23);
            this.b_DatPhong.TabIndex = 4;
            this.b_DatPhong.Text = "Đăng ký đặt phòng";
            this.b_DatPhong.UseVisualStyleBackColor = true;
            // 
            // b_Pos
            // 
            this.b_Pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Pos.Location = new System.Drawing.Point(163, 2);
            this.b_Pos.Margin = new System.Windows.Forms.Padding(2);
            this.b_Pos.Name = "b_Pos";
            this.b_Pos.Size = new System.Drawing.Size(75, 28);
            this.b_Pos.TabIndex = 5;
            this.b_Pos.Text = "Theo vị trí";
            this.b_Pos.UseVisualStyleBackColor = true;
            this.b_Pos.Visible = false;
            // 
            // b_Cos
            // 
            this.b_Cos.Location = new System.Drawing.Point(432, 3);
            this.b_Cos.Margin = new System.Windows.Forms.Padding(2);
            this.b_Cos.Name = "b_Cos";
            this.b_Cos.Size = new System.Drawing.Size(75, 27);
            this.b_Cos.TabIndex = 6;
            this.b_Cos.Text = "Theo giá";
            this.b_Cos.UseVisualStyleBackColor = true;
            this.b_Cos.Visible = false;
            // 
            // t_Pos1
            // 
            this.t_Pos1.Location = new System.Drawing.Point(254, 7);
            this.t_Pos1.Margin = new System.Windows.Forms.Padding(2);
            this.t_Pos1.Name = "t_Pos1";
            this.t_Pos1.Size = new System.Drawing.Size(123, 22);
            this.t_Pos1.TabIndex = 7;
            this.t_Pos1.Visible = false;
            // 
            // cb_Cos
            // 
            this.cb_Cos.FormattingEnabled = true;
            this.cb_Cos.Items.AddRange(new object[] {
            "500.000-800.000",
            "800.000-1.000.000",
            "1.000.000-1.500.000",
            "1.500.000-2.000.000",
            ">2.000.000",
            "Tất cả"});
            this.cb_Cos.Location = new System.Drawing.Point(538, 7);
            this.cb_Cos.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Cos.Name = "cb_Cos";
            this.cb_Cos.Size = new System.Drawing.Size(123, 24);
            this.cb_Cos.TabIndex = 8;
            this.cb_Cos.Visible = false;
            // 
            // datagridView1
            // 
            this.datagridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridView1.Location = new System.Drawing.Point(12, 51);
            this.datagridView1.Name = "datagridView1";
            this.datagridView1.ReadOnly = true;
            this.datagridView1.RowHeadersWidth = 51;
            this.datagridView1.Size = new System.Drawing.Size(1069, 461);
            this.datagridView1.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(2, 549);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1079, 150);
            this.dataGridView2.TabIndex = 10;
            // 
            // b_Comment
            // 
            this.b_Comment.Location = new System.Drawing.Point(996, 518);
            this.b_Comment.Name = "b_Comment";
            this.b_Comment.Size = new System.Drawing.Size(85, 25);
            this.b_Comment.TabIndex = 11;
            this.b_Comment.Text = "Bình luận";
            this.b_Comment.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(863, 427);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pnPostMotel
            // 
            this.pnPostMotel.AutoScroll = true;
            this.pnPostMotel.BackColor = System.Drawing.SystemColors.Control;
            this.pnPostMotel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPostMotel.Location = new System.Drawing.Point(4, 132);
            this.pnPostMotel.Name = "pnPostMotel";
            this.pnPostMotel.Size = new System.Drawing.Size(1043, 622);
            this.pnPostMotel.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDangKy);
            this.panel3.Controls.Add(this.pbArow);
            this.panel3.Controls.Add(this.lbUsername);
            this.panel3.Controls.Add(this.btnDangnhap);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btnComment);
            this.panel3.Controls.Add(this.btnRoom);
            this.panel3.Controls.Add(this.cbbCost);
            this.panel3.Controls.Add(this.btn_search);
            this.panel3.Controls.Add(this.txtPos);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(4, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1439, 127);
            this.panel3.TabIndex = 4;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(1087, 26);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(122, 34);
            this.btnDangKy.TabIndex = 17;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // pbArow
            // 
            this.pbArow.Image = global::PBL3_20_5.Properties.Resources.arrow_icon_281;
            this.pbArow.Location = new System.Drawing.Point(27, 9);
            this.pbArow.Name = "pbArow";
            this.pbArow.Size = new System.Drawing.Size(80, 64);
            this.pbArow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArow.TabIndex = 16;
            this.pbArow.TabStop = false;
            this.pbArow.Visible = false;
            this.pbArow.Click += new System.EventHandler(this.pbArow_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(1099, 19);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(265, 42);
            this.lbUsername.TabIndex = 15;
            this.lbUsername.Text = "username";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbUsername.Visible = false;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDangnhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Location = new System.Drawing.Point(1230, 26);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(122, 34);
            this.btnDangnhap.TabIndex = 14;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vị trí:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(703, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 54);
            this.label1.TabIndex = 11;
            this.label1.Text = "Coliving";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PBL3_20_5.Properties.Resources.logo_rentroom;
            this.pictureBox2.Location = new System.Drawing.Point(597, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // btnComment
            // 
            this.btnComment.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnComment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.Location = new System.Drawing.Point(1278, 90);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(122, 34);
            this.btnComment.TabIndex = 9;
            this.btnComment.Text = "Bình luận";
            this.btnComment.UseVisualStyleBackColor = false;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.Location = new System.Drawing.Point(1099, 90);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(122, 34);
            this.btnRoom.TabIndex = 8;
            this.btnRoom.Text = "Phòng";
            this.btnRoom.UseVisualStyleBackColor = false;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // cbbCost
            // 
            this.cbbCost.FormattingEnabled = true;
            this.cbbCost.Items.AddRange(new object[] {
            "500.000-800.000",
            "800.000-1.000.000",
            "1.000.000-1.500.000",
            "1.500.000-2.000.000",
            "200.000-3.000.000",
            "Tất cả"});
            this.cbbCost.Location = new System.Drawing.Point(480, 97);
            this.cbbCost.Name = "cbbCost";
            this.cbbCost.Size = new System.Drawing.Size(183, 24);
            this.cbbCost.TabIndex = 7;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(894, 90);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(126, 34);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txtPos
            // 
            this.txtPos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPos.Location = new System.Drawing.Point(79, 98);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(224, 22);
            this.txtPos.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::PBL3_20_5.Properties.Resources.person_circle_icon_159926;
            this.pictureBox1.Location = new System.Drawing.Point(1370, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnComment
            // 
            this.pnComment.BackColor = System.Drawing.SystemColors.Control;
            this.pnComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnComment.Controls.Add(this.btnsubm);
            this.pnComment.Controls.Add(this.txtComment);
            this.pnComment.Controls.Add(this.pictureBox4);
            this.pnComment.Controls.Add(this.lbUserComment);
            this.pnComment.Controls.Add(this.pictureBox3);
            this.pnComment.Location = new System.Drawing.Point(1053, 649);
            this.pnComment.Name = "pnComment";
            this.pnComment.Size = new System.Drawing.Size(368, 84);
            this.pnComment.TabIndex = 5;
            this.pnComment.Visible = false;
            // 
            // btnsubm
            // 
            this.btnsubm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnsubm.Location = new System.Drawing.Point(308, 47);
            this.btnsubm.Name = "btnsubm";
            this.btnsubm.Size = new System.Drawing.Size(54, 23);
            this.btnsubm.TabIndex = 16;
            this.btnsubm.Text = "Gửi";
            this.btnsubm.UseVisualStyleBackColor = false;
            this.btnsubm.Click += new System.EventHandler(this.btnsubm_Click);
            // 
            // txtComment
            // 
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComment.Location = new System.Drawing.Point(49, 48);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(253, 22);
            this.txtComment.TabIndex = 15;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox4.Image = global::PBL3_20_5.Properties.Resources.iconComment;
            this.pictureBox4.Location = new System.Drawing.Point(20, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // lbUserComment
            // 
            this.lbUserComment.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserComment.Location = new System.Drawing.Point(50, 15);
            this.lbUserComment.Name = "lbUserComment";
            this.lbUserComment.Size = new System.Drawing.Size(132, 21);
            this.lbUserComment.TabIndex = 13;
            this.lbUserComment.Text = "Phạm Ngọc Huynh";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox3.Image = global::PBL3_20_5.Properties.Resources.person_circle_icon_1599261;
            this.pictureBox3.Location = new System.Drawing.Point(20, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pnDetail
            // 
            this.pnDetail.AutoScroll = true;
            this.pnDetail.BackColor = System.Drawing.SystemColors.Control;
            this.pnDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDetail.Location = new System.Drawing.Point(1053, 132);
            this.pnDetail.Name = "pnDetail";
            this.pnDetail.Size = new System.Drawing.Size(390, 622);
            this.pnDetail.TabIndex = 3;
            // 
            // GiaoDienChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1447, 757);
            this.Controls.Add(this.pnComment);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnDetail);
            this.Controls.Add(this.pnPostMotel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GiaoDienChung";
            this.Text = "Hỗ trợ tìm kiếm phòng trọ tại Đà Nẵng";
            ((System.ComponentModel.ISupportInitialize)(this.datagridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnComment.ResumeLayout(false);
            this.pnComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button b_DangKy;
        private System.Windows.Forms.Button b_DangNhap;
        private System.Windows.Forms.Button b_TimKiem;
        private System.Windows.Forms.Button b_DatPhong;
        private System.Windows.Forms.Button b_Pos;
        private System.Windows.Forms.Button b_Cos;
        private System.Windows.Forms.TextBox t_Pos1;
        private System.Windows.Forms.ComboBox cb_Cos;
        private System.Windows.Forms.DataGridView datagridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button b_Comment;

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel pnPostMotel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private object px_Picture_icon_BLACK_svg;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cbbCost;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.PictureBox pictureBox4;
        private FlowLayoutPanel pnDetail;
        private Label label4;
        private Label label3;
        private Button btnsubm;
        private PictureBox pictureBox2;
        public Button btnDangnhap;
        public Label lbUsername;
        public PictureBox pbArow;
        public Button btnDangKy;
        public Panel pnComment;
        public Label lbUserComment;
    }
}