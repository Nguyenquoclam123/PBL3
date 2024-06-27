using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_Admin
    {
        private static BLL_Admin _Instance;
        public static BLL_Admin Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Admin();
                return _Instance;
            }
            private set { }
        }
        private BLL_Admin()
        {

        }

        // Account
        // Tính tổng số lượng account
        public int TongSoLuongAccount()
        {
            int n = 0;
            foreach (Account i in DAL_Admin.Instance.Get_All_Account())
            {
                n++;
            }

            return n;
        }
        // Danh sách Accout
        public List<Account> DanhSachAccount()
        {
            List<Account> list = new List<Account>();
            list = DAL_Admin.Instance.Get_All_Account();
            return list;
        }

        // Get Accout by UserName
        public Account Get_Account_By_UserName(string userName)
        {

            foreach (Account i in DAL_Admin.Instance.Get_All_Account())
            {
                if (i.userName == userName)
                    return i;
            }
            return null;
        }
        // Xử lý Account
        public void Del_Account(string m)
        {
            DAL_Admin.Instance.Del_Account_DAL(m);
        }

        public void Add_Account(string x, int y, string z, string m, string n, string p, string q, string ID)
        {
            DAL_Admin.Instance.Add_Account_DAL(x, y, z, m, n, p, q, ID);
        }
        public void Edit_Account(string m, string n, string p, string q)
        {
            DAL_Admin.Instance.Update_Account_DAL(m, n, p, q);
        }

        // Comment
        // Tính tổng số lượng Comment
        public int TongSoLuongComment()
        {
            int n = 0;
            foreach (Comment i in DAL_Admin.Instance.Get_All_Comment())
            {
                n++;
            }

            return n;
        }
        // Danh sách Comment
        public List<Comment> DanhSachComment()
        {
            List<Comment> list = new List<Comment>();
            list = DAL_Admin.Instance.Get_All_Comment();
            return list;
        }
        // Xử lý Comment
        //public void Del_Comment(string m)
        //{
        //    DAL_Admin.Instance.Del_Comment_DAL(m);
        //}

        public void Browse_Comment(string m)
        {
            DAL_Admin.Instance.Browse_Comment_DAL(m);
        }

        // Post
        // Tính tổng số lượng Post
        public int TongSoLuongPost()
        {
            int n = 0;
            foreach (Post i in DAL_Admin.Instance.Get_All_Post())
            {
                n++;
            }

            return n;
        }
        // Danh sách Post
        public List<Post> DanhSachPost()
        {
            List<Post> list = new List<Post>();
            list = DAL_Admin.Instance.Get_All_Post();
            return list;
        }
        // Xử lý Post
        public void Del_Post(int m)
        {
            DAL_Admin.Instance.Del_Post_DAL(m);
        }

        public void Browse_Post(int m)
        {
            DAL_Admin.Instance.Browse_Post_DAL(m);
        }







        //LAM

        // lay post by id
        public Post Get_Post_by_ID(int id)
        {
            Post post = new Post();
            foreach (Post i in DanhSachPost())
            {
                if (i.PostID == id)
                    post = i;
            }
            return post;
        }

        // Danh sách chưa duyệt
        public int SoLuongChuaDuyet()
        {
            int n = 0;
            foreach (Post i in DanhSachPost())
            {
                if (i.ApprovalStatus == "Chưa duyệt")
                {
                    n++;
                }
            }
            return n;

        }

        //

        public List<Post> DanhSachPostChuaDuyet()
        {
            List<Post> list = new List<Post>();

            foreach (Post i in DanhSachPost())
            {
                if (i.ApprovalStatus == "Chưa duyệt")
                {
                    list.Add(i);
                }
            }
            return list;
        }

        // Danh sách da duyệt
        public int SoLuongDaDuyet()
        {
            int n = 0;
            foreach (Post i in DanhSachPost())
            {
                if (i.ApprovalStatus == "Đã duyệt")
                {
                    n++;
                }
            }
            return n;

        }

        //
        public List<Post> DanhSachPostDaDuyet()
        {
            List<Post> list = new List<Post>();

            foreach (Post i in DanhSachPost())
            {
                if (i.ApprovalStatus == "Đã duyệt")
                {
                    list.Add(i);
                }
            }
            return list;
        }

        // Lấy All Person
        public List<Person> Get_All_Person()
        {
            List<Person> list = new List<Person>();
            list = DAL_Admin.Instance.Get_All_Person();
            return list;
        }
        // Lấy SDT bằng username
        public string Get_Phone_by_UserName(string username)
        {
            return DAL_Admin.Instance.Get_All_Account()
            .Where(account => account.userName == username)
            .Select(account => account.Phone)
            .FirstOrDefault();
        }
        // Lấy Person bằng sdt
        public Person Get_Person(string sdt)
        {
            return Get_All_Person().FirstOrDefault(person => person.Phone == sdt);
        }

        // Sửa thông tin Person
        public void Edit_Person(string m, int n, string p, string q)
        {
            DAL_Admin.Instance.Update_Person_DAL(m, n, p, q);
        }

        // Lấy SDT bằng username
        public string Get_PassWork_by_UserName(string username)
        {
            return DAL_Admin.Instance.Get_All_Account()
            .Where(account => account.userName == username)
            .Select(account => account.PassWord)
            .FirstOrDefault();
        }
        // Đổi Mật khẩu
        public void ChangesPassWork(string m, string n, string p, string q)
        {
            if (p != q)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp. Vui lòng nhập lại");
            }
            else
            {
                DAL_Admin.Instance.Update_Passwork_DAL(m, p);
            }
        }

        // Lấy List Comment by PostID
        public List<Comment> Get_Comment_by_PostID(int postID)
        {
            return DAL_Admin.Instance.Get_All_Comment()
                                    .Where(comment => comment.PostID == postID)
                                    .ToList();
        }

        // Xóa Comment khi Post bị xóa

        public void Del_Comment_by_Post(int m)
        {
            DAL_Admin.Instance.Del_Comment_by_Post_DAL(m);
        }


        // Xử lý Comment
        public void Del_Comment(int m)
        {
            DAL_Admin.Instance.Del_Comment_DAL(m);
        }

        public List<Account> DanhSachAdmin()
        {
            List<Account> list = new List<Account>();

            foreach (Account i in DanhSachAccount())
            {
                if (i.Position == "Admin")
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public List<Account> DanhSachManager()
        {
            List<Account> list = new List<Account>();

            foreach (Account i in DanhSachAccount())
            {
                if (i.Position == "Manager")
                {
                    list.Add(i);
                }
            }
            return list;
        }


        //danh sach renter
        public List<Account> DanhSachRenter()
        {
            List<Account> list = new List<Account>();

            foreach (Account i in DanhSachAccount())
            {
                if (i.Position == "Renter")
                {
                    list.Add(i);
                }
            }
            return list;
        }


        // Doanh thu
        public double DoanhSo()
        {
            double doanhso = 0;
            foreach (Room i in DAL_Admin.Instance.Get_All_Room())
            {
                if (i.RoomState == "Đã thuê")
                    doanhso += i.Price;
            }

            return doanhso;
        }



        // so luong admin
        public int SoLuongAdmin()
        {
            int n = 0;
            foreach (Account i in DanhSachAccount())
            {
                if (i.Position == "Admin")
                {
                    n++;
                }
            }
            return n;
        }


        //so luong manager


        // Danh sách Manager
        public int SoLuongManager()
        {
            int n = 0;
            foreach (Account i in DanhSachAccount())
            {
                if (i.Position == "Manager")
                {
                    n++;
                }
            }
            return n;

        }


        //so luong renter

        // Danh sách Renter
        public int SoLuongRenter()
        {
            int n = 0;
            foreach (Account i in DanhSachAccount())
            {
                if (i.Position == "Renter")
                {
                    n++;
                }
            }
            return n;

        }






    }
}
