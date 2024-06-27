using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Renter
    {
        private string _IDofRoom;
        private string _IDofMotel;
        public string IDofRoom { get { return _IDofRoom; } set { _IDofRoom = value; } }
        public string IDofMotel { get { return _IDofMotel; } set { _IDofMotel = value; } }
    }


}
