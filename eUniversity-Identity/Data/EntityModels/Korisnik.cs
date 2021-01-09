using System;
using System.Collections.Generic;
using System.Text;
using Data.EntityModels;
using Microsoft.AspNetCore.Identity;

namespace Data.EntityModels
{
   public class Korisnik: IdentityUser
   {
       public string Ime { get; set; }
       public string Prezime { get; set; }

       public Nastavnik Nastavnik { get; set; }
       public Student Student { get; set; }
   }
}
