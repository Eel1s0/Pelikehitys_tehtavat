namespace Tehtävä_6_ruudukko_koordinaatisto
{

    public struct Koordinaatti
    {
        public int X { get; }
        public int Y { get; }

        public Koordinaatti(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Metodi tarkistaa, onko koordinaatti toisen vieressä
        public bool OnVieressä(Koordinaatti toinen)
        {
            int dx = Math.Abs(X - toinen.X);
            int dy = Math.Abs(Y - toinen.Y);

            // Koordinaatti on vieressä, jos se on yhden yksikön päässä joko X- tai Y-suunnassa
            return (dx == 1 && dy == 0) || (dx == 0 && dy == 1) || (dx == 1 && dy == 1);
        }

        public override string ToString()
        {
            return $"Koordinaatti: ({X}, {Y})";
        }
    }
    internal class Program
    {


        static void Main()
        {
            Koordinaatti keskipiste = new Koordinaatti(0, 0);
            Koordinaatti[] koordinaatit =
            {
            new Koordinaatti(-1, -1),
            new Koordinaatti(-1, 0),
            new Koordinaatti(-1, 1),
            new Koordinaatti(0, -1),
            new Koordinaatti(0, 0),
            new Koordinaatti(0, 1),
            new Koordinaatti(1, -1),
            new Koordinaatti(1, 0),
            new Koordinaatti(1, 1),
        };

            foreach (Koordinaatti k in koordinaatit)
            {
                if (k.Equals(keskipiste))
                {
                    Console.WriteLine($"Annettu {k} on koordinaatissa {keskipiste}.");
                }
                else if (k.OnVieressä(keskipiste))
                {
                    Console.WriteLine($"Annettu {k} on koordinaatin {keskipiste} vieressä.");
                }
                else
                {
                    Console.WriteLine($"Annettu {k} ei ole koordinaatin {keskipiste} vieressä.");
                }
            }
        }
    }
}