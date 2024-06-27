using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBL3_20_5
{
    public partial class GiaoDienNguoiThue : Form
    {
        public static GiaoDienNguoiThue Instance;
        private Form curentFormChild;
        public GiaoDienNguoiThue()
        {
            InitializeComponent();
            Instance = this;
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

        public void CallNewForm()
        {
            OpenChildForm(new LichSuYeuCau(lbUsername.Text));
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Destop_GUI.Instance.LoadForm(GiaoDienChung.Instance);
        }

        private void btnXemthongtin_Click(object sender, EventArgs e)
        {
            Thông_tin form = new Thông_tin(GiaoDienNguoiThue.Instance.lbUsername.Text, false);
            form.pictureBox2.Visible = false;
            OpenChildForm(new Thông_tin(GiaoDienNguoiThue.Instance.lbUsername.Text, false));
        }

        private void btnDoimk_Click(object sender, EventArgs e)
        {
            Thông_tin form = new Thông_tin(GiaoDienNguoiThue.Instance.lbUsername.Text, false);
            form.pictureBox2.Visible = false;
            OpenChildForm(new Thông_tin(GiaoDienNguoiThue.Instance.lbUsername.Text, true));
        }

        private void btnDsPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DanhSachThuePhong(lbUsername.Text));
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                GiaoDienNguoiThue.Instance = null;
                GiaoDienChung.Instance = null;
                Destop_GUI.Instance.LoadForm(new GiaoDienChung());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
