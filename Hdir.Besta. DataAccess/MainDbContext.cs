using Hdir.Tass._DataAccess.Entiteter;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hdir.Tass._DataAccess
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
        }

        public DbSet<BrukerEntitet> Kodeverk { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrukerEntitet>().HasKey(va => new { va.Id });
        }
    }
}
