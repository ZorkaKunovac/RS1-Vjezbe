using Microsoft.AspNetCore.Http;
using Data.EntityModels;

namespace eUniversity_Identity.Helper
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
