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
    public partial class DanhSachThue : Form
    {
        private Manager manager;
        public DanhSachThue(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
            setCBBIDMotel();
        }

        public void setCBBIDMotel()
        {
            List<string> list = BLL_Manager.Instance.getIdMotelbyManager(manager.ID);
            cbbIDMotel.Items.Clear();
            cbbIDMotel.Items.AddRange(list.ToArray());

            if (cbbIDMotel.Items.Count == 0)
            {
                dataGridView1.DataSource = BLL_RegisterRoom.Instance.getRegisterRoomByIdMotel("");
            }
            else
            {
                cbbIDMotel.SelectedIndex = 0;
                dataGridView1.DataSource = BLL_RegisterRoom.Instance.getRegisterRoomByIdMotel(cbbIDMotel.SelectedItem.ToString());
            }
        }

        private void cbbIDMotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_RegisterRoom.Instance.getRegisterRoomByIdMotel(cbbIDMotel.SelectedItem.ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string username = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string fullname = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string phone = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            DateTime birthday = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            string job = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            string hometown = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            string note = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            string idroom = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

            RegisterRoom registerR = new RegisterRoom();
            registerR.ID = id;
            registerR.UserName = username;
            registerR.fullName = username;
            registerR.Phone = phone;
            registerR.BirthDate = birthday;
            registerR.Job = job;
            registerR.HomeTown = hometown;
            registerR.Note = note;
            registerR.ID_Room = idroom;
            int itrr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            BLL_RegisterRoom.Instance.EditRR(registerR);
            dataGridView1.DataSource = BLL_RegisterRoom.Instance.getRegisterRoomByIdMotel(cbbIDMotel.SelectedItem.ToString());
        }

        //btn xoa
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int itrr = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                BLL_RegisterRoom.Instance.DelRR(itrr);
                dataGridView1.DataSource = BLL_RegisterRoom.Instance.getRegisterRoomByIdMotel(cbbIDMotel.SelectedItem.ToString());
            }
        }
    }
}
