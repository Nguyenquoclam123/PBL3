using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Comment
    {
        public int ID { get; set; }
        public string CommentText { get; set; }
        public string CommentDate { get; set; }
        public string UserName { get; set; }
        public int PostID { get; set; }



        //private string _userName;
        //private string _commentText;
        //private DateTime _commentDate;

        //public string UserName { get { return _userName; } set { _userName = value; } }
        //public string CommentText { get { return _commentText; } set { _commentText = value; } }
        //public DateTime CommentDate { get { return _commentDate; } set { _commentDate = value; } }

        //public Comment() { }
        //public Comment(string userName, string commentText, DateTime commentDate)
        //{
        //    //_id = id;
        //    _userName = userName;
        //    _commentText = commentText;
        //    _commentDate = commentDate;
        //}
    }
}
