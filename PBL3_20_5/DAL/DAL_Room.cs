using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_Room
    {
        private static DAL_Room _Instance;
        public static DAL_Room Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_Room();
                return _Instance;
            }
            private set { }
        }
        public DataTable Show(string username)
        {
            return DBHelper.Instance.GetRecords("Select UserName, fullName, ID_Motel, ID_Room, State_ from REGISTER_ROOM where UserName = '" + username + "' AND State_ = 'Da duyet'");
        }
        public DataTable ShowAll(string username)
        {
            return DBHelper.Instance.GetRecords("Select UserName, fullName, ID_Motel, ID_Room, State_ from REGISTER_ROOM where UserName = '" + username + "'");
        }
        public void Add(string UserName_Renter, string fullName_Renter, string phone_Renter, DateTime dateTime, string job, string address, string state_Notice, string ID_Motel, string ID_Room)
        {
            DBHelper.Instance.ExecuteDB("INSERT INTO REGISTER_ROOM VALUES ('" + UserName_Renter + "', '" + fullName_Renter + "', '" + phone_Renter + "', '" + dateTime + "', '" + job + "','" + address + "','" + state_Notice + "', '" + ID_Motel + "','" + ID_Room + "') ");
        }
        public DataTable LoadDGV()
        {
            return DBHelper.Instance.GetRecords("Select p.fullName, p.fullAddress, p.Phone, m.fullAddress, m.NumRoom, m.fullDescription,m.ID_Motel, r.ID_Room,r.Price, r.RoomState From MOTEL m JOIN MANAGER mn ON m.ID_Manager = mn.ID JOIN ROOM r ON m.ID_Motel = r.ID_Motel JOIN PERSON p ON mn.Phone = p.Phone ");
        }

        public List<Post> FindInfoByCostandPos(int x, int y, string pos)
        {
            List<Post> list = new List<Post>();

            string query = string.Format("SELECT DISTINCT POST.* FROM POST INNER JOIN MOTEL ON POST.ID_Motel = MOTEL.ID_Motel INNER JOIN ROOM ON MOTEL.ID_Motel = ROOM.ID_Motel WHERE room.Price BETWEEN {0} AND {1} AND POST.Address LIKE N'%{2}%';", x, y, pos);
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
            //MessageBox.Show(list.Count().ToString());
            return list;
        }
    }
}
