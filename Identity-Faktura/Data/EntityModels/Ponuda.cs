﻿using System;

namespace Data.EntityModels
{
   
    public class Ponuda
    {
        public int Id { get; set; }

        public virtual Klijent Klijent { get; set; }
        public int KlijentId { get; set; }
        public int? FakturaId { get; set; }
        public Faktura Faktura { get; set; }

        public DateTime Datum { get; set; }
    }
}
