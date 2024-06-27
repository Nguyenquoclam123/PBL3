using System.Windows.Forms;
using System;

namespace PBL3_20_5
{
    partial class GiaoDienAdmin
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

        private void InitializeComponent()
        {
            this.panel_Left = new System.Windows.Forms.Panel();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.btnDangBai = new System.Windows.Forms.Button();
            this.btnPhongTro = new System.Windows.Forms.Button();
            this.btnDaytro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Home = new System.Windows.Forms.Label();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayĐổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxDel = new System.Windows.Forms.PictureBox();
            this.panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Left.Controls.Add(this.btnDuyet);
            this.panel_Left.Controls.Add(this.btnDangBai);
            this.panel_Left.Controls.Add(this.btnPhongTro);
            this.panel_Left.Controls.Add(this.btnDaytro);
            this.panel_Left.Controls.Add(this.pictureBox1);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(240, 757);
            this.panel_Left.TabIndex = 0;
            // 
            // btnDuyet
            // 
            this.btnDuyet.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDuyet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDuyet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDuyet.Location = new System.Drawing.Point(0, 306);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(240, 59);
            this.btnDuyet.TabIndex = 3;
            this.btnDuyet.Text = "Quản lý tài khoản";
            this.btnDuyet.UseVisualStyleBackColor = false;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // btnDangBai
            // 
            this.btnDangBai.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDangBai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangBai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangBai.ForeColor = System.Drawing.Color.White;
            this.btnDangBai.Location = new System.Drawing.Point(0, 247);
            this.btnDangBai.Name = "btnDangBai";
            this.btnDangBai.Size = new System.Drawing.Size(240, 59);
            this.btnDangBai.TabIndex = 2;
            this.btnDangBai.Text = "Quản lý bình luận";
            this.btnDangBai.UseVisualStyleBackColor = false;
            this.btnDangBai.Click += new System.EventHandler(this.btnDangBai_Click);
            // 
            // btnPhongTro
            // 
            this.btnPhongTro.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPhongTro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhongTro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongTro.ForeColor = System.Drawing.Color.White;
            this.btnPhongTro.Location = new System.Drawing.Point(0, 188);
            this.btnPhongTro.Name = "btnPhongTro";
            this.btnPhongTro.Size = new System.Drawing.Size(240, 59);
            this.btnPhongTro.TabIndex = 1;
            this.btnPhongTro.Text = "Quản lý bài đăng";
            this.btnPhongTro.UseVisualStyleBackColor = false;
            this.btnPhongTro.Click += new System.EventHandler(this.btnPhongTro_Click);
            // 
            // btnDaytro
            // 
            this.btnDaytro.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDaytro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDaytro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaytro.ForeColor = System.Drawing.Color.White;
            this.btnDaytro.Location = new System.Drawing.Point(0, 129);
            this.btnDaytro.Name = "btnDaytro";
            this.btnDaytro.Size = new System.Drawing.Size(240, 59);
            this.btnDaytro.TabIndex = 0;
            this.btnDaytro.Text = "Trang Chủ";
            this.btnDaytro.UseVisualStyleBackColor = false;
            this.btnDaytro.Click += new System.EventHandler(this.btnDaytro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ErrorImage = global::PBL3_20_5.Properties.Resources.logo_rentroom1;
            this.pictureBox1.Image = global::PBL3_20_5.Properties.Resources.logo_rentroom1;
            this.pictureBox1.InitialImage = global::PBL3_20_5.Properties.Resources.logo_rentroom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Top.Controls.Add(this.pictureBox5);
            this.panel_Top.Controls.Add(this.label_UserName);
            this.panel_Top.Controls.Add(this.panel1);
            this.panel_Top.Controls.Add(this.label_Home);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(240, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1206, 129);
            this.panel_Top.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox5.Image = global::PBL3_20_5.Properties.Resources.person_circle_icon_159926;
            this.pictureBox5.Location = new System.Drawing.Point(1133, 23);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // label_UserName
            // 
            this.label_UserName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.Location = new System.Drawing.Point(842, 23);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(285, 42);
            this.label_UserName.TabIndex = 5;
            this.label_UserName.Text = "Phạm Ngọc Huynh";
            this.label_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1006, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::PBL3_20_5.Properties.Resources.iconComment;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(200, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.BackgroundImage = global::PBL3_20_5.Properties.Resources.person_circle_icon_159926;
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem1,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // thôngTinCáNhânToolStripMenuItem1
            // 
            this.thôngTinCáNhânToolStripMenuItem1.Name = "thôngTinCáNhânToolStripMenuItem1";
            this.thôngTinCáNhânToolStripMenuItem1.Size = new System.Drawing.Size(221, 26);
            this.thôngTinCáNhânToolStripMenuItem1.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem1_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // label_Home
            // 
            this.label_Home.AutoSize = true;
            this.label_Home.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Home.Location = new System.Drawing.Point(6, 49);
            this.label_Home.Name = "label_Home";
            this.label_Home.Size = new System.Drawing.Size(72, 26);
            this.label_Home.TabIndex = 0;
            this.label_Home.Text = "Trở về";
            this.label_Home.Click += new System.EventHandler(this.label_Home_Click);
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_Body.Controls.Add(this.pictureBox2);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(240, 129);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1206, 628);
            this.panel_Body.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1206, 628);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // thayĐổiMậtKhẩuToolStripMenuItem
            // 
            this.thayĐổiMậtKhẩuToolStripMenuItem.Name = "thayĐổiMậtKhẩuToolStripMenuItem";
            this.thayĐổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // đăngXuátToolStripMenuItem
            // 
            this.đăngXuátToolStripMenuItem.Name = "đăngXuátToolStripMenuItem";
            this.đăngXuátToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // pictureBoxDel
            // 
            this.pictureBoxDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxDel.BackColor = System.Drawing.Color.GhostWhite;
            this.pictureBoxDel.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDel.Name = "pictureBoxDel";
            this.pictureBoxDel.Size = new System.Drawing.Size(1206, 628);
            this.pictureBoxDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDel.TabIndex = 0;
            this.pictureBoxDel.TabStop = false;
            // 
            // GiaoDienAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 757);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Left);
            this.Name = "GiaoDienAdmin";
            this.Text = "Giao diện Admin";
            this.panel_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDel)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDaytro;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.Button btnDangBai;
        private System.Windows.Forms.Button btnPhongTro;
        private System.Windows.Forms.Label label_Home;
        private System.Windows.Forms.PictureBox pictureBoxDel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thayĐổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        public Label label_UserName;
    }
}