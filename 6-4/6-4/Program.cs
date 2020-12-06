using System;

namespace _6_4
{
    public class Prad
    {
        public static double Initial;
        public static double Current;
        public static double Used;
    public Prad( double a, double b)
        {
        Initial = a;
        Current = b;
        Used = b - a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ktorej z operacji chcesz dokonac:\n1. Wprowadzic dane \n2. Odczytac dane\n3. Obliczyc zuzycie pradu\n4. Zamkniecie programu");
            int x = int.Parse(Console.ReadLine());
            while ( x < 4)
            {
                switch (x)
                {
                    case 1:
                        Console.Write("Podaj poczatkowa wartosc licznika pradu: ");
                        double pocz = double.Parse(Console.ReadLine());
                        Console.Write("Podaj bierzaca wartosc licznika pradu: ");
                        double bierz = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Prad p1 = new Prad(pocz, bierz);
                        break;
                    case 2:
                        Console.WriteLine("Poczatkowa wartosc licznika: {0}\nBierzaca wartosc licznika: {1}\n", Prad.Initial, Prad.Current);
                        break;
                    case 3:
                        Console.WriteLine("Zuzycie wynosi: {0}\n", Prad.Used);
                        break;
                }
                Console.Write("1. Zmiana danych\n2. Odczyt danych\n3. Obliczenie zuzycia pradu\n4. Zamkniecie programu\n");
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
