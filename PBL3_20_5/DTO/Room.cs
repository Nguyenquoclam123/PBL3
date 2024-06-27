using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Room
    {
        public string ID_Room { get; set; }
        public string ID_Motel { get; set; }

        public string fullDescription { get; set; }
        public string RoomState { get; set; }
        public Double Price { get; set; }
    }
}
