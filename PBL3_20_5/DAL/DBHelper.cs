using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBHelper
    {

        private SqlConnection _cnn;
        private static DBHelper _Instance;

        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string s = @"Data Source=LAPTOP-7R6E6U5K\SQLEXPRESS;Initial Catalog=SQL_Export;Integrated Security=True";
                    _Instance = new DBHelper(s);
                }
                return _Instance;
            }
            private set { }
        }

        private DBHelper(string s)
        {
            _cnn = new SqlConnection(s);
        }

        public DataTable GetRecords(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, _cnn);
            _cnn.Open();
            da.Fill(dt);
            _cnn.Close();
            return dt;
        }

        public void ExecuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, _cnn);
            _cnn.Open();
            cmd.ExecuteNonQuery();
            _cnn.Close();
        }

        public int GetRecordCount(string query)
        {
            int recordCount = 0;
            SqlCommand cmd = new SqlCommand(query, _cnn);
            _cnn.Open();
            object result = cmd.ExecuteScalar();
            _cnn.Close();
            if (result != null && int.TryParse(result.ToString(), out recordCount))
            {
                return recordCount;
            }
            else
            {
                return -1;
            }
        }

    }
}
