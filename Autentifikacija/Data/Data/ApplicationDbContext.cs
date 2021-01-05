using System;
using System.Collections.Generic;
using System.Text;
using Data.EntityModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Autentifikacija.Data
{
    public class ApplicationDbContext : IdentityDbContext<Korisnik>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Korisnik>()
            .HasOne(s => s.Nastavnik)
            .WithOne(ad => ad.Korisnik)
            .HasForeignKey<Nastavnik>(ad => ad.KorisnikID);

            builder.Entity<Korisnik>()
           .HasOne(s => s.Student)
           .WithOne(ad => ad.Korisnik)
           .HasForeignKey<Student>(ad => ad.KorisnikID);
        }

        public DbSet<Nastavnik> Nastavnik { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
