using System;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 8;
            int sum = 0;
            if (input is int count)
                sum += count;
            Console.WriteLine(sum);
        }
    }
}
