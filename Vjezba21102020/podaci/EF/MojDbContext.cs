using Microsoft.EntityFrameworkCore;
using podaci.EntityModels;
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
        public DbSet<Ocjene> Ocjene { get; set; }
        public DbSet<Predmet> Predmet { get; set; }
        public DbSet<PrisustvoNaNastavi> PrisustvoNaNastavi { get; set; }
        public DbSet<KorisnickiNalog> KorisnickiNalog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"	Server=localhost;
                                        	Database=23112020;
                                            Trusted_Connection=true;
                                            MultipleActiveResultSets=true;");
        }

    }
}
