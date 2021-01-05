using Microsoft.AspNetCore.Identity;

namespace Data.EntityModels
{
    public class Korisnik: IdentityUser
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

    }
}
