using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.EntityModels
{
    public class Student
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int OpstinaPrebivalistaID { get; set; }
        public Opstina OpstinaPrebivalista { get; set; }
        public int OpstinaRodjenjaID { get; set; }
        public Opstina OpstinaRodjenja { get; set; }

        public string KorisnikID { get; set; }
        public Korisnik Korisnik { get; internal set; }
    }
}
