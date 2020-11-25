using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vjezba21102020.EF;
using Vjezba21102020.EntityModels;
using Vjezba21102020.Helper;
using Vjezba21102020.Models;

namespace Vjezba21102020.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Detalji(int StudentID)
        {
            MojDbContext db = new MojDbContext();
            var m = db.Ocjene.Where(o => o.StudentID == StudentID)
                .Select(o => new StudentDetaljiVM
                {
                    BrojcanaOcjena = o.OcjenaBrojcana,
                    NazivPredmeta = o.Predmet.Naziv,
                    Datum = o.Datum
                }).ToList();
            return View(m);
        }
        // public IActionResult Snimi(int StudentID, string Ime, string Prezime, int OpstinaRodjenjaID, int OpstinaPrebivalistaID)
        public IActionResult Snimi(int StudentID, string Ime, string Prezime, int OpstinaRodjenjaID, int OpstinaPrebivalistaID)
        {
            MojDbContext db = new MojDbContext();
            Student student;
            if (StudentID == 0)
            {
                student = new Student();
                db.Add(student);
                TempData["PorukaInfo"] = "Uspjesno ste dodali studenta " + Ime;
            }
            else
            {
                student = db.Student.Find(StudentID);
                TempData["PorukaInfo"] = "Uspjesno ste updateovali studenta " + Ime;
            }
            student.Ime = Ime;
            student.Prezime = Prezime;
            student.OpstinaRodjenjaID = OpstinaRodjenjaID;
            student.OpstinaPrebivalistaID = OpstinaPrebivalistaID;

            db.SaveChanges();
            return Redirect("/Student/Poruka");
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
        public IActionResult Uredi(int StudentID)
        {
            MojDbContext db = new MojDbContext();
            List<SelectListItem> opstine = db.Opstina
           .OrderBy(o => o.Naziv)
           .Select(o=> new SelectListItem 
           { 
               Value=o.ID.ToString(),
               Text=o.Naziv
           })
           .ToList();

            //ViewData["opstine"] = opstine;
            // StudentDodajVM s = StudentID == 0 ? new StudentDodajVM() 
            StudentDodajVM s;
            if (StudentID == 0)
                s = new StudentDodajVM() { };
            else
                s= db.Student
                .Where(s => s.ID == StudentID)
                .Select(s => new StudentDodajVM
                {
                    ID = s.ID,
                    Ime = s.Ime,
                    Prezime = s.Prezime,
                    OpstinaPrebivalistaID = s.OpstinaPrebivalistaID,
                    OpstinaRodjenjaID = s.OpstinaRodjenjaID,
                }).Single();
            s.opstine = opstine;
              
          //  ViewData["student"] = s;
            return View("Uredi",s);
        }
        public IActionResult Obrisi(int StudentID)
        {
            MojDbContext db = new MojDbContext();
            Student s = db.Student.Find(StudentID);
            db.Remove(s);
            db.SaveChanges();

            TempData["PorukaInfo"] = "Uspjesno ste izbrisali studenta " + s.Ime;
            return Redirect("/Student/Poruka");
        }
        public IActionResult Poruka()
        {
            return View("Poruka");
        }
        public IActionResult Prikaz(string search)
        {
            MojDbContext mojDb = new MojDbContext();
            List<StudentPrikazVM.Row> studenti = mojDb.Student
                .Where(s => search == null || (s.Ime + " " + s.Prezime).StartsWith(search) || (s.Prezime + " " + s.Ime).StartsWith(search))
                //.Include("OpstinaRodjenja")
                //.Include(s=> s.OpstinaPrebivalista)
                .Select(s => new StudentPrikazVM.Row
                {
                    ID = s.ID,
                    Ime = s.Ime,
                    Prezime = s.Prezime,
                    OpstinaPrebivalista = s.OpstinaPrebivalista.Naziv,
                    OpstinaRodjenja = s.OpstinaRodjenja.Naziv
                })
                .ToList();

            //ViewData["search"] = search;
            //ViewData["studenti"] = studenti;
            StudentPrikazVM m = new StudentPrikazVM();
            m.studenti = studenti;
            m.search = search;
            return View(m);
        }
    }
}