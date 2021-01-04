using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.EntityModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Data;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class FakturaController : Controller
    {
        private ApplicationDbContext db;
        public FakturaController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var m = db.Faktura
                .Select(f => new FakturaPrikazVM
                {
                    FakturaId = f.Id,
                    ImeKlijenta = f.Klijent.ImePrezime,
                    Datum = f.Datum
                }).ToList();
            return View(m);
        }
        public IActionResult Dodaj()
        {
            var m = new FakturaDodajVM
            {
                KlijentStavke = db.Klijent
                .Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.ImePrezime
                }).ToList(),
                PonudaStavke = db.Ponuda.Where(p=> p.FakturaId==null)
                .Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Klijent.ImePrezime + " - " + s.Datum.ToString("dd.MM.yyyy")
                }).ToList(),
                Datum = DateTime.Now
            };

            return View(m);
        }
        public IActionResult Snimi(FakturaDodajVM f)
        {
            Faktura faktura= new Faktura
            {
                Datum = f.Datum,
                KlijentId = f.KlijentID,
            };
            db.Add(faktura);
            if(f.PonudaID!=null)
            {
                Ponuda p = db.Ponuda.Find(f.PonudaID);
                p.Faktura = faktura;

                List<PonudaStavka> ponudaStavke = db.PonudaStavka.Where(ps => ps.PonudaId==p.Id).ToList();
                ponudaStavke.ForEach(ps =>
                {
                    db.Add(new FakturaStavka
                    {
                        Faktura = faktura,
                        ProizvodId = ps.ProizvodId,
                        Kolicina = ps.Kolicina,
                        PopustProcenat = 5
                    });
                });
            }
            db.SaveChanges();
            return Redirect("/Faktura/Index");
        }
        public IActionResult Obrisi(int FakturaID)
        {
            Faktura f = db.Faktura.Find(FakturaID);
            db.Remove(f);
            List<FakturaStavka> fStavke = db.FakturaStavka.Where(fs => fs.FakturaId == FakturaID).ToList();
            db.RemoveRange(fStavke);

            List<Ponuda> ponude= db.Ponuda.Where(p => p.FakturaId == FakturaID).ToList();
            ponude.ForEach(p =>
            {
                p.FakturaId = null;
            });

            db.SaveChanges();
            return Redirect("/Faktura/Index");
        }
        public IActionResult Detalji(int FakturaID)
        {
            FakturaDetaljiVM m = db.Faktura.Where(f => f.Id == FakturaID)
                .Select(f => new FakturaDetaljiVM
                {
                    FakturaId=f.Id,
                    ImeKlijenta = f.Klijent.ImePrezime,
                    Datum = f.Datum
                }).FirstOrDefault();
              
            return View(m);
        }
    }
}