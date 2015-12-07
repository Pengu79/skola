using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Program
    {
        public void Main(string[] args)
        {
            double dowJones = 0.046d;
            double nasdaq = 0.041d;
            double stockholm = -0.024d;
            double milano = 0.067d;
            double paris = -0.055d;
            const double PI = Math.PI;
            string name = "Jonas";
            string city = "Helsingborg";
            string place = "Statena";


            int year = 36;
            Console.WriteLine("Hej jag är {0}år gamal", year);
            year = 37;
            Console.WriteLine("Snart är jag {0}år gamal", year);
            Console.WriteLine("Dow Jones sjönk med {0:P1} och Nasdaq med {1:P1}. Stockholm {2:P1}, Milano {3:P1}, Paris {4:P1}.", dowJones, nasdaq, stockholm, milano, paris);
            Console.WriteLine("Talet π är cirka {0} men kan avrundas till {1:F2} och kan lite grovt skrivas som {2:F0}", PI, PI, PI);
            Console.WriteLine($"Han heter {name} och bor i {city} vid {place}");
        }
    }
}
