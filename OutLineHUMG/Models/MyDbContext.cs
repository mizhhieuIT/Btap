using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OutLineHUMG.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Subject> ListSubject { get; set;  }
        public DbSet<Specialized> ListSpecialized { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
    }
}
