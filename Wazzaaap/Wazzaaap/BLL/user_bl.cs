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

            return 0;
        }

        public int register()
        {
            int res = new user_dal().regista_user(username, password, name, bio, status);
            if(res == 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
