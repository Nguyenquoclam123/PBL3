using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_20_5
{
    public partial class GiaoDienAdmin : Form
    {
        public delegate void MyDel();
        public MyDel d1;
        public MyDel d2;
        private string username;
        private Form curentFormChild;
        public static GiaoDienAdmin Instance;
        public GiaoDienAdmin(string un)
        {
            InitializeComponent();
            this.AutoSize = false;
            Instance = this;
            ShowHomePage();
            username = un;
            GiaoDienAdmin.Instance.label_UserName.Text = username;
            //Image image = Image.FromFile("C:\\Workspace\\HK2-2024\\PBL3_20_5\\PBL3_20_5\\PBL3_20_5\\Resources\\logo_rentroom1.png");
            //GiaoDienAdmin.Instance.pictureBox1.Image = image;
        }
        private void btnDaytro_Click(object sender, EventArgs e)
        {
            label_Home.Text = "Trang Chủ";
            ShowHomePage();
        }

        public void btnPhongTro_Click(object sender, EventArgs e)
        {
            label_Home.Text = "Quản Lý Bài Đăng";
            ShowPostManagementPage();
        }

        private void btnDangBai_Click(object sender, EventArgs e)
        {
            label_Home.Text = "Quản Lý Bình Luận";
            ShowCommentManagementPage();
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            label_Home.Text = "Quản Lý Tài Khoản";
            ShowAccountManagementPage();
        }


        private void ShowHomePage()
        {
            var homePage = new TrangChuAdmin(username);
            ShowPage(homePage);
        }

        private void ShowAccountManagementPage()
        {
            var accountPage = new QuanLyTaiKhoan();
            ShowPage(accountPage);
        }

        private void ShowCommentManagementPage()
        {
            var commentPage = new QuanLyBaiLuan();
            ShowPage(commentPage);
        }

        private void ShowPostManagementPage()
        {
            var postPage = new QuanLyBaiDang(username);
            ShowPage(postPage);
        }

        private void ShowPage(UserControl page)
        {
            pictureBox2.Controls.Clear();
            pictureBox2.Controls.Add(page);
            page.Dock = DockStyle.Fill;
        }

        private void label_Home_Click(object sender, EventArgs e)
        {
            GiaoDienChung.Instance.LoadPostMotel(BLL_Manager.Instance.getAllPostByApprove());
            Destop_GUI.Instance.LoadForm(GiaoDienChung.Instance);
        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thông_tin form = new Thông_tin(username, false);

            form.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thông_tin form = new Thông_tin(username, true);
            form.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                GiaoDienAdmin.Instance = null;
                GiaoDienChung.Instance = null;
                Destop_GUI.Instance.LoadForm(new GiaoDienChung());
            }

        }

        private void label_UserName_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }


}
