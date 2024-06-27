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
    public partial class Thông_tin_tài_khoản : UserControl
    {
        public delegate void MyDel();
        public MyDel d;

        private string username;
        public Thông_tin_tài_khoản(string un)
        {
            InitializeComponent();
            username = un;
            SetView(username);
        }

        public void SetView(string username)
        {
            try
            {
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show(username);
                    MessageBox.Show("Username is null or empty.");
                    return;
                }

                string sdt = BLL_Admin.Instance.Get_Phone_by_UserName(username);

                if (string.IsNullOrEmpty(sdt))
                {
                    MessageBox.Show("Phone number not found for the given username.");
                    return;
                }

                Person person = BLL_Admin.Instance.Get_Person(sdt);

                if (person == null)
                {
                    MessageBox.Show("Person not found for the given phone number.");
                    return;
                }

                textBox_ten.Text = person.fullName;
                textBox_Tuoi.Text = person.Age.ToString();
                textBox_Diachi.Text = person.fullAddress;
                textBox_SoDienThoai.Text = person.Phone;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void label_SuaThongTin_Click(object sender, EventArgs e)
        {
            d();
        }


    }
}
