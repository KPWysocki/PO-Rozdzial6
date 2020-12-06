using System;

namespace _6_3
{
    public class Prostokat
    {
        private int Szerokosc;
        private int Wysokosc;

        public Prostokat(int a, int h)
        {
            Szerokosc = a;
            Wysokosc = h;
        }

        private int powierzchnia()
        {
            int powierzchnia = Szerokosc * Wysokosc;
            return powierzchnia;
        }

        private int obwod()
        {
            int obwod = 2 * (Szerokosc + Wysokosc);
            return obwod;
        }

        public void prezentuj()
        {
            Console.Write("obwod: {0} powierzchnia: {1}", obwod(), powierzchnia());
        }
    }
    
    class Program
    {
        public static void Tester(int[,] tab, int n)
        {
            int goal = 0;
            for (int i = 0; i < n; i++)
            {
                int a = tab[i, 0];
                int h = tab[i, 1];
                int powierzchnia = a * h;
                if (goal < powierzchnia) { goal = powierzchnia; }
            }
            Console.WriteLine("Najwieksza powierzchnia to {0}", goal);
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj ilosc prostokatow: ");
            int n = int.Parse(Console.ReadLine());
            int[,] p1 = new int[n, 2];
            Console.Write("Podaj wymiary prostokata");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n{0}: \nszerokosc: ", i + 1);
                p1[i, 0] = int.Parse(Console.ReadLine());
                Console.Write("wysokosc: ");
                p1[i, 1] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < n; i++)
            {
                int a = p1[i, 0];
                int h = p1[i, 1];
                Prostokat p2 = new Prostokat(a, h);
                Console.Write("Dla prostokata {0} : ", i + 1);
                p2.prezentuj();
                Console.WriteLine();
            }
            Tester(p1, n);
            Console.ReadKey();
        }
    }
}
