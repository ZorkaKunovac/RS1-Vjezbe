using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity_Identity.Models
{
    public class StudentOcjenaUrediVM
    {
        public int OcjenaID { get; set; }
        public string ImeStudenta { get; set; }
        public string NazivPredmeta { get; set; }
        public int Ocjena { get; set; }
    }
}
