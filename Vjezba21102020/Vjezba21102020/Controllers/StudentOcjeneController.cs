using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using podaci.EntityModels;
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
        public IActionResult Uredi(int OcjenaID)
        {
            StudentOcjenaUrediVM m = db.Ocjene.Where(o => o.ID == OcjenaID)
                .Select(o => new StudentOcjenaUrediVM
                {
                    OcjenaID = o.OcjenaBrojcana,
                    ImeStudenta=o.Student.Ime+" "+o.Student.Prezime,
                    NazivPredmeta = o.Predmet.Naziv,
                    Ocjena=o.OcjenaBrojcana
                }).Single();
 
            return View(m);
        }
        public IActionResult Snimi(StudentOcjenaUrediVM x)
        {
            Ocjene ocjene = db.Ocjene.Find(x.OcjenaID);
            ocjene.OcjenaBrojcana = x.Ocjena;
            db.SaveChanges();

            //    return RedirectToAction("Prikaz", new { StudentID=ocjene.StudentID });
            return Redirect("/StudentOcjene/Prikaz?StudentID=" + ocjene.StudentID);
        }
    }
}
