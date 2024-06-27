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
    public partial class DanhSachThuePhong : Form
    {
        private string username;
        public DanhSachThuePhong(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadRegisterRoom(this.username);
        }

        public void LoadRegisterRoom(string username)
        {
            dataGridView1.DataSource = BLL_RegisterRoom.Instance.getRegisterRoomByUsername(username);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiaoDienNguoiThue.Instance.CallNewForm();
        }
    }
}
