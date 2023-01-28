using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wazzaaap.Model
{
    public class users_groups
    {
        [Key]
        public int Id { get; set; }

        //FOREIGN KEYS
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public virtual groups group { get; set; }
    }
}
