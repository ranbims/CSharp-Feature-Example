using System;

namespace StaticLocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 5;
            int x = 7;
            Add(x, y);

            static int Add(int left, int right) => left + right;
        }
    }
}
