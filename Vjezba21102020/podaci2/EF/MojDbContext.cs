using Microsoft.EntityFrameworkCore;
using podaci.EntityModels;

namespace podaci.EF
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
