using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
            user_url = "https://localhost:7011/api/User";
            message_url= "https://localhost:7011/api/Message";
        }

        public bool Registe_user(string username, string password, string nome)
        {
            var payload = new { username = username, password = password, name = nome };

            var json = System.Text.Json.JsonSerializer.Serialize(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.PostAsync(""+user_url+"/Register", content).Result;
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
            var payload = new { username = username,password = password };
            var json = JsonConvert.SerializeObject(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.PostAsync(""+user_url+"/Login", content).Result;
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

        public async Task search_user(string username)
        {
            var encondedUsername = HttpUtility.UrlEncode(username);
            using(var client = new HttpClient())
            {
                var response = await client.GetAsync(""+user_url+$"/Search?username={encondedUsername}");
                if (response.IsSuccessStatusCode)
                {
                    var jsoncontent = await response.Content.ReadAsStringAsync(); 
                    user content = JsonConvert.DeserializeObject<user>(jsoncontent);
                    user_bl.id = content.id;
                    user_bl.name = content.name;
                    user_bl.bio = content.bio;
                    user_bl.status = content.status;
                }
                else
                {
                    MessageBox.Show("Erro ao inciar o objeto");
                }
            }
        }
    }
}
