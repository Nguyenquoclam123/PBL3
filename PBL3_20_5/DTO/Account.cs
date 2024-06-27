using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string _userName;
        private string _passWord;
        private string _phone;
        private string _position;
        public string userName { get { return _userName; } set { _userName = value; } }
        public string PassWord { get { return _passWord; } set { _passWord = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }
        public string Position { get { return _position; } set { _position = value; } }

        public Account() { }
        public Account(string userName, string passWord, string phone, string position)
        {
            _userName = userName;
            _passWord = passWord;
            _phone = phone;
            _position = position;
        }
    }
}
