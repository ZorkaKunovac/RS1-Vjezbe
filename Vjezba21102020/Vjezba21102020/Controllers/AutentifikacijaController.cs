using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using podaci.EntityModels;
using Vjezba21102020.EF;
using Vjezba21102020.Models;

namespace Vjezba21102020.Controllers
{
    public class AutentifikacijaController : Controller
    {
        MojDbContext db = new MojDbContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(AutentifikacijaIndexVM x)
        {
            KorisnickiNalog nalog = db.KorisnickiNalog.Where(k => k.KorisnickoIme == x.username && k.Lozinka == x.password).SingleOrDefault();
            if (nalog == null)
            {
                TempData["porukaGreska"] = "Neispravan username/password";
                return View("Index");
            }
            return Redirect("/");
        }
    }
}
