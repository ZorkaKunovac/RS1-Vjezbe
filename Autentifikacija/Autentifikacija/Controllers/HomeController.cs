using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Autentifikacija.Models;
using Data.EntityModels;
using Microsoft.AspNetCore.Identity;
using Autentifikacija.Data;
using Microsoft.AspNetCore.Authorization;

namespace Autentifikacija.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<Korisnik> _userManager;
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _db;
        public HomeController(ILogger<HomeController> logger, UserManager<Korisnik> userManager, ApplicationDbContext db)
        {
            _logger = logger;
            _userManager = userManager;
            _db = db;
        }
        [Authorize]
        public IActionResult Index()
        {
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
            var korisnik = new Nastavnik
            {
                Email = email,
                UserName = email,
                Ime = ime,
                Prezime = prezime,
                EmailConfirmed = true,
                Zvanje = "prof dr"
            };
            IdentityResult result = _userManager.CreateAsync(korisnik, "Mostar2020!").Result;

            if (!result.Succeeded)
            {
                return "errors: " + string.Join('|', result.Errors);
            }
            return "Nastavnik je uspješno dodat";
        }


    }
}
