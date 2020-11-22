using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vjezba21102020.EntityModels;

namespace Vjezba21102020.EF
{
    public class MojDbContext: DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Opstina> Opstina { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"	Server=localhost;
                                        	Database=21102023;
                                            Trusted_Connection=true;
                                            MultipleActiveResultSets=true;");
        }

    }
}
