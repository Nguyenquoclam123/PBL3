using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_Person
    {
        private static BLL_Person _Instance;
        public static BLL_Person Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Person();
                return _Instance;
            }
            private set { }
        }
        public void Add(string fullName, int Age, string Phone, string address)
        {
            DAL_Person.Instance.Add(fullName, Age, Phone, address);
        }
        public void Update(string fullName, int Age, string Phone, string address)
        {
            DAL_Person.Instance.Update(fullName, Age, Phone, address);
        }
        public Person Setup(string username)
        {
            if (DAL_Person.Instance.Setup(username) == null)
            {
                MessageBox.Show("Thông tin của bạn có vấn đề");
                return null;
            }
            else
                return DAL_Person.Instance.Setup(username);
        }
    }
}
