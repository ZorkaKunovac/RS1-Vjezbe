using System;
using System.Collections.Generic;
using System.Text;

namespace  Data.EntityModels
{
    public class Student
    {
        public int Id { get; set; }
        public string BrojIndeksa { get; set; }
        public string KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}
