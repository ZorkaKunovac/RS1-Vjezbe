using System;

namespace Data.EntityModels
{
    public class Ocjene
    {
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public int ID { get; set; }
        public int PredmetID { get; set; }
        public Predmet Predmet { get; set; }
        public DateTime Datum { get; set; }
        public int OcjenaBrojcana { get; set; }
    }
}
