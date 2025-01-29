namespace Tehtävä_3__nuolia_kaupan
{
    internal class Program
    {
        enum Kärki
        {
            Puu,
            Teräs,
            Timantti
        }

        enum Perä
        {
            Lehti,
            Kanansulka,
            Kotkansulka
        }

        class Nuoli
        {
            public Kärki NuolenKärki {  get; private set; }
            public Perä NuolenPerä { get; private set; }
            public double VarrenPituus { get; private set; }

            public Nuoli(Kärki nuolenKärki, Perä nuolenPerä, double varrenPituus)
            {
                NuolenKärki = nuolenKärki;
                NuolenPerä = nuolenPerä;
                VarrenPituus = varrenPituus;
            }

            public Kärki GetNuolenKärki()
            {
                return NuolenKärki;
            }

            public Perä GetNuolenPerä()
            {
                return NuolenPerä;
            }

            public double GetVarrenPituus()
            {
                return VarrenPituus;
            }

            public double PalautaHinta()
            {
                double kärkiHinta = NuolenKärki switch
                {
                    Kärki.Puu => 3,
                    Kärki.Teräs => 5,
                    Kärki.Timantti => 50,
                    _ => 0
                };

                double peräHinta = NuolenPerä switch
                {
                    Perä.Lehti => 0,
                    Perä.Kanansulka => 1,
                    Perä.Kotkansulka => 5,
                    _ => 0
                };

                double varsiHinta = VarrenPituus * 0.05;


                return kärkiHinta + peräHinta + varsiHinta;
            }

            public static Nuoli LuoEliittiNuoli()
            {
                return new Nuoli(Kärki.Timantti, Perä.Kotkansulka, 100);
            }

            public static Nuoli LuoAloittelijanuoli()
            {
                return new Nuoli(Kärki.Puu, Perä.Kanansulka, 70);
            }

            public static Nuoli LuoPerusnuoli()
            {
                return new Nuoli(Kärki.Teräs, Perä.Kanansulka, 85);
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Valitse nuolityyppi:");
            Console.WriteLine("1: Eliittinuoli (Timanttikärki, 100 cm varsi, Kotkansulka)");
            Console.WriteLine("2: Aloittelijanuoli (Puukärki, 70 cm varsi, Kanansulka)");
            Console.WriteLine("3: Perusnuoli (Teräskärki, 85 cm varsi, Kanansulka)");
            Console.WriteLine("4: Tee kustomoitu nuoli");

            string valinta = Console.ReadLine();

            Nuoli nuoli;

            switch (valinta)
            {
                case "1":
                    nuoli = Nuoli.LuoEliittiNuoli();
                    break;
                case "2":
                    nuoli = Nuoli.LuoAloittelijanuoli();
                    break;
                case "3":
                    nuoli = Nuoli.LuoPerusnuoli();
                    break;
                case "4":
                    nuoli = TeeKustomoituNuoli();
                    break;
                default:
                    Console.WriteLine("Virheellinen valinta");
                    return;
            }



            Console.WriteLine($"Tämä nuolen hinta on {nuoli.PalautaHinta()} kultaa.");

        }

        static Nuoli TeeKustomoituNuoli()
        {
            Console.WriteLine("Nuolenkärki (puu, teräs, timantti):");
            Kärki kärki = ValitseKärki();

            Console.WriteLine("Nuolen perä (lehti, kanansulka, kotkansulka):");
            Perä perä = ValitsePerä();

            Console.WriteLine("Nuolen pituus (60-100 cm):");
            double pituus = ValitsePituus();

            return new Nuoli(kärki, perä, pituus);
        }

        static Kärki ValitseKärki()
        {
            string input = Console.ReadLine()?.ToLower();
            return input switch
            {
                "puu" => Kärki.Puu,
                "teräs" => Kärki.Teräs,
                "timantti" => Kärki.Timantti,
                _ => throw new ArgumentException("Virheellinen kärki.")
            };
        }

        static Perä ValitsePerä()
        {
            string input = Console.ReadLine()?.ToLower();
            return input switch
            {
                "lehti" => Perä.Lehti,
                "kanansulka" => Perä.Kanansulka,
                "kotkansulka" => Perä.Kotkansulka,
                _ => throw new ArgumentException("Virheellinen perä.")
            };
        }

        static int ValitsePituus()
        {
            double pituus = double.Parse(Console.ReadLine());
            if (pituus < 60 || pituus > 100)
                throw new ArgumentException("Pituuden tulee olla 60-100 cm.");
            return (int)pituus;
        }

        


    }
}       
