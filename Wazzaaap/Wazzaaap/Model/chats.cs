using System.ComponentModel.DataAnnotations;

namespace Wazzaaap.Model
{
    internal class chats
    {
        [Key]
        public int Id { get; set; }

        //FOREIGN KEYS
        public virtual ICollection<Message> Messages { get; set; }
    }
}
