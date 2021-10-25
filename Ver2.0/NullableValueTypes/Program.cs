using System;

namespace NullableValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = 1;
            int? b = null;
            float? c = 0.1f;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
