using DAL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BLL
{
    public class BLL_RegisterRoom
    {
        private static BLL_RegisterRoom _Instance;
        public static BLL_RegisterRoom Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_RegisterRoom();
                return _Instance;
            }
            private set { }
        }
        public BLL_RegisterRoom() { }

        public bool checkIDRoomRegisterR(string username, string idroom)
        {
            foreach (RegisterRoom register in DAL_RegisterRoom.Instance.getAllRR())
            {
                if (register.UserName == username && register.ID_Room == idroom && register.Note == "Chưa duyệt")
                {
                    return true;
                }

            }
            return false;
        }

        public void addRR(string username, string fullname, string phone, DateTime ns, string job, string hometown, string idroom)
        {
            if (username == "" || fullname == "" || phone == "" || job == "" || hometown == "" || idroom == "")
            {
                MessageBox.Show("Khong duoc bo trong");
                return;
            }

            RegisterRoom registerRoom = new RegisterRoom();
            registerRoom.UserName = username;
            registerRoom.fullName = fullname;
            registerRoom.Phone = phone;
            registerRoom.BirthDate = ns;
            registerRoom.Job = job;
            registerRoom.HomeTown = hometown;
            registerRoom.Note = "Chưa thuê";
            registerRoom.ID_Room = idroom;

            DAL_RegisterRoom.Instance.addRR(registerRoom);
        }

        public void EditRR(RegisterRoom registerR)
        {
            DAL_RegisterRoom.Instance.EditRR(registerR);
        }

        public void DelRR(int idrr)
        {
            RegisterRoom registerroom = BLL_RegisterRoom.Instance.getRegisterRoomById(idrr);
            if (registerroom != null)
            {
                if (registerroom.Note == "Duyệt")
                {
                    Room room = BLL_Manager.Instance.getRoomByID(registerroom.ID_Room);
                    room.RoomState = "Chưa thuê";
                    BLL_Manager.Instance.editRoom(room);
                }
            }
            DAL_RegisterRoom.Instance.DelRR(idrr);

        }

        public List<RegisterRoom> getRegisterRoomByIdMotel(string idmotel)
        {
            List<RegisterRoom> list = new List<RegisterRoom>();
            foreach (Room room in BLL_Manager.Instance.getAllRoomByIDMotel(idmotel))
                foreach (RegisterRoom registerroom in DAL_RegisterRoom.Instance.getAllRR())
                {
                    if (registerroom.ID_Room == room.ID_Room)
                    {
                        list.Add(registerroom);
                    }
                }
            return list;
        }


        public List<RegisterRoom> getRegisterRoomByState(string idmanager)
        {
            List<string> listidmotel = BLL_Manager.Instance.getIdMotelbyManager(idmanager);
            List<RegisterRoom> list = new List<RegisterRoom>();
            foreach (string idmotel in listidmotel)
            {
                foreach (Room room in BLL_Manager.Instance.getAllRoomByIDMotel(idmotel))
                {
                    foreach (RegisterRoom registerR in DAL_RegisterRoom.Instance.getAllRR())
                    {
                        if (registerR.Note == "Chưa duyệt" && registerR.ID_Room == room.ID_Room)
                        {
                            list.Add(registerR);
                        }
                    }
                }
            }
            return list;
        }

        public RegisterRoom getRegisterRoomById(int idrr)
        {
            RegisterRoom RR = new RegisterRoom();
            foreach (RegisterRoom rr in DAL_RegisterRoom.Instance.getAllRR())
            {
                if (rr.ID == idrr)
                {
                    RR = rr;
                    break;
                }
            }
            return RR;
        }

        ////////////////
        ///
        public List<RegisterRoom> getRegisterRoomByUsername(string username)
        {
            List<RegisterRoom> list = new List<RegisterRoom>();
            foreach (RegisterRoom registerroom in DAL_RegisterRoom.Instance.getAllRR())
            {
                if (registerroom.UserName == username && registerroom.Note == "Duyệt")
                {
                    list.Add(registerroom);
                }
            }
            return list;
        }
        public List<RegisterRoom> getRequestedHistoryByUsername(string username)
        {
            List<RegisterRoom> list = new List<RegisterRoom>();
            foreach (RegisterRoom registerroom in DAL_RegisterRoom.Instance.getAllRR())
            {
                if (registerroom.UserName == username)
                {
                    list.Add(registerroom);
                }
            }
            return list;
        }



    }
}
