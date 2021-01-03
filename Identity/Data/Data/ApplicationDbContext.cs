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
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Nastavnik> Nastavnici { get; set; }
       // public DbSet<Korisnik> Korisnici { get; set; }
    }
}
