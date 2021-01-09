using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Data.EntityModels;
using eUniversity_Identity.Models;
using eUniversity_Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace eUniversity_Identity.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<Korisnik> _userManager;

        public StudentController(ApplicationDbContext db, UserManager<Korisnik> usermanager)
        {
            this.db = db;
            this._userManager = usermanager;
        }
        public IActionResult Snimi(StudentDodajVM x)
        {
            //if (HttpContext.GetLogiraniKorisnik() == null)
            //    return Redirect("/Autentifikacija/Index");

            Student student;
            if (x.ID == 0)
            {
                student = new Student();
                db.Add(student);
                TempData["PorukaInfo"] = "Uspjesno ste dodali studenta " + x.Ime;
            }
            else
            {
                student = db.Student.Find(x.ID);
                TempData["PorukaInfo"] = "Uspjesno ste updateovali studenta " + student.Ime;
            }
            student.Ime = x.Ime;
            student.Prezime = x.Prezime;
            student.OpstinaRodjenjaID = x.OpstinaRodjenjaID;
            student.OpstinaPrebivalistaID = x.OpstinaPrebivalistaID;

            db.SaveChanges();
            return Redirect("/Student/Poruka");
        }
        public IActionResult Dodaj()
        {
            List<Opstina> opstine = db.Opstina
                .OrderBy(o => o.Naziv)
                .ToList();
            ViewData["opstine"] = opstine;
            return View("Dodaj");
        }
        public IActionResult Uredi(int StudentID)
        {
            //if (HttpContext.GetLogiraniKorisnik() == null)
            //    return Redirect("/Autentifikacija/Index");

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
            //if (HttpContext.GetLogiraniKorisnik() == null)
            //    return Redirect("/Autentifikacija/Index");

            Student s = db.Student.Include(s => s.Korisnik).Single(s => s.ID == StudentID);

            var OcjenaZaBrisati = db.Ocjene.Where(o => o.StudentID == s.ID).ToList();
            var PrisustvoZaBrisati = db.PrisustvoNaNastavi.Where(o => o.StudentID == s.ID).ToList();
            db.RemoveRange(OcjenaZaBrisati);
            db.RemoveRange(PrisustvoZaBrisati);

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
            //if (HttpContext.GetLogiraniKorisnik() == null)
            //    return Redirect("/Autentifikacija/Index");

            List<StudentPrikazVM.Row> studenti = db.Student
                .Where(s => search == null || (s.Ime + " " + s.Prezime).StartsWith(search) || (s.Prezime + " " + s.Ime).StartsWith(search))
                .Select(s => new StudentPrikazVM.Row
                {
                    ID = s.ID,
                    Ime = s.Ime,
                    Prezime = s.Prezime,
                    OpstinaPrebivalista = s.OpstinaPrebivalista.Naziv,
                    OpstinaRodjenja = s.OpstinaRodjenja.Naziv
                })
                .ToList();

            StudentPrikazVM m = new StudentPrikazVM();
            m.studenti = studenti;
            m.search = search;
            return View(m);
        }
    }
}