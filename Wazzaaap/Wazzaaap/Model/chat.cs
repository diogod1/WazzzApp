﻿using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wazzaaap.Model
{
    internal class chat
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public ICollection<chat> Chats { get; set; }
    }
}
