using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCardriver
{
    class Persoon
    {
        public string naam { get; set; }
    }

    class Dief : Persoon
    {
        public void Steel()
        {
            Console2.WriteLine("Voertuig werd gestolen door " + naam, ConsoleColor.Yellow);
            Console2.WriteLine("GAME OVER", ConsoleColor.Green);
        }
    }
}