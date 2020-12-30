﻿using System;
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
        private MojDbContext db = new MojDbContext();
        public IActionResult Snimi(StudentDodajVM x)
        {
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Index");

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
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Index");

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
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Index");

            Student s = db.Student.Find(StudentID);

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
            if (HttpContext.GetLogiraniKorisnik() == null)
                return Redirect("/Autentifikacija/Index");

            List<StudentPrikazVM.Row> studenti = db.Student
                .Where(s => search == null || (s.Ime + " " + s.Prezime).StartsWith(search) || (s.Prezime + " " + s.Ime).StartsWith(search))
                //.Include("OpstinaRodsjenja")
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