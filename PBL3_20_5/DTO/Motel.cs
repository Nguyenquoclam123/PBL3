using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Motel
    {
        public string ID_Motel { get; set; }
        public string ID_Manager { get; set; }
        public int NumRoom { get; set; }
        public string fullAddress { get; set; }
        public string fullDescription { get; set; }
    }
}
