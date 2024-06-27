using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BLL
{
    public class BLL_Room
    {
        private static BLL_Room _Instance;
        public static BLL_Room Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Room();
                return _Instance;
            }
            private set { }
        }
        public DataTable Show(string username)
        {
            return DAL_Room.Instance.Show(username);
        }
        public DataTable ShowAll(string username)
        {
            return DAL_Room.Instance.ShowAll(username);
        }
        public void Add(string UserName_Renter, string fullName_Renter, string phone_Renter, DateTime dateTime, string job, string address, string state_Notice, string ID_Motel, string ID_Room)
        {
            DAL_Room.Instance.Add(UserName_Renter, fullName_Renter, phone_Renter, dateTime, job, address, state_Notice, ID_Motel, ID_Room);
        }
        public DataTable LoadDGV()
        {
            return DAL_Room.Instance.LoadDGV();
        }

        public bool checkPriceofMotel(string findprice, string itemprice)
        {

            //giá nguyên
            string[] parts = itemprice.Split(new string[] { "-" }, StringSplitOptions.None);
            int startA = int.Parse(parts[0].Replace(".", ""), CultureInfo.InvariantCulture);
            int endA = int.Parse(parts[1].Replace(".", ""), CultureInfo.InvariantCulture);

            //
            string[] partsitemprice = findprice.Split(new string[] { "->" }, StringSplitOptions.None);
            int startB = int.Parse(partsitemprice[0].Replace(".", ""), CultureInfo.InvariantCulture);
            int endB = int.Parse(partsitemprice[1].Replace(".", ""), CultureInfo.InvariantCulture);
            //MessageBox.Show(startA.ToString() + " " + endA.ToString() + "    " + startB.ToString() + " " + endB.ToString());

            if (startB > endA || endB < startA)
            {
                return false;
            }
            else return true;
            //return (startB >= startA && startB <= endA) || (endB >= startA && endB <= endA);
        }

        public List<Post> FindInfoByCostandPos(string cost, string pos)
        {
            List<Post> list = new List<Post>();
            foreach (Post post in BLL_Manager.Instance.getAllPost())
            {
                if (checkPriceofMotel(post.Price, cost) && (post.Address.ToLower()).Contains(pos.ToLower()))
                {
                    list.Add(post);
                }
            }
            return list;
        }
    }
}
