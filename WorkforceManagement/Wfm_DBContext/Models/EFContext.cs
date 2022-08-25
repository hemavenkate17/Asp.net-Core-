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
/*        public DbSet<Skillmap> tblSkillmaps { get; set; }

        public DbSet<Skills> tblSkills { get; set; }

        public DbSet<Softlock> tblSoftlocks { get; set; }
        public DbSet<Users> tblUsers { get; set; }*/

    }
}
