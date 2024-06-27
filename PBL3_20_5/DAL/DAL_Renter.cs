using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Renter
    {
        private static DAL_Renter _Instance;
        public static DAL_Renter Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_Renter();
                return _Instance;
            }
            private set { }
        }
        public void Add(string username, string ID_Room, string ID_Motel)
        {
            //string query = string.Format();
            //DBHelper.Instance.ExecuteDB(query);
        }
    }
}
