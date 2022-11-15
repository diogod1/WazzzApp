using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;

namespace Wazzaaap.Database_models
{
    internal class Context : DbContext
    {
        DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySQL("Server=localhost;Database=wazzaaap;Uid=root;Pwd=;");
        }
    }
}
