using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RegisterRoom
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string fullName { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Job { get; set; }
        public string HomeTown { get; set; }
        public string Note { get; set; }
        public string ID_Room { get; set; }
    }
}
