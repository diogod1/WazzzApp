using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wazzaaap.Model
{
    internal class message
    {
        [Key]
        public int id { get; set; }
        public int userid { get; set; }
        public int chatid { get; set; }
        public int groupid { get; set; }
        public string content { get; set; }
        [Timestamp]
        public DateTime sentAt { get; set; }
        [Timestamp]
        public DateTime deliveredAt { get; set; }
    }
}
