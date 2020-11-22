using podaci.EntityModels;
using System;
using podaci.EF;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dodajte novu opstinu");
            var x = new Opstina
            {
                Naziv = Console.ReadLine()
            };
           MojDbContext dbContext = new MojDbContext();
           dbContext.Add(x);
           dbContext.SaveChanges();
        }
    }
}
