using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wutdo.api.Models
{
    public class WutdoContext : DbContext
    {
        public WutdoContext(DbContextOptions<WutdoContext> options)
            : base(options)
        { }

        public DbSet<Poll> Polls { get; set; }
    }
}
