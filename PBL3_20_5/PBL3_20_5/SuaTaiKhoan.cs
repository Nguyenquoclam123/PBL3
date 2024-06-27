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
    public partial class SuaTaiKhoan : Form
    {
        // Edit
        public delegate void MyDel(string m, string n, string p, string q);
        public MyDel d;
        // View_DGV_QuanLiTaiKhoan
        public delegate void MyDel_View_DGC();
        public MyDel_View_DGC d_View_DGV;
        private string UserName;
        public SuaTaiKhoan(string userName)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            UserName = userName;
            Set_View(userName);
        }
        public void Set_View(string Username)
        {
            Account account = BLL_Admin.Instance.Get_Account_By_UserName(UserName);
            if (account == null)
            {
                MessageBox.Show("Account not found.");
                return;
            }
            textBox_TenTaiKhoan.Text = account.userName.ToString();
            textBox_TenTaiKhoan.ReadOnly = true;
            textBox_MatKhau.Text = account.PassWord.ToString();
            textBox_SoDienThoai.Text = account.Phone.ToString();
            textBox_ChucVu.Text = account.Position.ToString();
        }

        private void button_XacNhan_Click(object sender, EventArgs e)
        {
            // Hỏi người dùng có muốn xác nhận hành động hay không
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xác nhận không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả của hộp thoại xác nhận
            if (result == DialogResult.Yes)
            {
                // Lấy giá trị từ các TextBox
                string username = textBox_TenTaiKhoan.Text;
                string matkhau = textBox_MatKhau.Text;
                string sodienthoai = textBox_SoDienThoai.Text;
                string chucvu = textBox_ChucVu.Text;

                // Kiểm tra xem các delegate có được gán giá trị hay không
                if (d != null)
                {
                    d(username, matkhau, sodienthoai, chucvu);
                }
                else
                {
                    MessageBox.Show("Delegate d chưa được gán giá trị.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (d_View_DGV != null)
                {
                    d_View_DGV();
                }
                else
                {
                    MessageBox.Show("Delegate d_View_DGV chưa được gán giá trị.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Đóng form sau khi hoàn thành
                this.Dispose();
            }
            else
            {
                // Người dùng chọn No, không làm gì cả
                //MessageBox.Show("Hành động đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }


}
