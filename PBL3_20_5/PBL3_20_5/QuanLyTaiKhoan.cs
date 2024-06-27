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
    public partial class QuanLyTaiKhoan : UserControl
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            View_DGV();
        }
        public void Reset_View()
        {
            textBox_TenTaiKhoan.Text = "";
            textBox_MatKhau.Text = "";
            textBox_SoDienThoai.Text = "";
            textBox_ChucVu.Text = "";
        }
        public void View_DGV()
        {
            dataGridView1.DataSource = BLL_Admin.Instance.DanhSachAccount();
        }


        //

        private void button_Them_Click_1(object sender, EventArgs e)
        {
            ThemTaiKhoan form1 = new ThemTaiKhoan();
            form1.d += new ThemTaiKhoan.MyDel(BLL_Admin.Instance.Add_Account);
            form1.d_View_DGV += new ThemTaiKhoan.MyDel_View_DGC(View_DGV);
            form1.ShowDialog();
        }

        private void button_Sua_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (textBox_TenTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Dừng thực thi hàm
            }
            string UserName = textBox_TenTaiKhoan.Text;
            SuaTaiKhoan form1 = new SuaTaiKhoan(UserName);
            form1.d += new SuaTaiKhoan.MyDel(BLL_Admin.Instance.Edit_Account);
            form1.d_View_DGV += new SuaTaiKhoan.MyDel_View_DGC(View_DGV);
            form1.ShowDialog();
        }

        private void button_Xoa_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (textBox_TenTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Dừng thực thi hàm
            }
            string username = textBox_TenTaiKhoan.Text;

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản {username} không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Kiểm tra phản hồi của người dùng
            if (result == DialogResult.OK)
            {
                // Người dùng chọn OK, thực hiện hành động xóa tài khoản
                BLL_Admin.Instance.Del_Account(username);
                View_DGV();
                MessageBox.Show("Tài khoản đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset_View();
            }
            else
            {
                // Người dùng chọn Cancel, không làm gì cả
                //MessageBox.Show("Hành động xóa tài khoản đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox_TenTaiKhoan.Text = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();
            textBox_MatKhau.Text = dataGridView1.SelectedRows[0].Cells["PassWord"].Value.ToString();
            textBox_SoDienThoai.Text = dataGridView1.SelectedRows[0].Cells["Phone"].Value.ToString();
            textBox_ChucVu.Text = dataGridView1.SelectedRows[0].Cells["Position"].Value.ToString();
        }

        private void label_Matkhau_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            string Posision = comboBox1.SelectedItem.ToString();
            if (Posision == "Tất cả")
            {
                dataGridView1.DataSource = BLL_Admin.Instance.DanhSachAccount();
                Reset_View();
            }
            else if (Posision == "Admin")
            {
                dataGridView1.DataSource = BLL_Admin.Instance.DanhSachAdmin();
                Reset_View();
            }
            else if (Posision == "Manager")
            {
                dataGridView1.DataSource = BLL_Admin.Instance.DanhSachManager();
                Reset_View();
            }
            else if (Posision == "Renter")
            {
                dataGridView1.DataSource = BLL_Admin.Instance.DanhSachRenter();
                Reset_View();
            }
        }
    }



}
