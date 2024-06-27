using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace PBL3_20_5
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void b_DangKy_Click(object sender, EventArgs e)
        {
            if (BLL_Account.Instance.RegistNewAccount(t_TaiKhoan.Text, t_MatKhau.Text, t_MatKhauAgain.Text, t_HoTen.Text, t_Age.Text != "" ? Convert.ToInt32(t_Age.Text) : 0, t_SDT.Text, t_QueQuan.Text, t_MaSo.Text))
            {
                this.Close();
                (new DangNhap()).Show();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_MatKhau.PasswordChar == '*')
            {
                t_MatKhau.PasswordChar = '\0';
            }
            else
                t_MatKhau.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t_MatKhauAgain.PasswordChar == '*')
            {
                t_MatKhauAgain.PasswordChar = '\0';
            }
            else
                t_MatKhauAgain.PasswordChar = '*';
        }
    }
}
