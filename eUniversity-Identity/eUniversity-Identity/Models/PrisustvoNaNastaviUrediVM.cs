using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity_Identity.Models
{
    public class PrisustvoNaNastaviUrediVM
    {
        public int PrisustvoNaNastaviID { get; set; }
        public string ImeStudenta { get; set; }
        public string NazivPredmeta { get; set; }
        public bool IsPrisutan { get; set; }
        public string Komentar { get; set; }
    }
}
