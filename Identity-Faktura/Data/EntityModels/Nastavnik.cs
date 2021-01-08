using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EntityModels
{
    public class Nastavnik
    {
        public int Id { get; set; }
        public string predmet { get; set; }
        public string KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}
