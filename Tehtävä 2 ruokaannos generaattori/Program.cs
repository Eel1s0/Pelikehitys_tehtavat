namespace Tehtävä_2_ruokaannos_generaattori
{
    internal class Program
    {
        enum PääraakaAine
        {
            Nautaa,
            Kanaa,
            Kasviksia
        }

        enum Lisuke
        {
            Perunaa,
            Riisiä,
            Pastaa
        }

        enum Kastike
        {
            Curry,
            Hapanimelä,
            Pippuri,
            Chili
        }

        class Ateria
        {
            public PääraakaAine PääraakaAine { get; set; }
            public Lisuke Lisuke { get; set; }
            public Kastike Kastike { get; set; }

            public override string ToString()
            {
                return $"{PääraakaAine} ja {Lisuke} {Kastike}-kastikkeella";
            }
        }

        static void Main(string[] args)
        {
            List<Ateria> ateriat = new List<Ateria>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nLuo ruoka-annos {i + 1}:");

                Console.WriteLine("Valitse pääraaka-aine");
                ValitseJaTulostavaihtoehdot<PääraakaAine>();
                PääraakaAine pääraaka = (PääraakaAine)Valitsevaihtoehto(typeof(PääraakaAine));

                Console.WriteLine("Valitse lisuke");
                ValitseJaTulostavaihtoehdot<Lisuke>();
                Lisuke lisuke = (Lisuke)Valitsevaihtoehto(typeof(Lisuke));

                Console.WriteLine("Valitse kastike");
                ValitseJaTulostavaihtoehdot<Kastike>();
                Kastike kastike = (Kastike)Valitsevaihtoehto(typeof(Kastike));

                Ateria ateria = new Ateria
                {
                    PääraakaAine = pääraaka,
                    Lisuke = lisuke,
                    Kastike = kastike
                };

                ateriat.Add(ateria);
                Console.WriteLine($"Ruoka-annos tallennettu: {ateria}");

            }

            Console.WriteLine("\nLoit seuraavat ruoka-annokset:");
            foreach (var ateria in ateriat)
            {
                Console.WriteLine(ateria);
            }

        }

        static void ValitseJaTulostavaihtoehdot<T>() where T : Enum
        {
            string[] vaihtoehdot = Enum.GetNames(typeof(T));
            for (int i = 0; i < vaihtoehdot.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {vaihtoehdot[i]}");
            }
        }

        static int Valitsevaihtoehto(Type enumType)
        {
            while (true)
            {
                string vastaus = Console.ReadLine();
                if (int.TryParse(vastaus, out int valinta) && valinta >= 1 && valinta <= Enum.GetNames(enumType).Length)
                {
                    return valinta - 1;
                }
                Console.WriteLine("Virheellinen valinta, yritä uudelleen");
            }


        }
    }
}
