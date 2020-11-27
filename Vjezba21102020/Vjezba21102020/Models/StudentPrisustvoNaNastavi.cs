using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vjezba21102020.Models
{
    public class StudentPrisustvoNaNastavi
    {
        public class Zapis 
        {
            public string Predmet { get; set; }
            public DateTime Datum { get; set; }
        }
        public string ImeStudenta { get; set; }
       // public IEnumerable<Zapis> Zapis { get; set; }
    }
}
