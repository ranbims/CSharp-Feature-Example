using System;

namespace Iterators
{
    class Program
    {
        //Ref: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/iterators
        static void Main()
        {
            int[] numbers = new int[] { 3, 5, 8 };
            foreach (int number in numbers)
            {
                Console.Write(number.ToString() + " ");
            }
            // Output: 3 5 8
            Console.ReadKey();
        }
    }
}
