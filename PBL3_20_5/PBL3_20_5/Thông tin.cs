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
    public partial class Thông_tin : Form
    {
        private string username;
        private Form curentFormChild;
        public static Thông_tin Instance;
        public delegate void MyDel_ThongtinAdmin(string username);
        public MyDel_ThongtinAdmin d_ThongtinAdmin;
        public Thông_tin(string un, bool isChangePassword)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            username = un;
            if (isChangePassword)
            {
                ShowChangePasswork();
            }
            else
            {
                ShowHomePage();
            }
        }

        private void ShowHomePage()
        {
            var homePage = new Thông_tin_tài_khoản(username);
            ShowPage(homePage);
            homePage.d += new Thông_tin_tài_khoản.MyDel(ShowChangeInfor);

        }
        public void ShowChangeInfor()
        {
            var homeChangeInfor = new Thông_tin_tài_khoản_Sua(username);
            ShowPage(homeChangeInfor);
            homeChangeInfor.d += new Thông_tin_tài_khoản_Sua.MyDel(ShowHomePage);
        }

        public void ShowChangePasswork()
        {
            var homeChangework = new Thay_đổi_mật_khẩu(username);
            ShowPage(homeChangework);
            //homeChangework.d += new Thông_tin_tài_khoản_Admin_Sua.MyDel(ShowHomePage);
            homeChangework.CancelClicked += UserControl_CancelClicked;

        }
        private void ShowPage(UserControl page)
        {
            pictureBox2.Controls.Clear();
            pictureBox2.Controls.Add(page);
            page.Dock = DockStyle.Fill;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Destop_GUI.Instance.LoadForm(GiaoDienAdmin.Instance);
            this.Dispose();
        }
        private void UserControl_CancelClicked(object sender, EventArgs e)
        {
            this.Close(); // Tắt form
        }
    }
}
