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
    public partial class DuyetYeuCau : Form
    {
        Manager manager;
        public DuyetYeuCau(Manager manager)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.manager = manager;
            loadRegister();
        }
        public void loadRegister()
        {
            foreach (RegisterRoom registerRoom in BLL_RegisterRoom.Instance.getRegisterRoomByState(manager.ID))
            { 

                Panel pnItem = new Panel();
                pnItem.Size = new System.Drawing.Size(pnApprove.Width - 20, 60);
                pnItem.BorderStyle = BorderStyle.FixedSingle;


                Label lb1 = new Label();
                lb1.Location = new System.Drawing.Point(pnItem.Location.X + 5, pnItem.Location.Y + 22);
                lb1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb1.Size = new System.Drawing.Size(186, 34);
                lb1.Text = registerRoom.fullName;

                Button btnRefuse = new Button();
                btnRefuse.Location = new System.Drawing.Point(pnItem.Location.X + pnItem.Width - 360, pnItem.Location.Y + 7);
                btnRefuse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnRefuse.UseVisualStyleBackColor = true;
                btnRefuse.Size = new System.Drawing.Size(115, 45);
                btnRefuse.Text = "Từ chối";
                btnRefuse.Click += delegate (object sender, EventArgs e)
                {
                    //cập nhật trang thái của Register
                    registerRoom.Note = "Từ chối";
                    BLL_RegisterRoom.Instance.EditRR(registerRoom);

                    //Cập nhật trạng thái của phòng
                    Room room = BLL_Manager.Instance.getRoomByID(registerRoom.ID_Room);
                    //  room.RoomState = "Chưa thuê";
                    BLL_Manager.Instance.editRoom(room);
                    pnApprove.Controls.Remove(pnItem);
                };

                Button btnDetail = new Button();
                btnDetail.Location = new System.Drawing.Point(pnItem.Location.X + pnItem.Width - 240, pnItem.Location.Y + 7);
                btnDetail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnDetail.UseVisualStyleBackColor = true;
                btnDetail.Size = new System.Drawing.Size(115, 45);
                btnDetail.Text = "Chi tiết";

                //gan su kien cho ctndetail
                btnDetail.Click += delegate (object sender, EventArgs e)
                {
                    XemChiTietYC xemChiTietYCThue = new XemChiTietYC(registerRoom);
                    xemChiTietYCThue.Show();
                };


                Button btnApprove = new Button();
                btnApprove.Location = new System.Drawing.Point(pnItem.Location.X + pnItem.Width - 120, pnItem.Location.Y + 7);
                btnApprove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnApprove.UseVisualStyleBackColor = true;
                btnApprove.Size = new System.Drawing.Size(115, 45);
                btnApprove.Text = "Duyệt";

                //gan su kien cho btnApprove
                btnApprove.Click += delegate (object sender, EventArgs e)
                {

                    if (BLL_Manager.Instance.getRoomByID(registerRoom.ID_Room).RoomState == "Chưa thuê")
                    {
                        //cập nhật trang thái của Register
                        registerRoom.Note = "Duyệt";
                        BLL_RegisterRoom.Instance.EditRR(registerRoom);


                        //Cập nhật trạng thái của phòng
                        Room room = BLL_Manager.Instance.getRoomByID(registerRoom.ID_Room);
                        room.RoomState = "Đã thuê";
                        BLL_Manager.Instance.editRoom(room);
                        pnApprove.Controls.Remove(pnItem);
                    }
                    else
                    {
                        MessageBox.Show("Phong này đã được thuê");
                    }
                };

                pnItem.Controls.Add(btnRefuse);
                pnItem.Controls.Add(lb1);
                pnItem.Controls.Add(btnApprove);
                pnItem.Controls.Add(btnDetail);
                pnApprove.Controls.Add(pnItem);
            }

        }

        private void DuyetYeuCau_Load(object sender, EventArgs e)
        {

        }
    }
}
