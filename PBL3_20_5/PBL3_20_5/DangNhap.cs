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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void b_QMK_Click(object sender, EventArgs e)
        {
            QuenMatKhau f = new QuenMatKhau();
            f.Show();
        }

        private void b_DangNhap_Click(object sender, EventArgs e)
        {
            Account account = BLL_Account.Instance.Login(t_TaiKhoan.Text, t_MatKhau.Text);
            if (account != null)
            {
                MessageBox.Show("Đăng nhập thành công");
                GiaoDienChung.Instance.btnDangnhap.Visible = false;
                GiaoDienChung.Instance.btnDangKy.Visible = false;
                GiaoDienChung.Instance.pbArow.Visible = true;
                GiaoDienChung.Instance.lbUsername.Visible = true;
                GiaoDienChung.Instance.lbUsername.Text = account.userName;
                GiaoDienChung.Instance.lbUserComment.Text = account.userName;
                this.Close();
                switch (account.Position)
                {
                    case "Admin":
                        Destop_GUI.Instance.LoadForm(new GiaoDienAdmin(account.userName));
                        break;
                    case "Manager":
                        Manager manager = BLL_Manager.Instance.getManagerByPhone(account.Phone);
                        GiaoDienChuTro form = new GiaoDienChuTro(manager);
                        form.lbUsername.Text = account.userName;
                        Destop_GUI.Instance.LoadForm(form);
                        break;
                    case "Renter":
                        GiaoDienNguoiThue f_NguoiThue = new GiaoDienNguoiThue();
                        f_NguoiThue.lbUsername.Text = account.userName;
                        Destop_GUI.Instance.LoadForm(f_NguoiThue);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }
        }

        private void b_DangKy_Click(object sender, EventArgs e)
        {
            DangKy f = new DangKy();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(t_MatKhau.PasswordChar == '*')
            {
                t_MatKhau.PasswordChar = '\0';
            }
            else
                t_MatKhau.PasswordChar = '*';
        }
    }
}
