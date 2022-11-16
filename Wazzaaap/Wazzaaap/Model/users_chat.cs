using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wazzaaap.Model
{
    internal class users_chat
    {
        [Key]
        public int id { get; set; }
        public int userID { get; set; }
        public int chatID { get; set; }
    }
}
