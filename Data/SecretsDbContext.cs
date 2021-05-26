using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea5.Data
{
    public class SecretsDbContext : DbContext
    {
        public SecretsDbContext(DbContextOptions<SecretsDbContext> option) : base(option) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Secret> Secrets { get; set; }
    }
}
