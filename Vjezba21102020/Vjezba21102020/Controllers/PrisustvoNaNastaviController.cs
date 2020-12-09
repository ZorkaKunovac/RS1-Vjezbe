using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vjezba21102020.EF;
using Vjezba21102020.EntityModels;
using Vjezba21102020.Models;

namespace Vjezba21102020.Controllers
{
    public class PrisustvoNaNastaviController : Controller
    {
        private MojDbContext db = new MojDbContext();
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
                    Prisutan=s.IsPrisutan
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

    }
}
