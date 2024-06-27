using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DTO;
using System.Globalization;

namespace DAL
{
    public class DAL_Admin
    {
        private static DAL_Admin _Instance;
        public static DAL_Admin Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_Admin();
                return _Instance;
            }
            private set { }
        }
        private DAL_Admin()
        {

        }
        // Get Account
        public List<Account> Get_All_Account()
        {
            List<Account> data = new List<Account>();
            string query = "select * from ACCOUNT";
            foreach (DataRow i in DBHelper_Admin.Instance.GetRecords(query).Rows)
            {
                data.Add(Get_Account(i));
            }
            return data;
        }
        public Account Get_Account(DataRow i)
        {
            return new Account(i["UserName"].ToString(), i["PassWord"].ToString(), i["Phone"].ToString(), i["Position"].ToString());
            /* {
                 userName = i["UserName"].ToString(),
                 PassWord = i["PassWord"].ToString(),
                 Phone = i["Phone"].ToString(),
                 Position = i["Position"].ToString(),
             };*/
        }

        // Get Comment
        public List<Comment> Get_All_Comment()
        {
            List<Comment> data = new List<Comment>();
            string query = "select * from Comment";
            foreach (DataRow i in DBHelper_Admin.Instance.GetRecords(query).Rows)
            {
                data.Add(Get_Comment(i));
            }
            return data;

        }

        public Comment Get_Comment(DataRow i)
        {
            int idComment = Convert.ToInt32(i["ID"]);
            string userName = i["UserName"]?.ToString();
            string commentText = i["CommentText"]?.ToString();
            DateTime commentDate;

            string[] formats = {
                "MM/dd/yyyy hh:mm:ss tt", "M/d/yyyy hh:mm:ss tt",
                "yyyy-MM-dd", "M/d/yyyy", "MM/dd/yyyy",
                "M/d/yyyy h:mm:ss tt", "MM/d/yyyy h:mm:ss tt"
            }; // Các định dạng ngày tháng có thể chấp nhận

            if (DateTime.TryParseExact(i["CommentDate"]?.ToString(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out commentDate))
            {
                int postId = Convert.ToInt32(i["PostID"]);
                return new Comment { ID = idComment, UserName = userName, CommentText = commentText, CommentDate = commentDate.ToString("yyyy-MM-dd HH:mm:ss"), PostID = postId };
            }
            else
            {
                // Xử lý trường hợp CommentDate không hợp lệ
                return new Comment { ID = idComment, UserName = userName, CommentText = commentText, CommentDate = DateTime.MinValue.ToString("yyyy-MM-dd HH:mm:ss"), PostID = 0 };
            }
        }




        //public Comment Get_Comment(DataRow i)
        //{
        //    int idComment = Convert.ToInt32(i["ID"]);
        //    string userName = i["UserName"]?.ToString();
        //    string commentText = i["CommentText"]?.ToString();
        //    DateTime commentDate;

        //    string[] formats = { "MM/dd/yyyy hh:mm:ss tt", "M/d/yyyy hh:mm:ss tt", "yyyy-MM-dd", "M/d/yyyy", "MM/dd/yyyy" }; // Các định dạng ngày tháng có thể chấp nhận

        //    if (DateTime.TryParseExact(i["CommentDate"]?.ToString(), formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out commentDate))
        //    {
        //        int postId = Convert.ToInt32(i["PostID"]);
        //        return new Comment { ID = idComment, UserName = userName, CommentText = commentText, CommentDate = commentDate.Date.ToString(), PostID = postId };
        //    }
        //    else
        //    {
        //        // Xử lý trường hợp CommentDate không hợp lệ, ví dụ trả về một giá trị mặc định
        //        //return new Comment(idComment, userName, commentText, DateTime.MinValue, 0); // 0 là giá trị mặc định cho PostID
        //    }
        //        return null;
        //}




        // Get Post

        public List<Post> Get_All_Post()
        {
            List<Post> data = new List<Post>();
            string query = "select * from Post";
            foreach (DataRow i in DBHelper_Admin.Instance.GetRecords(query).Rows)
            {
                data.Add(Get_Post(i));
            }
            return data;

        }
        public Post Get_Post(DataRow i)
        {
            return new Post
            {
                PostID = Convert.ToInt32(i["PostID"].ToString()),
                Title = i["Title"].ToString(),
                Price = Convert.ToString(i["Price"].ToString()),
                Address = i["Address"].ToString(),
                Description = i["Description"].ToString(),
                ApprovalStatus = i["ApprovalStatus"].ToString(),
                ID_Motel = i["ID_Motel"].ToString(),
                ImagePaths = i["ImagePaths"].ToString()
            };

        }

        // Xử lý Account
        public void Add_Account_DAL(string x, int y, string z, string m, string n, string p, string q, string ID)
        {
            string query1 = "INSERT INTO Person (fullName, Age, fullAddress, Phone ) VALUES (@fullName, @Age, @fullAddress, @Phone )";
            string query = "INSERT INTO Account (userName, PassWord, Phone, Position ) VALUES (@userName, @PassWord, @Phone, @Position )";
            string query2 = "INSERT INTO Manager (ID, Phone ) VALUES ('"+ID+"','"+p+"' )";
            List<SqlParameter> parameters1 = new List<SqlParameter>();
            List<SqlParameter> parameters = new List<SqlParameter>();
            

            parameters1.Add(new SqlParameter("@fullName", SqlDbType.VarChar) { Value = x });
            parameters1.Add(new SqlParameter("@Age", SqlDbType.Int) { Value = y });
            parameters1.Add(new SqlParameter("@fullAddress", SqlDbType.VarChar) { Value = z });
            parameters1.Add(new SqlParameter("@Phone", SqlDbType.NVarChar) { Value = p });
            //
            parameters.Add(new SqlParameter("@userName", SqlDbType.VarChar) { Value = m });
            parameters.Add(new SqlParameter("@PassWord", SqlDbType.NVarChar) { Value = n });
            parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar) { Value = p });
            parameters.Add(new SqlParameter("@Position", SqlDbType.NVarChar) { Value = q });

            


            // Gọi phương thức ExecuteDBB trong lớp DBHelper với danh sách tham số
            DBHelper_Admin.Instance.ExecuteDBB(query1, parameters1.ToArray());
            DBHelper.Instance.ExecuteDB(query2);
            DBHelper_Admin.Instance.ExecuteDBB(query, parameters.ToArray());
            
        }

        public void Update_Account_DAL(string m, string n, string p, string q)
        {
            string query = "UPDATE Account SET userName = @userName, PassWord = @PassWord, Phone = @Phone, Position = @Position WHERE userName = @userName";
            //string query1 = "UPDATE Person SET Phone = @Phone, Position = @Position WHERE userName = @userName";
            // Khởi tạo danh sách các tham số
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Thêm các tham số vào danh sách
            parameters.Add(new SqlParameter("@userName", SqlDbType.NVarChar) { Value = m });
            parameters.Add(new SqlParameter("@PassWord", SqlDbType.NVarChar) { Value = n });
            parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar) { Value = p });
            parameters.Add(new SqlParameter("@Position", SqlDbType.NVarChar) { Value = q });


            // Gọi phương thức ExecuteDB trong lớp DBHelper để thực thi câu lệnh SQL với danh sách tham số đã được tạo
            DBHelper_Admin.Instance.ExecuteDBB(query, parameters.ToArray());
        }
        public void Del_Account_DAL(string s)
        {
            string query = "DELETE FROM Account WHERE userName = @userName";
            SqlParameter[] parameters = new SqlParameter[1]; // Khởi tạo mảng các tham số với kích thước 1
            parameters[0] = new SqlParameter("@userName", SqlDbType.VarChar) { Value = s };
            DBHelper_Admin.Instance.ExecuteDBB(query, parameters);
        }

        //// Xử lý Comment
        //public void Del_Comment_DAL(string s)
        //{
        //    string query = "DELETE FROM Comment WHERE userName = @userName";
        //    SqlParameter[] parameters = new SqlParameter[1]; // Khởi tạo mảng các tham số với kích thước 1
        //    parameters[0] = new SqlParameter("@userName", SqlDbType.VarChar) { Value = s };
        //    DBHelper_Admin.Instance.ExecuteDBB(query, parameters);
        //}

        // Xử lý Comment
        public void Del_Comment_DAL(int s)
        {
            string query = "DELETE FROM Comment WHERE IDComment = @IDComment";
            SqlParameter[] parameters = new SqlParameter[1]; // Khởi tạo mảng các tham số với kích thước 1
            parameters[0] = new SqlParameter("@IDComment", SqlDbType.Int) { Value = s };
            DBHelper_Admin.Instance.ExecuteDBB(query, parameters);
        }


        public void Browse_Comment_DAL(string s)
        {
            string query = "UPDATE Account SET trangthai = true WHERE id = @id";
            SqlParameter[] parameters = new SqlParameter[1]; // Khởi tạo mảng các tham số với kích thước 1
            parameters[0] = new SqlParameter("@id", SqlDbType.VarChar) { Value = s };
            DBHelper_Admin.Instance.ExecuteDBB(query, parameters);
        }

        // Xử lý Post

        public void Del_Post_DAL(int s)
        {
            string query = "DELETE FROM Post WHERE PostID = @PostID";
            SqlParameter[] parameters = new SqlParameter[1]; // Khởi tạo mảng các tham số với kích thước 1
            parameters[0] = new SqlParameter("@PostID", SqlDbType.Int) { Value = s };
            DBHelper_Admin.Instance.ExecuteDBB(query, parameters);
        }

        public void Browse_Post_DAL(int s)
        {
            string ApprovalStatus = "Đã duyệt";
            string query = "UPDATE Post SET ApprovalStatus = @ApprovalStatus WHERE PostID = @PostID";
            List<SqlParameter> parameters1 = new List<SqlParameter>();
            SqlParameter[] parameters = new SqlParameter[1]; // Khởi tạo mảng các tham số với kích thước 1
            parameters[0] = new SqlParameter("@PostID", SqlDbType.Int) { Value = s };
            parameters1.Add(new SqlParameter("@PostID", SqlDbType.Int) { Value = s });
            parameters1.Add(new SqlParameter("@ApprovalStatus", SqlDbType.NVarChar) { Value = ApprovalStatus });
            DBHelper_Admin.Instance.ExecuteDBB(query, parameters1.ToArray());
        }


        //LAM

        // Get Person

        public List<Person> Get_All_Person()
        {
            List<Person> data = new List<Person>();
            string query = "select * from Person";
            foreach (DataRow i in DBHelper_Admin.Instance.GetRecords(query).Rows)
            {
                data.Add(Get_Person(i));

            }
            return data;

        }
        public Person Get_Person(DataRow i)
        {
            return new Person
            {
                fullName = i["fullName"].ToString(),
                Age = Convert.ToInt32(i["Age"].ToString()),
                Phone = i["Phone"].ToString(),
                fullAddress = i["fullAddress"].ToString(),

            };

        }

        // Update Person
        public void Update_Person_DAL(string m, int n, string p, string q)
        {
            string query = "UPDATE Person SET fullName = @fullName, Age = @Age, Phone = @Phone, fullAddress = @fullAddress WHERE Phone = @Phone";
            //string query1 = "UPDATE Person SET Phone = @Phone, Position = @Position WHERE userName = @userName";
            // Khởi tạo danh sách các tham số
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Thêm các tham số vào danh sách
            parameters.Add(new SqlParameter("@fullName", SqlDbType.NVarChar) { Value = m });
            parameters.Add(new SqlParameter("@Age", SqlDbType.Int) { Value = n });
            parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar) { Value = p });
            parameters.Add(new SqlParameter("@fullAddress", SqlDbType.NVarChar) { Value = q });


            // Gọi phương thức ExecuteDB trong lớp DBHelper để thực thi câu lệnh SQL với danh sách tham số đã được tạo
            DBHelper_Admin.Instance.ExecuteDBB(query, parameters.ToArray());
        }

        // Thay đổi Mật khẩu
        public void Update_Passwork_DAL(string m, string n)
        {
            string query = "UPDATE Account SET  PassWord = @PassWord WHERE userName = @userName";
            //string query1 = "UPDATE Person SET Phone = @Phone, Position = @Position WHERE userName = @userName";
            // Khởi tạo danh sách các tham số
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Thêm các tham số vào danh sách
            parameters.Add(new SqlParameter("@userName", SqlDbType.NVarChar) { Value = m });
            parameters.Add(new SqlParameter("@PassWord", SqlDbType.NVarChar) { Value = n });



            // Gọi phương thức ExecuteDB trong lớp DBHelper để thực thi câu lệnh SQL với danh sách tham số đã được tạo
            DBHelper_Admin.Instance.ExecuteDBB(query, parameters.ToArray());
        }


        // Xóa Comment khi Post bị xóa

        public void Del_Comment_by_Post_DAL(int s)
        {
            string query = "DELETE FROM Comment WHERE PostID = @PostID";
            SqlParameter[] parameters = new SqlParameter[1]; // Khởi tạo mảng các tham số với kích thước 1
            parameters[0] = new SqlParameter("@PostID", SqlDbType.Int) { Value = s };
            DBHelper_Admin.Instance.ExecuteDBB(query, parameters);
        }


        // Get Room
        public List<Room> Get_All_Room()
        {
            List<Room> data = new List<Room>();
            string query = "select * from Room";
            foreach (DataRow i in DBHelper_Admin.Instance.GetRecords(query).Rows)
            {
                data.Add(Get_Room(i));

            }
            return data;

        }


        public Room Get_Room(DataRow i)
        {
            string idRoom = i["ID_Room"]?.ToString();
            string idMotel = i["ID_Motel"]?.ToString();
            string fullDescription = i["fullDescription"]?.ToString();
            string roomState = i["RoomState"]?.ToString();
            double price;

            if (double.TryParse(i["Price"]?.ToString(), out price))
            {
                return new Room
                {
                    ID_Room = idRoom,
                    ID_Motel = idMotel,
                    fullDescription = fullDescription,
                    RoomState = roomState,
                    Price = price
                };
            }
            else
            {
                // Xử lý trường hợp giá không hợp lệ, ví dụ trả về giá trị mặc định
                return new Room
                {
                    ID_Room = idRoom,
                    ID_Motel = idMotel,
                    fullDescription = fullDescription,
                    RoomState = roomState,
                    Price = 0.0 // Giá trị mặc định cho Price
                };
            }
        }







    }
}
