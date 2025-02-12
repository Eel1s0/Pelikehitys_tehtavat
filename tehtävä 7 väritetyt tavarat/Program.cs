namespace tehtävä_7_väritetyt_tavarat
{

    public class Miekka
    {
        public override string ToString() => "Miekka";
    }

    public class Jousi
    {
        public override string ToString() => "Jousi";
    }

    public class Kirves
    {
        public override string ToString() => "Kirves";
    }

    public class VaritettyTavara<T>
    {
        public T Tavara { get; }
        public ConsoleColor Vari { get; }

        public VaritettyTavara(T tavara, ConsoleColor vari)
        {
            Tavara = tavara;
            Vari = vari;
        }

        public void NaytaTavara()
        {
            Console.ForegroundColor = Vari;
            Console.WriteLine(Tavara.ToString());
            Console.ResetColor();
        }
    }
    internal class Program
    {
        static void Main()
        {
            var miekka = new VaritettyTavara<Miekka>(new Miekka(), ConsoleColor.Blue);
            var jousi = new VaritettyTavara<Jousi>(new Jousi(), ConsoleColor.Red);
            var kirves = new VaritettyTavara<Kirves>(new Kirves(), ConsoleColor.Green);

            miekka.NaytaTavara();
            jousi.NaytaTavara();
            kirves.NaytaTavara();
        }
    }
}