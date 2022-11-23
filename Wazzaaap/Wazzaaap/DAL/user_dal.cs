using MySql.Data.MySqlClient;

namespace Wazzaaap.DAL
{
    public class user_dal
    {
        private MySqlConnection con = new DBconn().get_connection();
        private MySqlCommand cmd = new MySqlCommand();

        public int  regista_user(string username, string password, string nome, string bio, string status)
        {
            cmd.Connection = con;
            cmd.CommandText = "SELECT username FROM users WHERE username = '"+username+"'";
            con.Open();

            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if(rdr.GetString(0) != null)
                {
                    MessageBox.Show("Username já existe!",rdr.ToString());
                    con.Close();
                    return 0;
                }
            }
            con.Close();
            
            cmd.CommandText = "INSERT INTO users(username,password,name,bio,status) VALUES ('" + username + "','" + password + "','" + nome + "','" + bio + "','" + status + "')";
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
                if(rdr.GetString(0) == username && rdr.GetString(1) == password)
                {
                    return 1;
                }
                else { return 0; }
            }
            return 0;
        }
    }
}
