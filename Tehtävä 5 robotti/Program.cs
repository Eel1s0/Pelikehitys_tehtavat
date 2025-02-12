namespace Tehtävä_5_robotti
{


    internal class Program
    {
        public class Robotti
        {
            public int X { get; set; }
            public int Y { get; set; }
            public bool OnKäynnissä { get; set; }
            public RobottiKäsky?[] Käskyt { get; } = new RobottiKäsky?[3];

            public void Suorita()
            {
                foreach (RobottiKäsky? käsky in Käskyt)
                {
                    käsky?.Suorita(this);
                    Console.WriteLine($"[{X} {Y} {OnKäynnissä}]");
                }
            }
        }

        public abstract class RobottiKäsky
        {
            public abstract void Suorita (Robotti robotti);
        }

        public class Käynnistä : RobottiKäsky
        {
            public override void Suorita(Robotti robotti)
            {
                robotti.OnKäynnissä = true;
            }
        }

        public class Sammuta : RobottiKäsky
        {
            public override void Suorita(Robotti robotti)
            {
                robotti.OnKäynnissä = false;
            }
        }

        public class YlösKäsky : RobottiKäsky
        {
            public override void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä)
                {
                    robotti.Y += 1;
                }
            }
        }

        public class AlasKäsky : RobottiKäsky
        {
            public override void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä)
                {
                    robotti.Y -= 1;
                }
            }
        }

        public class VasenKäsky : RobottiKäsky
        {
            public override void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä)
                {
                    robotti.X -= 1;
                }
            }
        }

        public class OikeaKäsky : RobottiKäsky
        {
            public override void Suorita(Robotti robotti)
            {
                if (robotti.OnKäynnissä)
                {
                    robotti.X += 1;
                }
            }
        }

        static void Main(string[] args)
        {
            Robotti robotti = new Robotti();

            Console.WriteLine("Mitä komentoja syötetään robotille?");
            Console.WriteLine("Vaihtoehdot:");
            Console.WriteLine("1: Käynnistä");
            Console.WriteLine("2: Sammuta");
            Console.WriteLine("3: Ylös");
            Console.WriteLine("4: Alas");
            Console.WriteLine("5: Oikea");
            Console.WriteLine("6: Vasen");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Komento {i + 1}: ");
                string syote = Console.ReadLine();

                robotti.Käskyt[i] = syote switch
                {
                    "1" => new Käynnistä(),
                    "2" => new Sammuta(),
                    "3" => new YlösKäsky(),
                    "4" => new AlasKäsky(),
                    "5" => new OikeaKäsky(),
                    "6" => new VasenKäsky(),
                    _ => null
                };

                if (robotti.Käskyt[i] == null)
                {
                    Console.WriteLine("Virheellinen komento! Yritä uudelleen.");
                    i--; // Retry the same index
                }
            }

            Console.WriteLine("\nSuoritetaan komennot....");
            robotti.Suorita();
        }
    }
}
