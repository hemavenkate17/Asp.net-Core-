using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wfm_Models.Models;

namespace Wfm_DBContext.Models
{
   
    public class EFContext : DbContext
    {

        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {

        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Skillmap> skillmap { get; set; }

        public DbSet<Skills> skills { get; set; }

        public DbSet<Softlock> softlock { get; set; }
        public DbSet<Users> users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Skillmap>(
                    eb =>
                    {
                        eb.HasNoKey();
                    });

            modelBuilder
               .Entity<Users>(
                   eb =>
                   {
                       eb.HasNoKey();
                   });
        }

       
    }
}
