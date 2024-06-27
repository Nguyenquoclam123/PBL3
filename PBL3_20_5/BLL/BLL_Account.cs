using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class BLL_Account
    {
        private static BLL_Account _Instance;
        public static BLL_Account Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Account();
                return _Instance;
            }
            private set { }
        }
        public void Add(string UserName, string PassWord, string Phone, string Position)
        {
            DAL_Account.Instance.Add(UserName, PassWord, Phone, Position);
        }
        public Account Login(string username, string password)
        {
            if (username.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập vào tên tài khoản!");
            }
            else if (password.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập vào mật khẩu!");
            }
            else
            {
                return DAL_Account.Instance.getAccountByUserName(username, password);
            }
            return null;
        }
        public bool CheckNum(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                { return false; }
            }
            return true;
        }
        public bool RegistNewAccount(string username, string password, string passwordAgain, string name, int age, string Phone, string address, string ID)
        {
            if (username.Trim() == "")
            {
                MessageBox.Show("Hãy nhập vào tên tài khoản bạn muốn đăng kí");
                return false;
            }
            else if (age.ToString().Trim() == "")
            {
                MessageBox.Show("Nhập vào tuổi của bạn");
                return false;
            }
            else if (password.Trim() == "")
            {
                MessageBox.Show("Hãy nhập vào mật khẩu");
                return false;
            }
            else if (name.Trim() == "")
            {
                MessageBox.Show("Hãy nhập vào tên của bạn");
                return false;
            }
            else if (passwordAgain.Trim() == "")
            {
                MessageBox.Show("Hãy nhập vào lại mật khẩu");
                return false;
            }
            else if (Phone.Length != 10 || !CheckNum(Phone))
            {
                MessageBox.Show("Hãy kiểm tra việc nhập sđt của bạn! Gồm 10 số.");
                return false;
            }
            else if (address.Trim() == "")
            {
                MessageBox.Show("Nhập vào địa chỉ của bạn:");
                return false;
            }
            else
            {
                if (DAL_Account.Instance.isExisted(username, Phone) != 0)
                {
                    MessageBox.Show("Tên tài khoản hoặc số điện thoại này đã tồn tại! Hãy chọn 1 tên tài khoản và số điện thoại khác");
                    return false;
                }
                else
                {
                    if (password != passwordAgain)
                    {
                        MessageBox.Show("Nhập lại mật khẩu khác mật khẩu đã đặt!");
                    }
                    else
                    {
                        BLL_Person.Instance.Add(name, age, Phone, address);
                        BLL_Account.Instance.Add(username, password, Phone, "Renter");
                        MessageBox.Show("Đăng kí thành công");
                        return true;
                    }
                }
            }
            return false;
        }
        public string TakePassWord(string username, string phone)
        {
            if (phone.Trim() == "")
            {
                MessageBox.Show("Hãy nhập vào sđt đã đăng kí");
            }
            else if (username.Trim() == "")
            {
                MessageBox.Show("Hãy nhập vào tên tài khoản đã đăng kí");
            }
            else
            {
                if (DAL_Account.Instance.getPasswordByUserName(username, phone) != null)
                {
                    return DAL_Account.Instance.getPasswordByUserName(username, phone);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản này! Vui lòng kiểm tra lại tên đăng nhập là sđt bạn đã đăng kí!");
                    return "";
                }
            }
            return "";
        }
        public void ChangePassWord(string username, string password, string newPass, string newPassAgain)
        {
            if (password.Trim() == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin mật khẩu");
            }
            else if (newPass.Trim() == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin mật khẩu");
            }
            else if (newPassAgain.Trim() == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin mật khẩu");
            }
            if (DAL_Account.Instance.getNumRecord(username, password) > 0)
            {
                if (newPass == newPassAgain)
                {
                    DAL_Account.Instance.Update(username, password, newPass);
                    MessageBox.Show("Thay đổi thành công");
                }
                else
                {
                    MessageBox.Show("Mật khẩu không trùng khớp");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại sai");
            }

        }
    }
}
