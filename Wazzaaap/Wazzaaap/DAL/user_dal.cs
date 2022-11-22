using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Wazzaaap.DAL
{
    class user_dal
    {
        private MySqlConnection con = new DBconn().get_connection();
        private MySqlCommand cmd = new MySqlCommand();

        private int regista_user(string nome, string password, string bio,string status )
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO users(nome,password,bio,status) VALUES ()";
            return 0;
        }
        

    }
}
