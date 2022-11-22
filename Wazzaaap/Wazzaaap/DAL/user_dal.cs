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
            cmd.CommandText = "INSERT INTO users(username,password,name,bio,status) VALUES ('" + username + "','" + password + "','" + nome + "','" + bio + "','" + status + "')";
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Insert realizado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", ex.ToString());
            }
            con.Close();

            return 0;
        }
    }
}
