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
            public Kärki NuolenKärki { get; set; }
            public Perä NuolenPerä { get; set; }
            public int VarrenPituus { get; set; }

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

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa nuolipajaan! Luo oma nuolesi.");

            Console.WriteLine("Minkälainen kärki (puu, teräs vai timantti)?:");
            Kärki kärki = ValitseKärki();

            Console.WriteLine("Minkälaiset sulat (lehti, kanansulka vai kotkansulka)?:");
            Perä perä = ValitsePerä();

            Console.WriteLine("Nuolen pituus (60-100cm):");
            int pituus = ValitsePituus();



            Nuoli nuoli = new Nuoli
            {
                NuolenKärki = kärki,
                NuolenPerä = perä,
                VarrenPituus = pituus
            };

            Console.WriteLine($"Tämä nuolen hinta on {nuoli.PalautaHinta()} kultaa.");
        }

        static Kärki ValitseKärki()
        {
            while (true)
            {
                string syöte = Console.ReadLine()?.ToLower();
                if (syöte == "puu") return Kärki.Puu;
                if (syöte == "teräs") return Kärki.Teräs;
                if (syöte == "timantti") return Kärki.Timantti;
                Console.WriteLine("Virheellinen syöte. Yritä uudelleen (puu, teräs, timantti):");
            }
        }

        static Perä ValitsePerä()
        {
            while (true)
            {
                string syöte = Console.ReadLine()?.ToLower();
                if (syöte == "lehti") return Perä.Lehti;
                if (syöte == "kanansulka") return Perä.Kanansulka;
                if (syöte == "kotkansulka") return Perä.Kotkansulka;
                Console.WriteLine("Virheellinen syöte. Yritä uudelleen (lehti, kanansulka, kotkansulka]");

            }
        }

        static int ValitsePituus()
        {
            while (true)
            {
                string syöte = Console.ReadLine();
                if (int.TryParse(syöte, out int pituus) && pituus >= 60 && pituus <= 100)
                {
                    return pituus;
                }
                Console.WriteLine("Virheellinen syöte. Anna pituus väliltä 60-100cm;");
            }
        }
    }
}       
