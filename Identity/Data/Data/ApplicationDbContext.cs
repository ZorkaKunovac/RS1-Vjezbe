using System;
using System.Collections.Generic;
using System.Text;
using Data.EntityModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : IdentityDbContext<Korisnik>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Korisnik>()
            //    .HasKey(k => k.Id);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Korisnik>()
                .HasOne(k => k.Nastavnik)
                .WithOne(n => n.Korisnik)
                .HasForeignKey<Nastavnik>(n => n.KorisnikID);

            modelBuilder.Entity<Korisnik>()
                .HasOne(k => k.Student)
                .WithOne(s => s.Korisnik)
                .HasForeignKey<Student>(s => s.KorisnikID);

        }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Nastavnik> Nastavnici { get; set; }
       // public DbSet<Korisnik> Korisnici { get; set; }
    }
}
