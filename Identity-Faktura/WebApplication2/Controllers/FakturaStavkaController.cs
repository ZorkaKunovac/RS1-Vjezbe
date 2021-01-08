using System.Linq;
using Data.EntityModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Data;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class FakturaStavkaController : Controller
    {
        private ApplicationDbContext db;
        public FakturaStavkaController( ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index(int FakturaID)
        {
            StavkeFakturePrikaz m = new StavkeFakturePrikaz();
               m.rows = db.FakturaStavka.Where(fs=> fs.FakturaId== FakturaID)
                .Select(fs => new StavkeFakturePrikaz.Rows
                {
                    StavkaID =fs.Id,
                    Proizvod = fs.Proizvod.Naziv,
                    Cijena = fs.Proizvod.Cijena,
                    Kolicina = fs.Kolicina,
                    Popust = fs.PopustProcenat,
                    Iznos = fs.Kolicina * fs.Proizvod.Cijena * (1 - fs.PopustProcenat / 100)
                }).ToList();
            m.FakturaID = FakturaID;
            return View(m);
        }
        public IActionResult Dodaj(int FakturaID)
        {
            var m = new StavkeFaktureDodajVM
            {
                Proizvodi = db.Proizvod.Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Naziv
                }).ToList()
            };
            m.FakturaID = FakturaID;
            return View(m);
        }

        public IActionResult Uredi(int StavkaID)
        {
            StavkeFaktureDodajVM m = new StavkeFaktureDodajVM();

            var s = db.FakturaStavka.Find(StavkaID);
            m.Kolicina = s.Kolicina;
            m.Proizvod = s.ProizvodId;
            m.Proizvodi = db.Proizvod.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.Naziv + "-" + p.Cijena
            }).ToList();

            return View("Dodaj", m);
        }

        public IActionResult Snimi(StavkeFaktureDodajVM s)
        {
            FakturaStavka fakturaStavka;
            if (s.StavkaID == 0) {
                fakturaStavka = new FakturaStavka();
                fakturaStavka.FakturaId = s.FakturaID;
                db.Add(fakturaStavka);
            }
            else
            {
                fakturaStavka = db.FakturaStavka.Find(s.StavkaID);
            }
            fakturaStavka.ProizvodId = s.Proizvod;
            fakturaStavka.Kolicina = s.Kolicina;
            fakturaStavka.PopustProcenat = 5;

            db.SaveChanges();
            return Redirect("/Faktura/Detalji?FakturaID=" + fakturaStavka.FakturaId);
        }


        public IActionResult Obrisi(int StavkeFaktureId)
        {
            FakturaStavka fakturaStavka = db.FakturaStavka.Find(StavkeFaktureId);
            db.Remove(fakturaStavka);
            db.SaveChanges();

            return Redirect("/Faktura/Detalji?FakturaID=" + fakturaStavka.FakturaId);
        }
    }
}
