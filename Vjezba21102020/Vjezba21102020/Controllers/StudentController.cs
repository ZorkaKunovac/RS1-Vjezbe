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
        public IActionResult Prikaz(string search)
        {
            MojDbContext mojDb = new MojDbContext();
            List<Student> podaci = mojDb.Student
                .Where(s=> search=="" || search==null || (s.Ime.StartsWith(search) || s.Prezime.StartsWith(search)) )
                .Include(s=> s.OpstinaPrebivalista)
                .Include(s => s.OpstinaRodjenja)
                .ToList();
            ViewData["nekiKey"] = podaci;
            return View();
        }
    }
}