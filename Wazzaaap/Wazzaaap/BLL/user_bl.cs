using System.Security.Cryptography;
using Wazzaaap.DAL;

namespace Wazzaaap.BLL
{
    internal class user_bl
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string bio { get; set; }
        public string status { get; set; }


        public int login()
        {
            int res = new user_dal().login_user(username, password);
            if (res == 1)
            {
                MessageBox.Show("Entrou na App");
                return 1;
            }
            else
            {
                MessageBox.Show("Falhou o acesso");
                return 0;
            }
        }

        public int register()
        {
            if (password.Length >= 8)
            {
                int res = new user_dal().regista_user(username, password, name);
                if (res == 0)
                {

                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
