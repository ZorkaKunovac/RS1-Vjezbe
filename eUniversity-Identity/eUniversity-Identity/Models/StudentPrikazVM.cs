using System.Collections.Generic;

namespace eUniversity_Identity.Models
{
    public class StudentPrikazVM
    {
        public class Row
        {
            public int ID { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public string OpstinaPrebivalista { get; set; }
            public string OpstinaRodjenja { get; set; }
        }
        public List<Row> studenti;
        public string search;

        
    }
}
