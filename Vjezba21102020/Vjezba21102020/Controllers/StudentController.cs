using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vjezba21102020.EF;
using Vjezba21102020.EntityModels;

namespace Vjezba21102020.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Snimi(string Ime, string Prezime, int OpstinaPrebivalistaID, int OpstinaRodjenjaID)
        {
            var student = new Student
            {
                Ime = Ime,
                Prezime = Prezime,
                OpstinaPrebivalistaID = OpstinaPrebivalistaID,
                OpstinaRodjenjaID = OpstinaRodjenjaID
            };
            MojDbContext db = new MojDbContext();
            db.Add(student);
            db.SaveChanges();

            return Redirect("/Student/Prikaz");
        }
        public IActionResult Dodaj()
        {
            MojDbContext mojDb = new MojDbContext();
            List<Opstina> opstine = mojDb.Opstina
                .OrderBy(o => o.Naziv)
                .ToList();
            ViewData["opstine"] = opstine;
            return View("Dodaj");
        }
        public IActionResult Obrisi(int StudentID)
        {
            MojDbContext db = new MojDbContext();
            Student s = db.Student.Find(StudentID);
            db.Remove(s);
            db.SaveChanges();

            TempData["PorukaInfo"] = "Uspjesno ste izbrisali studenta" + s.Ime;
            return Redirect("/Student/Poruka");
        }
        public IActionResult Prikaz(string search)
        {
            MojDbContext mojDb = new MojDbContext();
            List<Student> studenti = mojDb.Student
                .Where(s=> search==null || (s.Ime +" "+ s.Prezime).StartsWith(search) || (s.Prezime + " " + s.Ime).StartsWith(search))
                .Include("OpstinaRodjenja")
                .Include(s=> s.OpstinaPrebivalista)
                .ToList();
            
            ViewData["search"] = search;
            ViewData["studenti"] = studenti;
            return View();
        }
    }
}