using System.ComponentModel.DataAnnotations;

namespace Wazzaaap.Model
{
    internal class messages
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int chatid { get; set; }
        [Required]
        public int userid { get; set; }
        public string content { get; set; }
        public DateTime sentAt { get; set; }
        public string senderUsername { get; set; }
    }
}
