using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Data.EntityModels;
using eUniversity_Identity.Models;
using eUniversity_Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace eUniversity_Identity.Controllers
{
    public class StudentOcjeneController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<Korisnik> _userManager;

        public StudentOcjeneController(ApplicationDbContext db, UserManager<Korisnik> usermanager)
        {
            this.db = db;
            this._userManager = usermanager;
        }
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
                    OcjenaID = o.ID,
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
