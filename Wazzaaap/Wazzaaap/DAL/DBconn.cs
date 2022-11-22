using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Wazzaaap.DAL
{
    class DBconn
    {
        public MySqlConnection get_connection()
        {
            try
            {
                MySqlConnection conn;
                string myConnectionString = "server=localhost;database=wazzaaap_sch;uid=root;pwd=";
                conn = new MySqlConnection(myConnectionString);
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
