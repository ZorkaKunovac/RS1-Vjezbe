using System;

namespace Data.EntityModels
{
    public class Faktura
    {
        public int Id { get; set; }

        public virtual Klijent Klijent { get; set; }
        public int KlijentId { get; set; }

        public DateTime Datum { get; set; }
    }
}
