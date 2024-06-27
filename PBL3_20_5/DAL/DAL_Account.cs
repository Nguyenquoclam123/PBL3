using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Account
    {
        private static DAL_Account _Instance;
        public static DAL_Account Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DAL_Account();
                return _Instance;
            }
            private set { }
        }
        public int getNumRecord(string username, string pass)
        {
            return DBHelper.Instance.GetRecordCount("Select COUNT(*) from ACCOUNT where UserName = '" + username + "' AND Password = '" + pass + "'");
        }
        public int isExisted(string username, string phone)
        {
            return DBHelper.Instance.GetRecordCount(string.Format("Select COUNT(*) from ACCOUNT where UserName = N'{0}' OR Phone = N'{1}'", username, phone));
        }
        public Account getAccountByUserName(string username, string password)
        {
            foreach (DataRow i in DBHelper.Instance.GetRecords(string.Format("Select * from ACCOUNT where UserName = N'{0}'AND Password = N'{1}'", username, password)).Rows)
            {
                return new Account()
                {
                    userName = i["UserName"].ToString(),
                    PassWord = i["PassWord"].ToString(),
                    Phone = i["Phone"].ToString(),
                    Position = i["Position"].ToString()
                };
            }
            return null;
        }
        public void Add(string UserName, string PassWord, string Phone, string Position)
        {
            DBHelper.Instance.ExecuteDB(string.Format("Insert into ACCOUNT values(N'{0}', N'{1}',N'{2}',N'{3}')", UserName, PassWord, Phone, Position));
        }
        public string getNameByUserName(string username)
        {
            foreach (DataRow i in DBHelper.Instance.GetRecords("Select PERSON.fullName from ACCOUNT inner join PERSON ON ACCOUNT.Phone = PERSON.Phone where ACCOUNT.UserName= '" + username + "'").Rows)
            {
                return i["fullName"].ToString();
            }
            return null;
        }
        public string getPasswordByUserName(string username, string Phone)
        {
            foreach (DataRow i in DBHelper.Instance.GetRecords("Select * from ACCOUNT where UserName = '" + username + "' and Phone = '" + Phone + "'").Rows)
            {
                return i["PassWord"].ToString();
            }
            return null;
        }
        public void Update(string username, string password, string newPass)
        {
            DBHelper.Instance.ExecuteDB("Update ACCOUNT SET PassWord = '" + newPass + "' where PassWord = '" + password + "' and UserName= '" + username + "'");
        }
    }
}
