using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wazzaaap.Model
{
    internal class users_group
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int userID { get; set; }
        [Required]
        public int groupID { get; set; }
    }
}
