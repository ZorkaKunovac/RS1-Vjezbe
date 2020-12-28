using System.Linq;
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
            KorisnickiNalog nalog = db.KorisnickiNalog.SingleOrDefault(k => k.KorisnickoIme == x.username && k.Lozinka == x.password);
            if (nalog == null)
            {
                TempData["porukaGreska"] = "Neispravan username/password";
                return Redirect("/Autentifikacija/Index");
            }
            return Redirect("/");
        }
    }
}
