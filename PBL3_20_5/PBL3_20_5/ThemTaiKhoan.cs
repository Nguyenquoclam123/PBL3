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
    public partial class ThemTaiKhoan : Form
    {
        // Add
        public delegate void MyDel(string x, int y, string z, string m, string n, string p, string q, string id);
        public MyDel d;
        // View_DGV_QuanLiTaiKhoan
        public delegate void MyDel_View_DGC();
        public MyDel_View_DGC d_View_DGV;
        public ThemTaiKhoan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            // Hỏi người dùng xác nhận trước khi thực hiện hành động
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm thông tin này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả của hộp thoại xác nhận
            if (result == DialogResult.Yes)
            {
                // Lấy thông tin từ các TextBox
                string name = textBox_ten.Text;
                int tuoi = Convert.ToInt32(textBox_Tuoi.Text);
                string ID = textBox1.Text;
                string diachi = textBox_Diachi.Text;
                string UserName = textBox_TenTaiKhoan.Text;
                string PassWord = textBox_MatKhau.Text;
                string Phone = textBox_SoDienThoai.Text;
                string Position = "Manager";

                // Gọi delegate để thêm thông tin
                d(name, tuoi, diachi, UserName, PassWord, Phone, Position, ID);

                // Cập nhật DataGridView
                d_View_DGV();

                // Đóng form sau khi hoàn thành
                this.Dispose();
            }
            else
            {
                // Người dùng chọn No, không làm gì cả
                // MessageBox.Show("Hành động đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }






}
