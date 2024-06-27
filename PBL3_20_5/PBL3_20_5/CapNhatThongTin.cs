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
    public partial class CapNhatThongTin : Form
    {
        public CapNhatThongTin()
        {
            InitializeComponent();
            SetUp();
        }
        private void SetUp()
        {
            //t_fullName.Text = BLL_Person.Instance.Setup(GiaoDienNguoiThue.UserName).fullName;
            //t_Age.Text = BLL_Person.Instance.Setup(GiaoDienNguoiThue.UserName).Age.ToString();
            //t_Phone.Text = BLL_Person.Instance.Setup(GiaoDienNguoiThue.UserName).Phone;
            //t_Address.Text = BLL_Person.Instance.Setup(GiaoDienNguoiThue.UserName).fullAddress;
        }
        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t_Address.ReadOnly = false;
            t_fullName.ReadOnly = false;
            t_Age.ReadOnly = false;
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLL_Person.Instance.Update(t_fullName.Text, Int32.Parse(t_Age.Text), t_Phone.Text, t_fullName.Text);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau();
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Set()
        {
            t_Address.ReadOnly = false;
            t_fullName.ReadOnly = false;
            t_Age.ReadOnly = false;
        }
    }
}
