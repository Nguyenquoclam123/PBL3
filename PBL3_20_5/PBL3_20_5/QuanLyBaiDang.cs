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
    public partial class QuanLyBaiDang : UserControl
    {
        private string username;
        public QuanLyBaiDang(string un)
        {
            InitializeComponent();
            View_DGV();
            username = un;
        }

        public void Reset_Veiw()
        {
            textBox_TieuDe.Text = "";
            textBox_MoTa.Text = "";
            textBox_Gia.Text = "";
            textBox_DiaChi.Text = "";
            textBox_HinhAnh.Text = "";
            textBox_TrangThai.Text = "";
            textBox_idmotel.Text = "";
            textBox_PostID.Text = "";

            // Xóa các PictureBox cũ trong pnImage trước khi thêm mới
            pnImage.Controls.Clear();
        }
        public void View_DGV()
        {
            dataGridView1.DataSource = BLL_Admin.Instance.DanhSachPost();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox_TieuDe.Text = row.Cells["Title"].Value.ToString();
                textBox_MoTa.Text = row.Cells["Description"].Value.ToString();
                textBox_Gia.Text = row.Cells["Price"].Value.ToString();
                textBox_DiaChi.Text = row.Cells["Address"].Value.ToString();
                textBox_HinhAnh.Text = row.Cells["ImagePaths"].Value.ToString();
                textBox_TrangThai.Text = row.Cells["ApprovalStatus"].Value.ToString();
                textBox_idmotel.Text = row.Cells["ID_Motel"].Value.ToString();
                textBox_PostID.Text = row.Cells["PostID"].Value.ToString();

                // Xóa các PictureBox cũ trong pnImage trước khi thêm mới
                pnImage.Controls.Clear();

                // Lấy danh sách đường dẫn từ TextBox_HinhAnh
                List<string> list = ExtractPaths(textBox_HinhAnh.Text);

                // Thêm mỗi hình ảnh vào pnImage
                foreach (string i in list)
                {
                    // Bỏ dấu ngoặc kép để sử dụng trong ImageLocation
                    string imagePath = i.Trim('"');

                    // Kiểm tra xem đường dẫn hình ảnh có hợp lệ hay không

                    PictureBox pictureBox = new PictureBox
                    {
                        Width = 100,
                        Height = pnImage.Height - 6,
                        ImageLocation = imagePath,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Thêm PictureBox vào Panel (pnImage)
                    pnImage.Controls.Add(pictureBox);



                }

            }
        }

        private List<string> ExtractPaths(string input)
        {
            List<string> paths = new List<string>();

            // Tách các đường dẫn bằng dấu cách, tuy nhiên cần xử lý đúng định dạng các dấu ngoặc đơn
            string[] pathArray = input.Split(new string[] { ") (" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string path in pathArray)
            {
                // Loại bỏ khoảng trắng ở đầu và cuối chuỗi
                string trimmedPath = path.Trim(new char[] { ' ', '(', ')' });

                // Thêm vào danh sách các đường dẫn đã định dạng đúng và bổ sung dấu ngoặc kép
                paths.Add('"' + trimmedPath + '"');
            }

            return paths;
        }




        private void button_Duyet_Click(object sender, EventArgs e)
        {
            if (textBox_PostID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bài đăng để duyệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Dừng thực thi hàm
            }

            // Lấy postid từ TextBox
            int postid = Convert.ToInt32(textBox_PostID.Text);

            if (textBox_TrangThai.Text == "Đã duyệt")
            {
                MessageBox.Show("Bài đăng này đã được duyệt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Dừng thực thi hàm và không thực hiện các hành động tiếp theo
            }
            // Hỏi người dùng xác nhận trước khi thực hiện hành động
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn duyệt bài đăng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả của hộp thoại xác nhận
            if (result == DialogResult.Yes)
            {
                // Gọi phương thức để duyệt bài đăng
                BLL_Admin.Instance.Browse_Post(postid);

                // Cập nhật DataGridView
                View_DGV();
                textBox_TrangThai.Text = "Đã duyệt";
            }
            else
            {
                // Người dùng chọn No, không làm gì cả
                // MessageBox.Show("Hành động đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (textBox_PostID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bài đăng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Dừng thực thi hàm
            }
            // Lấy postid từ TextBox
            int postid = Convert.ToInt32(textBox_PostID.Text);

            // Hỏi người dùng xác nhận trước khi thực hiện hành động
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bài đăng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả của hộp thoại xác nhận
            if (result == DialogResult.Yes)
            {
                BLL_Admin.Instance.Del_Comment_by_Post(postid);
                // Gọi phương thức để xóa bài đăng
                BLL_Admin.Instance.Del_Post(postid);

                // Cập nhật DataGridView
                View_DGV();
                Reset_Veiw();
            }
            else
            {
                // Người dùng chọn No, không làm gì cả
                // MessageBox.Show("Hành động đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void textBox_TrangThai_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_ChuaDuyet_Click(object sender, EventArgs e)
        {
            Reset_Veiw();
            dataGridView1.DataSource = BLL_Admin.Instance.DanhSachPostChuaDuyet();
        }

        private void button_DaDuyet_Click(object sender, EventArgs e)
        {
            Reset_Veiw();
            dataGridView1.DataSource = BLL_Admin.Instance.DanhSachPostDaDuyet();
        }

        private void button_All_Click(object sender, EventArgs e)
        {
            Reset_Veiw();
            dataGridView1.DataSource = BLL_Admin.Instance.DanhSachPost();
        }
    }



}
