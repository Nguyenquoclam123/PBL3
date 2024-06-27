using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DAL
{
    public class DAL_Person
    {
        private static DAL_Person _Instance;
        public static DAL_Person Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_Person();
                return _Instance;
            }
            private set { }
        }
        public void Add(string fullName, int Age, string Phone, string address)
        {
            DBHelper.Instance.ExecuteDB(string.Format("Insert into PERSON values(N'{0}', {1}, N'{2}', N'{3}')", fullName, Age, Phone, address));
        }
        public void Update(string fullName, int Age, string Phone, string address)
        {
            DBHelper.Instance.ExecuteDB("Update PERSON Set fullName = '" + fullName + "', Age = " + Age + ", fullAddress = '" + address + "' where Person.Phone = '" + Phone + "'");
            //MessageBox.Show("Cập nhật thông tin thành công");
        }
        public Person Setup(string username)
        {
            foreach (DataRow i in DBHelper.Instance.GetRecords("Select PERSON.fullName, PERSON.Age,PERSON.Phone,PERSON.fullAddress  from PERSON  INNER JOIN ACCOUNT ON PERSON.Phone = ACCOUNT.Phone Where ACCOUNT.UserName = '" + username + "'").Rows)
            {
                return new Person
                {
                    fullName = i["fullName"].ToString(),
                    Age = Int32.Parse(i["Age"].ToString()),
                    Phone = i["Phone"].ToString(),
                    fullAddress = i["fullAddress"].ToString()
                };
            }
            return null;
        }
    }
}
