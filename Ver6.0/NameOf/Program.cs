using System;
using System.Collections.Generic;

// Ref: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/nameof
namespace NameOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(nameof(System.Collections.Generic));  // output: Generic
            Console.WriteLine(nameof(List<int>));  // output: List
            Console.WriteLine(nameof(List<int>.Count));  // output: Count
            Console.WriteLine(nameof(List<int>.Add));  // output: Add

            var numbers = new List<int> { 1, 2, 3 };
            Console.WriteLine(nameof(numbers));  // output: numbers
            Console.WriteLine(nameof(numbers.Count));  // output: Count
            Console.WriteLine(nameof(numbers.Add));  // output: Add

            var @new = 5;
            Console.WriteLine(nameof(@new));  // output: new
        }
    }
}
