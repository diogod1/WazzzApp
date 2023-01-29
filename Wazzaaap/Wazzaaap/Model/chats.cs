using System.ComponentModel.DataAnnotations;

namespace Wazzaaap.Model
{
    internal class chats
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}
