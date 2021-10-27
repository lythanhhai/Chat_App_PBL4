using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL4_Chat.DAL
{
    class DBHelper
    {
        SqlConnection cnn;
        private static DBHelper _Instance;

        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string cnnstr = @"Data Source=LAPTOP-OUG389DS;Initial Catalog=PBL4;Integrated Security=True";
                    _Instance = new DBHelper(cnnstr);
                }
                return _Instance;
            }
            private set
            {

            }
        }

        private DBHelper(string cnnstr1)
        {
            cnn = new SqlConnection(cnnstr1);
        }

        public void executeQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public DataTable executeNonQuery(string query)
        {
            DataTable data = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            cnn.Open();
            da.Fill(data);
            cnn.Close();
            return data;
        }
    }
}
