using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wutdo.api.Models
{
    public class WutdocContext : DbContext
    {
        public DbSet<Poll> Polls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=wutdo.db");
        }
    }
}
