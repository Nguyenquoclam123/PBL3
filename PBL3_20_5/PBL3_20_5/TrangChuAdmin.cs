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
    public partial class TrangChuAdmin : UserControl
    {
        private string username;
        private Timer hideTimer;

        public TrangChuAdmin(string un)
        {
            InitializeComponent();
            Set_View();
            username = un;

        }
        public void Set_View()
        {
            lable_TongSoLuongTaiKhoan.Text = (BLL_Admin.Instance.TongSoLuongAccount()).ToString();
            lable_TongSoLuongBinhLuan.Text = (BLL_Admin.Instance.TongSoLuongComment()).ToString();
            lable_TongSoLuongBaiDang.Text = (BLL_Admin.Instance.TongSoLuongPost()).ToString();
            label_SoLuongDoanhSo.Text = (BLL_Admin.Instance.DoanhSo()).ToString();
            //
            label_SLAdmin.Text = (BLL_Admin.Instance.SoLuongAdmin()).ToString();
            label_SLManager.Text = (BLL_Admin.Instance.SoLuongManager()).ToString();
            label_SLRenter.Text = (BLL_Admin.Instance.SoLuongRenter()).ToString();
            //
            label_SLChuaDuyet.Text = (BLL_Admin.Instance.SoLuongChuaDuyet()).ToString();
            label_SLDaDuyet.Text = (BLL_Admin.Instance.SoLuongDaDuyet()).ToString();

        }



        private void groupBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = true;

        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            hideTimer.Start();
        }
        private void hideTimer_Tick(object sender, EventArgs e)
        {
            groupBox5.Visible = false; // Hide groupBox5
            groupBox6.Visible = false;
            hideTimer.Stop(); // Stop the timer
        }

        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            hideTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GiaoDienAdmin giaoDienAdmin = new GiaoDienAdmin(username);

            //// Gọi phương thức btnDangBai_Click từ form GiaoDienAdmin
            //giaoDienAdmin.btnPhongTro_Click(sender, e);
        }
    }
}
