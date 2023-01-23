using MySql.Data.MySqlClient;
using System.Data;
using Wazzaaap.BLL;

namespace Wazzaaap.DAL
{
    public class user_dal
    {
        private CallApi _callapi;
        
        public user_dal()
        {
            _callapi = new CallApi();
        }
        public int  regista_user(string username, string password, string nome)
        {
            var result = _callapi.Registe_user(username, password, nome);
            if(result == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int login_user(string username,string password)
        {
            var result = _callapi.login_user(username, password);
            if (result == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public async void init_user(string username)
        {
           await _callapi.search_user(username);
        }
    }
}
