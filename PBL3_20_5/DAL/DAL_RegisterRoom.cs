using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_RegisterRoom
    {
        private static DAL_RegisterRoom _Instance;
        public static DAL_RegisterRoom Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_RegisterRoom();
                return _Instance;
            }
            private set
            {
            }
        }

        private DAL_RegisterRoom() { }

        public List<RegisterRoom> getAllRR()
        {
            List<RegisterRoom> list = new List<RegisterRoom>();
            string query = "SELECT * FROM REGISTER_ROOM ";
            foreach (DataRow row in DBHelper.Instance.GetRecords(query).Rows)
            {
                list.Add(new RegisterRoom
                {
                    ID = Convert.ToInt32(row["ID"].ToString()),
                    UserName = row["UserName"].ToString(),
                    fullName = (row["fullName"].ToString()),
                    Phone = row["Phone"].ToString(),
                    BirthDate = Convert.ToDateTime(row["BirthDate"].ToString()),
                    Job = row["Job"].ToString(),
                    HomeTown = (row["HomeTown"].ToString()),
                    Note = row["Note"].ToString(),
                    ID_Room = row["ID_Room"].ToString()
                });
            }

            return list;
        }

        public void addRR(RegisterRoom registerRoom)
        {
            string query = string.Format("insert into register_room(UserName, fullName, Phone, BirthDate, Job, HomeTown, Note, ID_ROOM) values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')", registerRoom.UserName, registerRoom.fullName, registerRoom.Phone, registerRoom.BirthDate, registerRoom.Job, registerRoom.HomeTown, "Chưa duyệt", registerRoom.ID_Room);
            DBHelper.Instance.ExecuteDB(query);
        }

        public void DelRR(int idrr)
        {
            string query = string.Format("Delete from REGISTER_ROOM where ID = {0}", idrr);
            DBHelper.Instance.ExecuteDB(query);
        }

        public void EditRR(RegisterRoom registerR)
        {
            string query = string.Format(@"UPDATE REGISTER_ROOM
                                    SET fullName = N'{0}', 
                                        Phone = N'{1}', 
                                        BirthDate = N'{2}', 
                                        Job = N'{3}', 
                                        HomeTown = N'{4}', 
                                        Note = N'{5}', 
                                        ID_ROOM = N'{6}'
                                    WHERE ID = {7};",
                                    registerR.fullName, registerR.Phone, registerR.BirthDate, registerR.Job, registerR.HomeTown, registerR.Note, registerR.ID_Room, registerR.ID);
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}
