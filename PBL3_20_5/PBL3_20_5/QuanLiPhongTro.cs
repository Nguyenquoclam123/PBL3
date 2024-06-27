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
    public partial class QuanLiPhongTro : Form
    {
        Manager manager;
        public QuanLiPhongTro(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
            setCBBIDMotel();
            setDGV();
        }

        public void setCBBIDMotel()
        {
            List<string> list = BLL_Manager.Instance.getIdMotelbyManager(manager.ID);
            cbbIDMotel.Items.Clear();
            cbbIDMotel.Items.AddRange(list.ToArray());
        }

        public void setDGV()
        {
            if (cbbIDMotel.Items.Count == 0)
            {
                dataGridView1.DataSource = BLL_Manager.Instance.getAllRoomByIDMotel("");
            }
            else
            {
                cbbIDMotel.SelectedIndex = 0;
                dataGridView1.DataSource = BLL_Manager.Instance.getAllRoomByIDMotel(cbbIDMotel.SelectedItem.ToString());
            }
        }

        private void cbbIDMotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DTO.Room> list = BLL_Manager.Instance.getAllRoomByIDMotel(cbbIDMotel.SelectedItem.ToString());
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idroom = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DTO.Room room = BLL_Manager.Instance.getRoomByID(idroom.ToString());

            tbIDRoom.Text = room.ID_Room.ToString();
            tbDescription.Text = room.fullDescription.ToString();
            tbStatus.Text = room.RoomState.ToString();
            tbPrice.Text = room.Price.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbIDRoom.Text = "";
            tbDescription.Text = "";
            tbStatus.Text = "";
            tbPrice.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbIDRoom.Text == "" || tbPrice.Text == "" || tbStatus.Text == "" || tbDescription.Text == "")
            {
                MessageBox.Show("Khong duoc de trong");
                return;
            }
            if (Convert.ToInt32(tbPrice.Text) < 0)
            {
                MessageBox.Show("Giá trị không hợp lệ");
                return;
            }

            if (BLL_Manager.Instance.checkIdRoom(tbIDRoom.Text, cbbIDMotel.SelectedItem.ToString()) == true)
            {
                MessageBox.Show("ID da ton tai hoac ID nhap chua dung dinh dang");
                return;
            }

            DTO.Room room = new DTO.Room();
            room.ID_Motel = cbbIDMotel.SelectedItem.ToString();
            room.ID_Room = tbIDRoom.Text;
            room.fullDescription = tbDescription.Text;
            room.RoomState = tbStatus.Text;
            //room.RoomState = "Chưa thuê";
            room.Price = Convert.ToDouble(tbPrice.Text);

            BLL_Manager.Instance.addRoom(room);
            dataGridView1.DataSource = BLL_Manager.Instance.getAllRoomByIDMotel(cbbIDMotel.SelectedItem.ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbIDRoom.Text == "" || tbPrice.Text == "" || tbStatus.Text == "" || tbDescription.Text == "")
            {
                MessageBox.Show("Khong duoc de trong");
                return;
            }
            DTO.Room room = new DTO.Room();
            room.ID_Motel = cbbIDMotel.SelectedItem.ToString();
            room.ID_Room = tbIDRoom.Text;
            room.fullDescription = tbDescription.Text;
            room.RoomState = tbStatus.Text;
            room.Price = Convert.ToDouble(tbPrice.Text);

            BLL_Manager.Instance.editRoom(room);
            dataGridView1.DataSource = BLL_Manager.Instance.getAllRoomByIDMotel(cbbIDMotel.SelectedItem.ToString());
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string idroom = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string idmotel = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            BLL_Manager.Instance.delRoom(idroom, idmotel);
            dataGridView1.DataSource = BLL_Manager.Instance.getAllRoomByIDMotel(cbbIDMotel.SelectedItem.ToString());
        }

        private void QuanLiPhongTro_Load(object sender, EventArgs e)
        {

        }

        private void tbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
