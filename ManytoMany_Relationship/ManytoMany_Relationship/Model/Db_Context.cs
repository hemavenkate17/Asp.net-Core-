using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManytoMany_Relationship.Model
{
    public class Db_Context : DbContext
    {
        public Db_Context(DbContextOptions<Db_Context> options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skillmaps>().HasKey(sc => new { sc.employee_id, sc.skillid });

            modelBuilder.Entity<Skillmaps>()
                .HasOne(s => s.Skills)
                .WithMany(sm => sm.Skillmaps)
                .HasForeignKey(si => si.skillid);

            modelBuilder.Entity<Skillmaps>()
              .HasOne(e => e.Employees)
              .WithMany(sm => sm.Skillmaps)
              .HasForeignKey(si => si.employee_id);

          

        }

        public DbSet<Employees> Employees { get; set; }

        public DbSet<Skills> Skills { get; set; }

        public DbSet<Skillmaps> Skillmaps { get; set; }
    }
}
