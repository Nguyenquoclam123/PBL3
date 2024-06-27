using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Comment
    {
        private static BLL_Comment _Instance;
        public static BLL_Comment Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Comment();
                return _Instance;
            }
            private set { }
        }
        public void Add(string username, string text, DateTime d)
        {
            DAL_Comment.Instance.Add(username, text, d);
        }
        public List<Comment> getAll()
        {
            return DAL_Comment.Instance.ShowAllComment();
        }



        //Commment
        public List<Comment> getCommentByIDPost(int postid)
        {
            List<Comment> list = new List<Comment>();
            foreach (Comment comment in DAL_Comment.Instance.getAllComment())
            {
                if (comment.PostID == postid)
                {
                    list.Add(comment);
                }
            }
            return list;
        }

        public void addComment(Comment comment)
        {
            DAL_Comment.Instance.addComment(comment);
        }






    }
}
