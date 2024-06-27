using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Manager
    {
        private static DAL_Manager _Instance;
        public static DAL_Manager Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_Manager();
                return _Instance;
            }
            private set
            {
            }
        }

        private DAL_Manager() { }

        //Motel
        public List<Motel> getAllMotel()
        {
            List<Motel> list = new List<Motel>();
            string query = "SELECT * FROM MOTEL ";
            foreach (DataRow rowMotel in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(new Motel
                {
                    ID_Motel = rowMotel["ID_Motel"].ToString(),
                    ID_Manager = rowMotel["ID_Manager"].ToString(),
                    NumRoom = Convert.ToInt32(rowMotel["NumRoom"].ToString()),
                    fullAddress = rowMotel["fullAddress"].ToString(),
                    fullDescription = rowMotel["fullDescription"].ToString()
                });
            }

            return list;
        }
        //public List<Motel> getAllMotelForManager(string idmanager)
        //{
        //    List<Motel> list = new List<Motel>();
        //    string query = string.Format("SELECT * FROM MOTEL Where ID_Manager = N'{0}'", idmanager);
        //    foreach (DataRow rowMotel in DBHelper.Instance.GetRecords(query).Rows)
        //    {
        //        list.Add(new Motel
        //        {
        //            ID_Motel = rowMotel["ID_Motel"].ToString(),
        //            ID_Manager = rowMotel["ID_Manager"].ToString(),
        //            NumRoom = Convert.ToInt32(rowMotel["NumRoom"].ToString()),
        //            fullAddress = rowMotel["fullAddress"].ToString(),
        //            fullDescription = rowMotel["fullDescription"].ToString()
        //        });
        //    }

        //    return list;
        //}

        public void AddMotel(Motel motel)
        {
            string query = string.Format("INSERT INTO MOTEL VALUES(N'{0}',N'{1}',{2},N'{3}',N'{4}')", motel.ID_Motel, motel.ID_Manager, 0, motel.fullAddress, motel.fullDescription);
            DBHelper.Instance.ExecuteDB(query);
        }

        public void Update(Motel motel)
        {
            string query = string.Format("UPDATE MOTEL SET ID_Manager = N'{0}', NumRoom = {1}, fullAddress = N'{2}', fullDescription = N'{3}' WHERE ID_Motel = N'{4}'", motel.ID_Manager, motel.NumRoom, motel.fullAddress, motel.fullDescription, motel.ID_Motel);
            DBHelper.Instance.ExecuteDB(query);
        }

        public void Del(string idmotel)
        {
            string query = string.Format("DELETE FROM MOTEL WHERE ID_Motel = N'{0}'", idmotel);
            DBHelper.Instance.ExecuteDB(query);
        }


        //Room
        public List<Room> getAllRoom()
        {
            List<Room> list = new List<Room>();
            string query = "SELECT * FROM ROOM";
            foreach (DataRow rowRoom in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(new Room
                {
                    ID_Room = rowRoom["ID_Room"].ToString(),
                    ID_Motel = rowRoom["ID_Motel"].ToString(),
                    fullDescription = rowRoom["fullDescription"].ToString(),
                    RoomState = rowRoom["RoomState"].ToString(),
                    Price = Convert.ToDouble(rowRoom["Price"].ToString())
                });
            }
            return list;
        }

        public void addRoom(Room room)
        {
            string query = string.Format("INSERT INTO ROOM VALUES(N'{0}',N'{1}',N'{2}',N'{3}',{4})", room.ID_Room, room.ID_Motel, room.fullDescription, room.RoomState, room.Price);
            DBHelper.Instance.ExecuteDB(query);
        }

        public void editRoom(Room room)
        {
            string query = string.Format("UPDATE Room SET ID_Motel = N'{0}', fullDescription = N'{1}', RoomState = N'{2}', Price = {3} WHERE ID_Room = N'{4}'",
                            room.ID_Motel, room.fullDescription, room.RoomState, room.Price, room.ID_Room);
            DBHelper.Instance.ExecuteDB(query);
        }

        public void delRoom(string idroom)
        {
            string query = string.Format("DELETE FROM ROOM WHERE ID_Room = N'{0}'", idroom);
            DBHelper.Instance.ExecuteDB(query);
        }

        //RegisterRoom
        public List<RegisterRoom> getRegisterRoomByIdManager(string idmanager)
        {
            List<RegisterRoom> list = new List<RegisterRoom>();
            string query = string.Format("SELECT REGISTER_ROOM.ID,REGISTER_ROOM.UserName,REGISTER_ROOM.fullName,REGISTER_ROOM.Phone, REGISTER_ROOM.BirthDate, REGISTER_ROOM.Job, REGISTER_ROOM.HomeTown, REGISTER_ROOM.Note,REGISTER_ROOM.ID_Room " +
                "FROM MANAGER " +
                "INNER JOIN MOTEL ON MANAGER.ID = MOTEL.ID_Manager " +
                "INNER JOIN ROOM ON MOTEL.ID_Motel = ROOM.ID_Motel " +
                "INNER JOIN REGISTER_ROOM ON ROOM.ID_Room = REGISTER_ROOM.ID_Room " +
                "where MANAGER.ID = N'{0}'", idmanager);
            foreach (DataRow rowRoom in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(new RegisterRoom
                {
                    ID = Convert.ToInt32(rowRoom["ID"].ToString()),
                    UserName = rowRoom["UserName"].ToString(),
                    fullName = rowRoom["fullName"].ToString(),
                    Phone = rowRoom["Phone"].ToString(),
                    BirthDate = Convert.ToDateTime(rowRoom["BirthDate"].ToString()),
                    Job = rowRoom["Job"].ToString(),
                    HomeTown = rowRoom["HomeTown"].ToString(),
                    Note = rowRoom["Note"].ToString(),
                    ID_Room = rowRoom["Phone"].ToString(),
                });
            }
            return list;
        }


        //Post
        public List<Post> getAllPost()
        {
            List<Post> list = new List<Post>();
            string query = "SELECT * FROM POST";
            foreach (DataRow rowPost in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(new Post
                {
                    PostID = Convert.ToInt32(rowPost["PostID"].ToString()),
                    Title = Convert.ToString(rowPost["Title"]).ToString(),
                    Price = Convert.ToString(rowPost["Price"].ToString()),
                    Address = Convert.ToString(rowPost["Address"]).ToString(),
                    ImagePaths = Convert.ToString(rowPost["ImagePaths"]).ToString(),
                    Description = Convert.ToString(rowPost["Description"]).ToString(),
                    ApprovalStatus = Convert.ToString(rowPost["ApprovalStatus"]).ToString(),
                    ID_Motel = Convert.ToString(rowPost["ID_Motel"]).ToString()
                });
            }

            return list;
        }

        public void AddPost(Post post)
        {
            string query = string.Format("Insert into post(Title,Price,Address,Description,ApprovalStatus,ID_Motel,ImagePaths) values(N'{0}', N'{1}', N'{2}', N'{3}', N'Chưa duyệt',N'{4}',N'{5}')", post.Title, post.Price, post.Address, post.Description, post.ID_Motel, post.ImagePaths);
            DBHelper.Instance.ExecuteDB(query);
        }
        //getNameManager
        public List<Person> getAllPerson()
        {
            List<Person> list = new List<Person>();
            string query = string.Format("Select * from Person");
            foreach (DataRow rowPost in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(new Person
                {
                    fullName = rowPost["fullName"].ToString(),
                    Age = Convert.ToInt32(rowPost["Age"].ToString()),
                    Phone = rowPost["Phone"].ToString(),
                    fullAddress = rowPost["fullAddress"].ToString()
                });
            }
            return list;
        }

        public void EditPost(Post post)
        {
            string query = string.Format(@"UPDATE Post
                                    SET Title = N'{0}', 
                                        Price = N'{1}', 
                                        Address = N'{2}', 
                                        Description = N'{3}', 
                                        ApprovalStatus = N'{4}', 
                                        ID_Motel = '{5}', 
                                        ImagePaths = N'{6}'
                                    WHERE PostID = {7};",
                                   post.Title, post.Price, post.Address, post.Description, post.ApprovalStatus, post.ID_Motel, post.ImagePaths, post.PostID);
            DBHelper.Instance.ExecuteDB(query);
        }

        public void DelPost(int postid)
        {
            string query = string.Format("Delete from Post where PostID = {0}", postid);
            DBHelper.Instance.ExecuteDB(query);
        }

        //getManagerByphone
        public List<Manager> getAllManager()
        {
            List<Manager> list = new List<Manager>();
            foreach (DataRow rowPost in DBHelper.Instance.GetRecords("select * from manager").Rows)
            {
                list.Add(new Manager
                {
                    ID = rowPost["ID"].ToString(),
                    Phone = rowPost["Phone"].ToString()
                });
            }
            return list;
        }

    }
}
