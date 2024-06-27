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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void b_KiemTra_Click(object sender, EventArgs e)
        {
            t_MatKhau.Text = BLL_Account.Instance.TakePassWord(t_TaiKhoan.Text, t_SDT.Text);
        }
    }
}
