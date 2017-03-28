using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCardriver
{
    class Program
    {
        static void Main(string[] args)
        {
            Voertuig v = new Voertuig(ConsoleColor.Magenta);
            Voertuig truck = new Vrachtwagen();
            Voertuig brommer = new Brommer();
            Dief Achmed = new Dief();

            truck.Stuur(10);
            brommer.Rij();
            brommer.Stuur(1);
            v.Rij();
            truck.Rij();
            Achmed.naam = "Achmed";
            Achmed.Steel();            
        }
    }
}