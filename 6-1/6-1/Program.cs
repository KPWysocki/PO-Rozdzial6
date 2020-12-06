using System;

namespace _6_1
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
                Console.WriteLine("Obwod prostokata wynosi {0}, a pole powierzchni wynosi {1} jednostek", obwod(), powierzchnia());
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Podaj wymiary prostokata \nszerokosc: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("wysokosc: ");
            int h = int.Parse(Console.ReadLine());

            Prostokat p1 = new Prostokat(a, h);

            p1.prezentuj();
            Console.ReadKey();
        }
    }
}
