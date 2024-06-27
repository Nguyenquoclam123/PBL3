using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DTO;

namespace DAL
{
    public class DAL_Comment
    {
        private static DAL_Comment _Instance;
        public static DAL_Comment Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_Comment();
                return _Instance;
            }
            private set { }
        }
        public void Add(string username, string text, DateTime d)
        {
            DBHelper.Instance.ExecuteDB("Insert into COMMENT Values ('" + username + "','" + text + "','" + d + "')");
        }
        public List<Comment> ShowAllComment()
        {
            List<Comment> list = new List<Comment>();
            foreach (DataRow i in DBHelper.Instance.GetRecords("Select * from COMMENT").Rows)
            {
                list.Add(getComment(i));
            }
            return list;
        }
        public Comment getComment(DataRow i)
        {
            //return new Comment
            //{
            //    UserName = i["UserName"].ToString(),
            //    CommentText = i["CommentText"].ToString(),
            //    CommentDate = DateTime.Parse(i["CommentDate"].ToString())
            //};
            return null;
        }



        //comment
        public List<Comment> getAllComment()
        {
            List<Comment> list = new List<Comment>();
            foreach (DataRow rowPost in DBHelper.Instance.GetRecords("select * from Comment").Rows)
            {
                list.Add(new Comment
                {
                    ID = Convert.ToInt32(rowPost["ID"].ToString()),
                    CommentText = rowPost["CommentText"].ToString(),
                    CommentDate = rowPost["CommentDate"].ToString(),
                    UserName = rowPost["UserName"].ToString(),
                    PostID = Convert.ToInt32(rowPost["PostID"].ToString()),
                });
            }
            return list;
        }

        public void addComment(Comment comment)
        {
            string query = string.Format("insert into COMMENT(CommentText,CommentDate,UserName,PostID) values(N'{0}',N'{1}',N'{2}',{3})", comment.CommentText, comment.CommentDate, comment.UserName, comment.PostID);
            DBHelper.Instance.ExecuteDB(query);
        }
    }
}
