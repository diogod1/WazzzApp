using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wazzaaap.Model
{
    internal class users_chats
    {
        [Key]
        public int Id { get; set; }

        //FOREIGN KEYS
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Chat")]
        public int ChatId { get; set; }
        public virtual chats Chat { get; set; }
    }
}