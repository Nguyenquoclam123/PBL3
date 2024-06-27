using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string ApprovalStatus { get; set; }
        public string ID_Motel { get; set; }
        public string ImagePaths { get; set; }
    }
}
