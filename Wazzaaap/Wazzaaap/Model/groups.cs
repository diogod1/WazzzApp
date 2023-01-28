using System.ComponentModel.DataAnnotations;

namespace Wazzaaap.Model
{
    internal class groups
    {
        [Key]
        public int Id { get; set; }

        //FOREIGN KEYS
        public virtual ICollection<groups> group { get; set; }
    }
}
