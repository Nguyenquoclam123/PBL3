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
    public partial class QuanLyBaiLuan : UserControl
    {
        public QuanLyBaiLuan()
        {
            InitializeComponent();
            View_DGV();
        }

        public void Reset_View()
        {
            textBox_IdComment.Text = "";
            textBox_BaiDang.Text = "";
            textBox_TenTaiKhoan.Text = "";
            textBox_BinhLuan.Text = "";
            textBox_Ngay.Text = "";
        }

        public void View_DGV()
        {
            dataGridView1.DataSource = BLL_Admin.Instance.DanhSachComment();
        }



        private void button_Xoa_Click_1(object sender, EventArgs e)
        {
            if (textBox_IdComment.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bình luận để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Dừng thực thi hàm
            }
            // Lấy idcomment từ TextBox
            int idcomment = Convert.ToInt32(textBox_IdComment.Text);

            // Hỏi người dùng xác nhận trước khi thực hiện hành động
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bình luận này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả của hộp thoại xác nhận
            if (result == DialogResult.Yes)
            {
                // Gọi phương thức để xóa bình luận
                BLL_Admin.Instance.Del_Comment(idcomment);

                // Cập nhật DataGridView
                View_DGV();
                Reset_View();
            }
            else
            {
                // Người dùng chọn No, không làm gì cả
                // MessageBox.Show("Hành động đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox_IdComment.Text = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            textBox_BaiDang.Text = dataGridView1.SelectedRows[0].Cells["PostID"].Value.ToString();
            textBox_TenTaiKhoan.Text = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();
            textBox_BinhLuan.Text = dataGridView1.SelectedRows[0].Cells["CommentText"].Value.ToString();
            textBox_Ngay.Text = dataGridView1.SelectedRows[0].Cells["CommentDate"].Value.ToString();
        }

        private void label_BinhLuan_Click(object sender, EventArgs e)
        {


        }

        private void button_XemchitietBaiDang_Click(object sender, EventArgs e)
        {
            if (textBox_IdComment.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bình luận để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Dừng thực thi hàm
            }
            int postid = Convert.ToInt32(textBox_BaiDang.Text);
            ChiTietBaiDang form = new ChiTietBaiDang(postid);
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }




}
