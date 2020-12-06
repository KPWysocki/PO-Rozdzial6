using System;

namespace _6_5
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj wspolrzedne punktu \nx:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y:");
            int y = int.Parse(Console.ReadLine());
            Punkt p1 = new Punkt(x, y);
            Console.WriteLine("Wybierz operacje do wykonania:\n1. Wyswietl\n2. Przesun\n3. Zamknij program");
            int op = int.Parse(Console.ReadLine());
            while (op < 3)
            { switch (op)
                {
                    case 1:
                        {
                            p1.Wyswietl();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Podaj wspolrzedne wektora przesuniecia \nx:");
                            int xv = int.Parse(Console.ReadLine());
                            Console.Write("y:");
                            int yv = int.Parse(Console.ReadLine());
                            p1.Przesun(xv, yv);
                            break;
                        }
                }
                Console.WriteLine("1. Wyswietl\n2. Przesun\n3. Zamknij program");
                op = int.Parse(Console.ReadLine());
            }
        }
    }
}
