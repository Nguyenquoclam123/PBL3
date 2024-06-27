using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBHelper_Admin
    {
        private SqlConnection _cnn;
        private static DBHelper_Admin _Instance;

        public static DBHelper_Admin Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string s = @"Data Source=LAPTOP-7R6E6U5K\SQLEXPRESS;Initial Catalog=SQL_Export;Integrated Security=True";
                    _Instance = new DBHelper_Admin(s);
                }
                return _Instance;
            }
            private set { }
        }

        private DBHelper_Admin(string s)
        {
            _cnn = new SqlConnection(s);
        }
        public DataTable GetRecords(string queri)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(queri, _cnn);
            _cnn.Open();
            da.Fill(dt);
            _cnn.Close();
            return dt;

        }
        public void ExecuteDB(string queri)
        {
            SqlCommand cmd = new SqlCommand(queri, _cnn);
            _cnn.Open();
            cmd.ExecuteNonQuery();
            _cnn.Close();
        }

        public void ExecuteDBB(string queri, SqlParameter[] parameter)
        {
            SqlCommand cmd = new SqlCommand(queri, _cnn);
            cmd.Parameters.AddRange(parameter); // Thêm tham số vào câu truy vấn
            _cnn.Open();
            cmd.ExecuteNonQuery();
            _cnn.Close();
        }
    }
}
