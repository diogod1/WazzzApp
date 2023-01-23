using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wazzaaap.Model
{
    internal class messages
    {
        [Key]
        public int id { get; set; }
        public int userid { get; set; }
        public int chatid { get; set; }
        public string content { get; set; }
        [Timestamp]
        public DateTime sentAt { get; set; }
    }
}
