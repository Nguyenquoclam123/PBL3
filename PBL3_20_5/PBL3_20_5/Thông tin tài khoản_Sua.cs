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
    public partial class Thông_tin_tài_khoản_Sua : UserControl
    {
        public delegate void MyDel();
        public MyDel d;
        private string username;
        public Thông_tin_tài_khoản_Sua(string un)
        {
            InitializeComponent();
            username = un;
            SetView(username);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            d();
        }
        public void SetView(string username)
        {
            try
            {
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show(username);
                    MessageBox.Show("Username is null or empty.");
                    return;
                }

                string sdt = BLL_Admin.Instance.Get_Phone_by_UserName(username);

                if (string.IsNullOrEmpty(sdt))
                {
                    MessageBox.Show("Phone number not found for the given username.");
                    return;
                }

                Person person = BLL_Admin.Instance.Get_Person(sdt);

                if (person == null)
                {
                    MessageBox.Show("Person not found for the given phone number.");
                    return;
                }

                textBox_ten.Text = person.fullName;
                textBox_Tuoi.Text = person.Age.ToString();
                textBox_Diachi.Text = person.fullAddress;
                textBox_SoDienThoai.Text = person.Phone;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            string Ten = textBox_ten.Text;
            int Age = Convert.ToInt32(textBox_Tuoi.Text);
            string Address = textBox_Diachi.Text;
            string Phone = textBox_SoDienThoai.Text;
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn lưu các thay đổi này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Kiểm tra phản hồi của người dùng
            if (result == DialogResult.OK)
            {
                // Người dùng chọn OK, thực hiện hành động chỉnh sửa thông tin
                BLL_Admin.Instance.Edit_Person(Ten, Age, Phone, Address);
                MessageBox.Show("Thông tin đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
