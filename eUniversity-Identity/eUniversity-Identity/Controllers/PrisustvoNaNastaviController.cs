using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Data.EntityModels;
using eUniversity_Identity.Models;
using eUniversity_Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace eUniversity_Identity.Controllers
{
    public class PrisustvoNaNastaviController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<Korisnik> _userManager;

        public PrisustvoNaNastaviController(ApplicationDbContext db, UserManager<Korisnik> usermanager)
        {
            this.db = db;
            this._userManager = usermanager;
        }
        public IActionResult Prikaz(int StudentID)
        {
            var m = new PrisustvoNaNastaviPrikazVM();
            Student s = db.Student.Find(StudentID);
            m.ImeStudenta = s.Ime + " " + s.Prezime;
            m.Zapisi = db.PrisustvoNaNastavi.Where(s => s.StudentID == StudentID)
                .Select(s => new PrisustvoNaNastaviPrikazVM.Zapis
                {
                    Datum = s.Datum,
                    Predmet = s.Predmet.Naziv,
                    Komentar=s.Komentar,
                    Prisutan=s.IsPrisutan,
                    PrisustvoNaNastaviID=s.ID
                }).ToList();
            return View(m);
        }
        public IActionResult Uredi(int PrisustvoNaNastaviID)
        {
            PrisustvoNaNastaviUrediVM m = db.PrisustvoNaNastavi.Where(p => p.ID == PrisustvoNaNastaviID)
                .Select(p => new PrisustvoNaNastaviUrediVM
                {
                    PrisustvoNaNastaviID = p.ID,
                    ImeStudenta = p.Student.Ime + " " + p.Student.Prezime,
                    NazivPredmeta = p.Predmet.Naziv,
                    IsPrisutan = p.IsPrisutan,
                    Komentar = p.Komentar
                }).Single();
            return View(m);
        }
        public IActionResult Snimi(PrisustvoNaNastaviUrediVM x)
        {
            PrisustvoNaNastavi prisustvo = db.PrisustvoNaNastavi.Find(x.PrisustvoNaNastaviID);
            prisustvo.IsPrisutan = x.IsPrisutan;
            prisustvo.Komentar = x.Komentar;
            db.SaveChanges();
            return Redirect("/PrisustvoNaNastavi/Prikaz?StudentID=" + prisustvo.StudentID);
        }
    }
}
