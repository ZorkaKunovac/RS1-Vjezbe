using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity_Identity.Models
{
    public class PrisustvoNaNastaviPrikazVM
    {
        public class Zapis
        {
            public string Predmet { get; set; }
            public DateTime Datum { get; set; }
            public bool Prisutan { get; set; }
            public string Komentar { get; set; }
            public int PrisustvoNaNastaviID { get; set; }
        }
        public string ImeStudenta { get; set; }
        public IEnumerable<Zapis> Zapisi { get; set; }
    }
}
