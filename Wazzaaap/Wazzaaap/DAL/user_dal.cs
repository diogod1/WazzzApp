using MySql.Data.MySqlClient;
using System.Data;
using Wazzaaap.BLL;

namespace Wazzaaap.DAL
{
    public class user_dal
    {
        private MySqlConnection con = new DBconn().get_connection();
        private MySqlCommand cmd = new MySqlCommand();

        public int  regista_user(string username, string password, string nome)
        {
            cmd.Connection = con;
            cmd.CommandText = "SELECT username FROM users WHERE username = '"+username+"'";
            con.Open();

            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if(rdr.GetString(0) != null)
                {
                    MessageBox.Show("Username já existe!", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    return 0;
                }
            }
            con.Close();

            var encrypt_password = new BLL.Encrypt().Encrypt_string(password);
            
            cmd.CommandText = "INSERT INTO users(username,password,name,status,bio) VALUES ('" + username + "','" + encrypt_password + "','" + nome +"',' ',' ')";
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Insert realizado com sucesso");
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", ex.ToString());
            }
            con.Close();

            return 0;
        }

        public int login_user(string username,string password)
        {
            cmd.Connection = con;
            cmd.CommandText = "SELECT username, password FROM users WHERE username = '" + username + "'";
            con.Open();
            using MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                var password_match = new Encrypt().passwords_match(rdr.GetString(1),password);
                
                if(rdr.GetString(0) == username && password_match == 1)
                {
                    return 1;
                }
                else { return 0; }
            }
            con.Close();
            return 0;
        }

        public void init_user(string username)
        {
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM users WHERE username = '" + username + "'";
            con.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr != null)
            {
                while (rdr.Read())
                {
                    user_bl.id = (int)rdr.GetInt64(0);
                    user_bl.password = rdr.GetString(2);
                    user_bl.name = rdr.GetString(3);
                    user_bl.bio = rdr.GetString(4);
                    user_bl.status = rdr.GetString(5);
                }
            }
        }
    }
}
