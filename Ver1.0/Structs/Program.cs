using System;

namespace Structs
{
    class Program
    {
        public struct Coords
        {
            public Coords(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; }
            public double Y { get; }

            public override string ToString() => $"({X}, {Y})";
        }

        static void Main(string[] args)
        {
            Coords coords = new Coords(0.1d, 0.2d);
            Console.WriteLine(coords);
        }
    }
}
