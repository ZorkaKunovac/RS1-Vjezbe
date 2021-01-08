using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eUniversity_Identity.Models
{
    public class StudentOcjenePrikazVM
    {
        public int OcjenaID { get; set; }
        public string NazivPredmeta { get; set; }
        public int BrojcanaOcjena { get; set; }
        public DateTime Datum { get; set; }
    }
}
