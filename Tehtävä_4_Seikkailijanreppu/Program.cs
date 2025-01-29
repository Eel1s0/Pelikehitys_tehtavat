namespace Tehtävä_4_Seikkailijanreppu
{
    internal class Program
    {
        public class Tavara
        {
            public double Paino { get; }
            public double Tilavuus { get; }

            public Tavara(double paino, double tilavuus)
            {
                Paino = paino;
                Tilavuus = tilavuus;
            }

        }

        public class Nuoli : Tavara
        {
            public Nuoli() : base(0.1, 0.05) { }

            public override string ToString()
            {
                return "Nuoli";
            }
        }

        public class Jousi : Tavara
        {
            public Jousi() : base(1, 4) { }

            public override string ToString()
            {
                return "Jousi";
            }
        }

        public class Köysi : Tavara
        {
            public Köysi() : base(1, 1.5) { }

            public override string ToString()
            {
                return "Köysi";
            }
        }

        public class Vesi : Tavara
        {
            public Vesi() : base(2, 2) { }

            public override string ToString()
            {
                return "Vesi";
            }
        }

        public class Ruoka : Tavara
        {
            public Ruoka() : base(1, 0.5) { }

            public override string ToString()
            {
                return "Ruoka";
            }
        }


        public class Miekka : Tavara
        {
            public Miekka() : base(5, 3) { }

            public override string ToString()
            {
                return "Miekka";
            }
        }

        public class Reppu
        {
            private readonly int maxTavaraMaara;
            private readonly int maxPaino;
            private readonly int maxTilavuus;
            private readonly List<Tavara> tavarat = new();

            public int TavaroidenMaara => tavarat.Count;
            public double NykyPaino => tavarat.Sum(t => t.Paino);
            public double NykyTilavuus => tavarat.Sum(t => t.Tilavuus);
            public int MaxTavaraMaara => maxTavaraMaara;
            public double MaxPaino => maxPaino;
            public double MaxTilavuus => maxTilavuus;

            public Reppu(int maxTavaraMaara, int maxPaino, int maxTilavuus)
            {
                this.maxTavaraMaara = maxTavaraMaara;
                this.maxPaino = maxPaino;
                this.maxTilavuus = maxTilavuus;
            }

            public bool Lisää(Tavara tavara)
            {
                if (TavaroidenMaara + 1 > maxTavaraMaara ||
                    NykyPaino + tavara.Paino > maxPaino ||
                    NykyTilavuus + tavara.Tilavuus > maxTilavuus)
                {
                    return false;
                }

                tavarat.Add(tavara);
                return true;
            }

            public override string ToString()
            {
                if (tavarat.Count == 0)
                {
                    return "Reppu on tyhjä";
                }

                string sisalto = string.Join(", ", tavarat.Select(t => t.ToString()));
                return $"Repussa on seuraavat tavarat {sisalto}";
            }
        }

        static void Main(string[] args)
        {
            Reppu reppu = new Reppu(10, 30, 20);

            while(true)
            {
                Console.Clear();
                Console.WriteLine(reppu.ToString());

                Console.WriteLine($"Reppu: {reppu.TavaroidenMaara}/{reppu.MaxTavaraMaara} tavaraa, " +
                              $"{reppu.NykyPaino}/{reppu.MaxPaino} painoa, " +
                              $"{reppu.NykyTilavuus}/{reppu.MaxTilavuus} tilavuutta.");
                Console.WriteLine("Mitä haluat lisätä?");
                Console.WriteLine("1 - Nuoli");
                Console.WriteLine("2 - Jousi");
                Console.WriteLine("3 - Köysi");
                Console.WriteLine("4 - Vesi");
                Console.WriteLine("5 - Ruokaa");
                Console.WriteLine("6 - Miekka");
                Console.WriteLine("0 - Lopeta");

                string valinta = Console.ReadLine();

                if (!new[] { "0", "1", "2", "3", "4", "5", "6" }.Contains(valinta))
                {
                    Console.WriteLine("Virheellinen valinta! Paina Enter jatkaaksesi");
                    Console.ReadLine();
                    continue;
                }

                if (valinta == "0") break;

                Tavara tavara = valinta switch
                {
                    "1" => new Nuoli(),
                    "2" => new Jousi(),
                    "3" => new Köysi(),
                    "4" => new Vesi(),
                    "5" => new Ruoka(),
                    "6" => new Miekka(),
                    _ => null
                };

               
                if (reppu.Lisää(tavara))
                {
                    Console.WriteLine("Tavara lisätty reppuun");
                }
                else
                {
                    Console.WriteLine("Tavaraa ei voitu lisätä. Kapasoteetti ylityy");
                }

                Console.WriteLine("Paina Enter jatkaaksesi");
                Console.WriteLine();
            }
        }
    }
}
