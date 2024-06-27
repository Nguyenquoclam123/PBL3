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
    public partial class XemChiTietYC : Form
    {
        public RegisterRoom registerRoom;
        public XemChiTietYC(RegisterRoom registerRoom)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.registerRoom = registerRoom;
            //this.BackColor = ColorTranslator.FromHtml("#f1f5f9");
            LoadDetail();

        }

        public void LoadDetail()
        {
            this.lbName.Text = registerRoom.fullName;
            this.lbUsername.Text = registerRoom.UserName;
            this.lbPhoneNB.Text = registerRoom.Phone;
            this.lbBirthday.Text = registerRoom.BirthDate.ToString();
            this.lbJob.Text = registerRoom.Job;
            this.lbHomeTown.Text = registerRoom.HomeTown;
            this.lbState.Text = registerRoom.Note;
            this.lbIdroom.Text = registerRoom.ID_Room;
        }

    }
}
