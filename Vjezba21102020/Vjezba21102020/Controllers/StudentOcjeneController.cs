using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vjezba21102020.EF;
using Vjezba21102020.Models;

namespace Vjezba21102020.Controllers
{
    public class StudentOcjeneController : Controller
    {
        MojDbContext db = new MojDbContext();

        public IActionResult Prikaz(int StudentID)
        {
            var m = db.Ocjene.Where(o => o.StudentID == StudentID)
               .Select(o => new StudentOcjenePrikazVM
               {
                   OcjenaID=o.ID,
                   BrojcanaOcjena = o.OcjenaBrojcana,
                   NazivPredmeta = o.Predmet.Naziv,
                   Datum = o.Datum
               }).ToList();
            return View(m);
        }
        public IActionResult Uredi(int StudentID)
        {
            return View();
        }
    }
}
