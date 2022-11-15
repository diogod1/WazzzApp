using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wazzaaap.Database_models
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}
