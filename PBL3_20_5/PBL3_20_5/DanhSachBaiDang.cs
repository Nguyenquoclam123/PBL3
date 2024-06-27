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
    public partial class DanhSachBaiDang : Form
    {
        Manager manager;
        public DanhSachBaiDang(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
            setCBBIDMotel();
            dataGridView1.DataSource = BLL_Manager.Instance.getAllPostByIdMotel(cbbIDMotel.Text);
        }

        public void setCBBIDMotel()
        {
            List<string> list = BLL_Manager.Instance.getIdMotelbyManager(manager.ID);
            cbbIDMotel.Items.Clear();
            cbbIDMotel.Items.AddRange(list.ToArray());
            if (cbbIDMotel.Items.Count == 0)
            {
            }
            else
                cbbIDMotel.SelectedIndex = 0;
        }

        private void cbbIDMotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbIDMotel.Items.Count == 0)
            {
                dataGridView1.DataSource = BLL_Manager.Instance.getAllPostByIdMotel("");
            }
            else
                dataGridView1.DataSource = BLL_Manager.Instance.getAllPostByIdMotel(cbbIDMotel.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            int postId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string title = (dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            string price = (dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            string address = (dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            string description = (dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            string approvalstatus = (dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            string idmotel = (dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
            string imgpath = (dataGridView1.SelectedRows[0].Cells[7].Value.ToString());

            //MessageBox.Show(postId + " " + title + " " + address + " " + description + " " + approvalstatus + " " + idmotel + " " + imgpath);
            Post post = new Post();
            post.PostID = postId;
            post.Title = title;
            post.Price = price;
            post.Address = address;
            post.Description = description;
            post.ApprovalStatus = approvalstatus;
            post.ID_Motel = idmotel;
            post.ImagePaths = imgpath;
            BLL_Manager.Instance.EditPost(post);
            dataGridView1.DataSource = BLL_Manager.Instance.getAllPostByIdMotel(cbbIDMotel.Text);
        }


        //btn xoa
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int postId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                BLL_Manager.Instance.DelPost(postId);
                dataGridView1.DataSource = BLL_Manager.Instance.getAllPostByIdMotel(cbbIDMotel.Text);
            }

        }

        private void lbIDMotel_Click(object sender, EventArgs e)
        {

        }
    }
}
