using Microsoft.AspNetCore.Http;
using podaci.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vjezba21102020.Helper
{
    public static class Autentifikacija
    {
        public static void SetLogiraniKorisnik(this HttpContext httpContext, KorisnickiNalog k)
        {
            httpContext.Session.Set<KorisnickiNalog>("NekiKljucVarijabla", k);
        }
        public static KorisnickiNalog GetLogiraniKorisnik(this HttpContext httpContext)
        {
            var k = httpContext.Session.Get<KorisnickiNalog>("NekiKljucVarijabla");
            return k;
        }
    }
}
