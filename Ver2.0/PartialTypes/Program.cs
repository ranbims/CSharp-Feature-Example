using System;

namespace PartialTypes
{
    // Ref: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods#partial-classes
    class Program
    {
        public partial class Coords
        {
            private int x;
            private int y;

            public Coords(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public partial class Coords
        {
            public void PrintCoords()
            {
                Console.WriteLine("Coords: {0},{1}", x, y);
            }
        }

        // Output: Coords: 10,15
        static void Main(string[] args)
        {
            Coords myCoords = new Coords(10, 15);
            myCoords.PrintCoords();

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
