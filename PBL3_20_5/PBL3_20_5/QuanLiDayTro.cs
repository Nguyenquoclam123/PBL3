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
    public partial class QuanLiDayTro : Form
    {
        Manager manager;
        public QuanLiDayTro(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
            tbID_Manager.Text = manager.ID;
            SetDGV();
        }
        public void SetDGV()
        {
            dataGridView1.DataSource = BLL_Manager.Instance.getAllMotelForManager(manager.ID);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idmotel = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Motel motel = BLL_Manager.Instance.getMotelByID(idmotel);
            tbID_Motel.Text = manager.ID;
            tbID_Manager.Text = motel.ID_Manager.ToString();
            tbNumRoom.Text = motel.NumRoom.ToString();
            tbFullAddress.Text = motel.fullAddress.ToString();
            tbFulllDescription.Text = motel.fullDescription.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbID_Motel.Text == "" || tbID_Manager.Text == "" || tbNumRoom.Text == "" || tbFullAddress.Text == "" || tbFulllDescription.Text == "")
            {
                MessageBox.Show("Khong duoc de trong");
                return;
            }
            Motel motel = new Motel();
            motel.ID_Motel = tbID_Motel.Text;
            motel.ID_Manager = tbID_Manager.Text;
            motel.NumRoom = Convert.ToInt32(tbNumRoom.Text);
            motel.fullAddress = tbFullAddress.Text;
            motel.fullDescription = tbFulllDescription.Text;
            BLL_Manager.Instance.AddMotel(motel);
            SetDGV();
            //dataGridView1.DataSource = BLL_Manager.Instance.getAllMotel();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbID_Motel.Text == "" || tbID_Manager.Text == "" || tbNumRoom.Text == "" || tbFullAddress.Text == "" || tbFulllDescription.Text == "")
            {
                MessageBox.Show("Khong duoc de trong");
                return;
            }
            Motel motel = new Motel();
            motel.ID_Motel = tbID_Motel.Text;
            motel.ID_Manager = tbID_Manager.Text;
            motel.NumRoom = Convert.ToInt32(tbNumRoom.Text);
            motel.fullAddress = tbFullAddress.Text;
            motel.fullDescription = tbFulllDescription.Text;

            BLL_Manager.Instance.Update(motel);
            SetDGV();
            //dataGridView1.DataSource = BLL_Manager.Instance.getAllMotel();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (BLL_Manager.Instance.getMotelByID(tbID_Motel.Text) != null)
            {
                BLL_Manager.Instance.Del(tbID_Motel.Text);
                dataGridView1.DataSource = BLL_Manager.Instance.getAllMotel();
            }
            else
            {
                MessageBox.Show("Id nay khong co du lieu");
                return;
            }
            SetDGV();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbID_Motel.Text = "";
            tbID_Manager.Text = "";
            tbNumRoom.Text = "";
            tbFullAddress.Text = "";
            tbFulllDescription.Text = "";
        }

        private void QuanLiDayTro_Load(object sender, EventArgs e)
        {

        }
    }
}
