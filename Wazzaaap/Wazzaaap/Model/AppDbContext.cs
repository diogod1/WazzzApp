using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Wazzaaap.Model
{
    internal class AppDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=wazzaaap_sch;uid=root;pwd=");
        }
        public DbSet<user> users { get; set; }
        public DbSet<messages> messages { get; set; }
        public DbSet<chat> chats { get; set; }
        
    }
}