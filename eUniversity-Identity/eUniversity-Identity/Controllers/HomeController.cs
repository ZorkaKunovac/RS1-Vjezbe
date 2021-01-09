using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eUniversity_Identity.Models;
using Microsoft.AspNetCore.Identity;
using Data.EntityModels;
using eUniversity_Identity.Data;
using Microsoft.AspNetCore.Authorization;

namespace eUniversity_Identity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public UserManager<Korisnik> _userManager { get; set; }
        private ApplicationDbContext _db { get; set; }
        public HomeController(ILogger<HomeController> logger, UserManager<Korisnik> userManager, ApplicationDbContext db)
        {
            _logger = logger;
            _userManager = userManager;
            _db = db;
        }

        [Authorize]
         public IActionResult Index()
        {
            //if (HttpContext.GetLogiraniKorisnik() == null)
            //    return Redirect("/Autentifikacija/Index");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public string DodajNastavnika(string ime, string prezime)
        {
            string email = ime + "." + prezime + "@edu.fit.ba";
            var korisnik = new Korisnik
            {
                Email = email,
                UserName = email,
                Ime = ime,
                Prezime = prezime,
                EmailConfirmed = true,
            };
            IdentityResult result = _userManager.CreateAsync(korisnik, "Mostar2020!").Result;

            if (!result.Succeeded)
            {
                return "errors: " + string.Join('|', result.Errors);
            }

            Nastavnik nastavnik = new Nastavnik
            {
                Korisnik = korisnik,
                Zvanje = "prof dr"
            };
            _db.Nastavnik.Add(nastavnik);
            _db.SaveChanges();
            return "Nastavnik je uspješno dodat";
        }

    }
}
