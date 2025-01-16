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
            public PääraakaAine Pääraaka { get; set; }
            public Lisuke Lisuke { get; set; }
            public Kastike Kastike { get; set; }

            public override string ToString()
            {
                return $"{Pääraaka} ja {Lisuke} {Kastike}-kastikkeella";
            }


            static void Main(string[] args)
            {

            }

        }
    }
}
