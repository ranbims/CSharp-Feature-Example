using System;
using System.Collections.Generic;

namespace NullCoalescingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = null;
            int? i = null;

            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            Console.WriteLine(numbers.Count);
            numbers.Add(i ??= 20);
            Console.WriteLine(numbers.Count);

            Console.WriteLine(i);  // output: 17

            int? a = null;
            a ??= 1;
            a ??= 2;
            Console.WriteLine(a);  // output: 1
        }
    }
}
