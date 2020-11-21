using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vjezba21102020.EF;
using Vjezba21102020.EntityModels;
using Vjezba21102020.Models;

namespace Vjezba21102020.Controllers
{
    public class StudentController : Controller
    {
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
            List<Opstina> opstine = db.Opstina
           .OrderBy(o => o.Naziv)
           .ToList();

            ViewData["opstine"] = opstine;
            Student s = StudentID == 0 ? new Student() : db.Student.Find(StudentID);
            ViewData["student"] = s;
            return View("Uredi");
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
            List<Student> studenti = mojDb.Student
                .Where(s=> search==null || (s.Ime +" "+ s.Prezime).StartsWith(search) || (s.Prezime + " " + s.Ime).StartsWith(search))
                .Include("OpstinaRodjenja")
                .Include(s=> s.OpstinaPrebivalista)
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