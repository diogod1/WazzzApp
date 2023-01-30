using System.Security.Cryptography;
using Wazzaaap.DAL;

namespace Wazzaaap.BLL
{
    public static class user_bl
    {
        public static int id;
        public static string username;
        public static string password;
        public static string name;
        public static string  bio;
        public static string  status;
        public static string photopath;


        public static int login()
        {
            int res = new user_dal().login_user(username, password);
            if (res == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int register()
        {
            if (password.Length >= 8)
            {
                int res = new user_dal().regista_user(username, password, name);
                if (res == 0)
                {

                    return 0;//falha no registo
                }
                else
                {
                    return 1;//sucesso
                }
            }
            else
            {
                return 2;//Retorna 2 Falha de Password
            }
        }

        public static void init_user(string username)
        {
            user_dal ini_user = new user_dal(); 
            ini_user.init_user(username);
        }
    }
}
