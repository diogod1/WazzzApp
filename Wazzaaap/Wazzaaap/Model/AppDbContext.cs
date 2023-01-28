using Microsoft.EntityFrameworkCore;

namespace Wazzaaap.Model
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=wazzaaap_sch;uid=root;pwd=");
        }
        public DbSet<user> users { get; set; }
        public DbSet<messages> messages { get; set; }
        public DbSet<chats> chats { get; set; }
        public DbSet<groups> groups { get; set; }
        public DbSet<users_chats> users_chats { get; set; }
        public DbSet<users_groups> users_groups { get; set; }
    }
}