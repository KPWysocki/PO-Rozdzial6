using System;

namespace _6_6
{
    public class Punkt
    {
        private int WspolrzednaX { get; set; }
        private int WspolrzednaY { get; set; }
        public Punkt(int x, int y)
        {
            WspolrzednaX = x;
            WspolrzednaY = y;
        }
        public void Wyswietl()
        {
            Console.WriteLine("Wspolrzedne punktu to ({0},{1})", WspolrzednaX, WspolrzednaY);
        }
        public void Przesun(int xv, int yv)
        {
            WspolrzednaX = WspolrzednaX + xv;
            WspolrzednaY = WspolrzednaY + yv;
        }
        public static void Tester(Punkt[] tab)
        {
            if(tab[0].WspolrzednaX.Equals (tab[1].WspolrzednaX.Equals(tab[2].WspolrzednaX)))
            {
                Console.WriteLine("Punkty leza na prostej poziomej");
            }
            else if (tab[0].WspolrzednaY.Equals(tab[1].WspolrzednaY.Equals(tab[2].WspolrzednaY)))
            {
                Console.WriteLine("Punlty leza na prostej pionowej");
            }
            else
            {
                Console.WriteLine("Punkty nie leza na prostej");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Punkt[] tab = new Punkt[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Podaj wspolrzedne punktu {0} \nx:",i+1);
                int x = int.Parse(Console.ReadLine());
                Console.Write("y:");
                int y = int.Parse(Console.ReadLine());
                tab[i] = new Punkt(x, y);
            }
            Punkt.Tester(tab);
            Console.ReadKey();
        }
    }
}
