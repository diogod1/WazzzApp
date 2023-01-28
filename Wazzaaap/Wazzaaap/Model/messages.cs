using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wazzaaap.Model
{
    internal class messages
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime SentAt { get; set; }

        //FOREIGN KEYS
        [ForeignKey("Chat")]
        public int? ChatId { get; set; }
        public virtual chats Chat { get; set; }
        [ForeignKey("Group")]
        public int? GroupId { get; set; }
        public virtual groups Group { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual user User { get; set; }
    }
}
