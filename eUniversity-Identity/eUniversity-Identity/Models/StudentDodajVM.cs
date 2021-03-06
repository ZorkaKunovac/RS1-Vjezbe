﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eUniversity_Identity.Helper;

namespace eUniversity_Identity.Models
{
    public class StudentDodajVM
    {
        public List<SelectListItem> opstine { get; set; }
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int OpstinaRodjenjaID { get; set; }
        public int OpstinaPrebivalistaID { get; set; }
    }
}
