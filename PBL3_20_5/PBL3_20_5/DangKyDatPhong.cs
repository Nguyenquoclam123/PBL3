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
    public partial class DangKyDatPhong : Form
    {
        public string Username { get; set; }
        public string IDRoom { get; set; }
        public DangKyDatPhong()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void b_DangKy_Click(object sender, EventArgs e)
        {
            BLL_RegisterRoom.Instance.addRR(Username, t_HoTen.Text, t_SDT.Text, dtNs.Value, t_CongViec.Text, t_QueQuan.Text, IDRoom);
            MessageBox.Show("Đăng ký thành công");
            this.Close();
            //GiaoDienNguoiThue f = new GiaoDienNguoiThue();
            //f.del += new GiaoDienNguoiThue.MyDel(Set);
            //BLL_Room.Instance.Add(GiaoDienNguoiThue.UserName, t_HoTen.Text, t_SDT.Text, dateTimePicker1.Value.Date, t_CongViec.Text, t_QueQuan.Text, "Chua duyet", ID_Motel, ID_Room);
        }
    }
}
