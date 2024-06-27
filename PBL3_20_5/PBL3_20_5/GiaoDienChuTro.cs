using BLL;
using DTO;
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
    public partial class GiaoDienChuTro : Form
    {
        Manager manager = new Manager();
        public static GiaoDienChuTro Instance;
        private Form curentFormChild;

        public GiaoDienChuTro(Manager manager)
        {
            InitializeComponent();
            Instance = this;
            this.manager = manager;
        }

        private void OpenChildForm(Form childForm)
        {
            curentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDaytro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLiDayTro(manager));
            //label_Home.Text = btnDaytro.Text;
        }

        private void btnPhongTro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLiPhongTro(manager));
            //label_Home.Text = btnPhongTro.Text;
        }

        private void btnDangBai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DangThemDayTro(manager));
            //label_Home.Text = btnDangBai.Text;
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DuyetYeuCau(manager));
            //label_Home.Text = btnDuyet.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (curentFormChild != null)
            {
                curentFormChild.Close();
            }
            //label_Home.Text = "Trang chủ";
        }

        private void label_Home_Click(object sender, EventArgs e)
        {
            Destop_GUI.Instance.LoadForm(GiaoDienChung.Instance);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Destop_GUI.Instance.LoadForm(GiaoDienChung.Instance);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DanhSachBaiDang(manager));
        }


        //danh sach thue
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DanhSachThue(manager));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Thông_tin form = new Thông_tin(GiaoDienChuTro.Instance.lbUsername.Text, false);
            form.pictureBox2.Visible = false;
            OpenChildForm(new Thông_tin(GiaoDienChuTro.Instance.lbUsername.Text, false));
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Thông_tin form = new Thông_tin(GiaoDienChuTro.Instance.lbUsername.Text, false);
            form.pictureBox2.Visible = false;
            OpenChildForm(new Thông_tin(GiaoDienChuTro.Instance.lbUsername.Text, true));
        }

        //dang xuẩt
        private void button5_Click(object sender, EventArgs e)
        {
           

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                GiaoDienChuTro.Instance = null;
                GiaoDienChung.Instance = null;
                Destop_GUI.Instance.LoadForm(new GiaoDienChung());
            }
        }
    }
}
