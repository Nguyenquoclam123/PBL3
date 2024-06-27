using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_Manager
    {
        private static BLL_Manager _Instance;
        public static BLL_Manager Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Manager();
                return _Instance;
            }
            private set { }
        }
        public BLL_Manager() { }


        //Manager
        public Manager getManagerByPhone(string phone)
        {
            foreach (Manager itm in DAL_Manager.Instance.getAllManager())
            {
                if (itm.Phone == phone)
                {
                    return itm;
                }
            }
            return null;
        }

        //Motel

        public List<Motel> getAllMotel()
        {
            List<Motel> list = new List<Motel>();
            list = DAL_Manager.Instance.getAllMotel();
            return list;
        }
        public List<Motel> getAllMotelForManager(string idmanager)
        {
            List<Motel> list = new List<Motel>();
            foreach (Motel mo in getAllMotel())
            {
                if (mo.ID_Manager == idmanager)
                {
                    list.Add(mo);
                }
            }
            return list;
        }

        public Motel getMotelByID(string idmotel)
        {
            Motel motel = null;
            foreach (Motel mo in getAllMotel())
            {
                if (mo.ID_Motel == idmotel)
                {
                    motel = mo;
                    break;
                }
            }
            return motel;
        }
        public void AddMotel(Motel motel)
        {
            DAL_Manager.Instance.AddMotel(motel);
        }

        public void Update(Motel motel)
        {
            DAL_Manager.Instance.Update(motel);
        }

        public void Del(string idmotel)
        {
            DAL_Manager.Instance.Del(idmotel);
        }


        //Room
        public List<string> getIdMotelbyManager(string idmanager)
        {
            List<string> list = new List<string>();

            foreach (Motel mo in getAllMotelForManager(idmanager))
            {
                if (mo.ID_Manager == idmanager)
                {
                    list.Add(mo.ID_Motel);
                }
            }
            return list;
        }

        public List<Room> getAllRoomByIDMotel(string idmotel)
        {
            List<Room> list = new List<Room>();
            foreach (Room room in DAL_Manager.Instance.getAllRoom())
            {
                if (room.ID_Motel == idmotel)
                {
                    list.Add(room);
                }
            }
            return list;
        }

        public Room getRoomByID(string idroom)
        {
            Room room = new Room();
            foreach (Room ro in DAL_Manager.Instance.getAllRoom())
            {
                if (ro.ID_Room == idroom)
                {
                    room = ro;
                    break;
                }
            }
            return room;
        }

        public void addRoom(Room room)
        {
            foreach (Motel motel in getAllMotel())
            {
                if (room.ID_Motel == motel.ID_Motel)
                {
                    motel.NumRoom = motel.NumRoom + 1;
                    DAL_Manager.Instance.Update(motel);
                    break;
                }
            }
            DAL_Manager.Instance.addRoom(room);
        }
        public void editRoom(Room room)
        {
            if (checkIdRoom(room.ID_Room, room.ID_Motel) == false)
            {
                MessageBox.Show("khong co ID " + room.ID_Room);
                return;
            }
            DAL_Manager.Instance.editRoom(room);
        }

        public void delRoom(string idroom, string idmotel)
        {
            foreach (Motel motel in getAllMotel())
            {
                if (idmotel == motel.ID_Motel)
                {
                    motel.NumRoom = motel.NumRoom - 1;
                    DAL_Manager.Instance.Update(motel);
                    break;
                }
            }
            DAL_Manager.Instance.delRoom(idroom);
        }

        public bool checkIdRoom(string idroom, string idmotel)
        {
            bool check = false;

            string pattern = string.Format(@"^{0}\d{{3}}$", Regex.Escape(idmotel));
            if (!Regex.IsMatch(idroom, pattern))
            {
                return true;
            }

            foreach (Room ro in getAllRoomByIDMotel(idmotel))
            {
                if (ro.ID_Room == idroom)
                {
                    return true;
                }
            }
            return check;
        }

        public List<RegisterRoom> getRegisterRoomByIdManager(string idmanager)
        {
            List<RegisterRoom> list = new List<RegisterRoom>();
            list = DAL_Manager.Instance.getRegisterRoomByIdManager(idmanager);
            return list;
        }



        //getNameManager
        public string getName(string phone)
        {
            foreach (Person person in DAL_Manager.Instance.getAllPerson())
            {
                if (person.Phone == phone)
                {
                    return person.fullName;
                }
            }
            return null;
        }


        //Post
        public void AddPost(Post post)
        {
            DAL_Manager.Instance.AddPost(post);
        }

        public List<Post> getAllPost()
        {
            return DAL_Manager.Instance.getAllPost();
        }

        public List<Post> getAllPostByApprove()
        {
            List<Post> list = new List<Post>();
            foreach (Post post in getAllPost())
            {
                if (post.ApprovalStatus == "Đã duyệt")
                    list.Add(post);
            }
            return list;
        }

        public void EditPost(Post post)
        {

            DAL_Manager.Instance.EditPost(post);
        }
        public void DelPost(int postit)
        {
            DAL_Manager.Instance.DelPost(postit);
        }

        public List<Post> getAllPostByIdMotel(string idmotel)
        {
            List<Post> list = new List<Post>();
            foreach (Post post in getAllPost())
            {
                if (post.ID_Motel == idmotel)
                    list.Add(post);
            }
            return list;
        }

    }
}
