namespace tehtävä_1_ovi
{
    internal class Program
    {
        // Määritellään enum oven tiloille
        enum OviTilat
        {
            Lukossa,
            Kiinni,
            Auki
        }

        // Määritellään enum toiminnoille
        enum Toiminto
        {
            Avaa,
            Lukitse,
            AvaaLukko,
            Sulje
        }

        static void Main(string[] args)
        {
            // Alustetaan oven tila
            OviTilat tila = OviTilat.Lukossa;

            while (true)
            {
                Console.WriteLine($"\nOven tila: {tila}");
                Console.WriteLine("Valitse toiminto seuraavista:");

                // Tulostetaan mahdolliset toiminnot
                string[] toiminnot = Enum.GetNames<Toiminto>();
                for (int i = 0; i < toiminnot.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: {toiminnot[i]}");
                }

                // Luetaan käyttäjän valinta
                string vastaus = Console.ReadLine();
                if (int.TryParse(vastaus, out int valinta) && valinta >= 1 && valinta <= toiminnot.Length)
                {
                    // Muutetaan käyttäjän valinta enumiksi
                    Toiminto valittu = (Toiminto)(valinta - 1);

                    // Suoritetaan toiminto tilan mukaan
                    switch (tila)
                    {
                        case OviTilat.Lukossa:
                            if (valittu == Toiminto.AvaaLukko)
                            {
                                tila = OviTilat.Kiinni;
                                Console.WriteLine("Lukko avattu.");
                            }
                            else
                            {
                                Console.WriteLine("Toiminto ei ole mahdollinen tässä tilassa.");
                            }
                            break;

                        case OviTilat.Kiinni:
                            if (valittu == Toiminto.Avaa)
                            {
                                tila = OviTilat.Auki;
                                Console.WriteLine("Ovi avattiin.");
                            }
                            else if (valittu == Toiminto.Lukitse)
                            {
                                tila = OviTilat.Lukossa;
                                Console.WriteLine("Ovi lukittiin.");
                            }
                            else
                            {
                                Console.WriteLine("Toiminto ei ole mahdollinen tässä tilassa.");
                            }
                            break;

                        case OviTilat.Auki:
                            if (valittu == Toiminto.Sulje)
                            {
                                tila = OviTilat.Kiinni;
                                Console.WriteLine("Ovi suljettiin.");
                            }
                            else
                            {
                                Console.WriteLine("Toiminto ei ole mahdollinen tässä tilassa.");
                            }
                            break;

                        default:
                            Console.WriteLine("Tuntematon tila.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Virheellinen valinta. Yritä uudelleen.");
                }
            }
        }
    }
}