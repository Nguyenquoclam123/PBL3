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
    public partial class Thay_đổi_mật_khẩu : UserControl
    {
        public event EventHandler CancelClicked;
        public delegate void MyDel();
        public MyDel d;

        private string username;
        public Thay_đổi_mật_khẩu(string un)
        {
            InitializeComponent();
            username = un;

        }

        public void ChangesPassWork(string username)
        {
            string MKCU = textBox_MKCu.Text;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Destop_GUI.Instance.LoadForm(GiaoDienAdmin.Instance);
            CancelClicked?.Invoke(this, EventArgs.Empty);
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MKCu.Text) || string.IsNullOrEmpty(textBox_MKCu.Text) || string.IsNullOrEmpty(textBox_MKCu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            string MKCU = textBox_MKCu.Text;
            string MKMOI = textBox_MKMoi.Text;
            string NHAPLAI = textBox_NhapLaiMKMoi.Text;
            if (MKCU != BLL_Admin.Instance.Get_PassWork_by_UserName(username))
            {
                MessageBox.Show("Mật khẩu cũ chưa đúng");
            }
            else
            {
                // Hiển thị hộp thoại xác nhận trước khi thay đổi mật khẩu
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thay đổi mật khẩu không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                // Kiểm tra phản hồi của người dùng
                if (result == DialogResult.OK)
                {
                    // Người dùng chọn OK, thực hiện hành động thay đổi mật khẩu
                    BLL_Admin.Instance.ChangesPassWork(username, MKCU, MKMOI, NHAPLAI);
                    MessageBox.Show("Mật khẩu đã được thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Người dùng chọn Cancel, không làm gì cả
                    // MessageBox.Show("Thay đổi mật khẩu đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void ChangePassWord(TextBox t)
        {
            if (t.PasswordChar == '*')
            {
                t.PasswordChar = '\0';
            }
            else
                t.PasswordChar = '*';
        }
        private void Thay_đổi_mật_khẩu_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePassWord(textBox_MKMoi);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePassWord(textBox_NhapLaiMKMoi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePassWord(textBox_MKCu);
        }
    }
}
