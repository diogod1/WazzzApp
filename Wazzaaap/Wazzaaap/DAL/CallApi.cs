using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wazzaaap.BLL;
using Wazzaaap.Model;

namespace Wazzaaap.DAL
{
    public class CallApi
    {
        private string user_url;
        private string message_url;

        public CallApi()
        {
            user_url = "https://localhost:7011/api/user";
            message_url= "https://localhost:7011/api/Message";
        }

        public bool Registe_user(string username, string password, string nome)
        {
            List<string> register_list = new List<string>
            {
                username,
                password, 
                nome
            };

            var json = System.Text.Json.JsonSerializer.Serialize(new { register_list });
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(user_url);
                var response = client.PostAsJsonAsync("/Regist-user", register_list).Result;
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool login_user(string username,string password)
        {
            List<string> login_list = new List<string>
            {
                username,
                password
            };

            var json = System.Text.Json.JsonSerializer.Serialize(new { login_list });
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                client.BaseAddress= new Uri(user_url);
                var response = client.PostAsJsonAsync("/login-user", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
