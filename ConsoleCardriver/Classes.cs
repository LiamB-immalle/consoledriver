using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCardriver
{
    class Voertuig
    {
        private ConsoleColor kleur;

        public Voertuig(ConsoleColor kleur)
        {
            this.kleur = kleur;
        }

        public virtual void Rij()
        {
            Console2.WriteLine("Het {{voertuig}} rijdt...", ConsoleColor.White, kleur);
        }

        public virtual void Stuur(int graden)
        {
            Console.WriteLine("");
        }
    }

    class Auto : Voertuig
    {
        public Auto() : base(ConsoleColor.DarkYellow)
        {
        }

        public override void Rij()
        {
            Console2.WriteLine("De auto rijdt...", ConsoleColor.Red);
        }
    }

    class Vrachtwagen : Voertuig
    {
        public Vrachtwagen()
            : base(ConsoleColor.Green)
        {
        }

        public override void Rij()
        {
            Console2.WriteLine("De vrachtwagen rijdt...", ConsoleColor.Red);
        }

        public override void Stuur(int graden)
        {
            Console.WriteLine("De vrachtwagenchauffeur rijdt in op de menigte.");
            base.Stuur(graden);
        }

        public void LaadLeeg()
        {
        }
    }

    class Brommer : Voertuig
    {
        public Brommer() : base(ConsoleColor.White) { }

        public override void Rij()
        {
            Console2.WriteLine("De broemmer is gestolen!", ConsoleColor.Red);
        }

        public override void Stuur(int graden)
        {
            Console.WriteLine("De dief kijkt niet");
            base.Stuur(graden);
        }
    }
}
