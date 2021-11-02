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

            foreach (int number in EvenSequence(5, 18))
            {
                Console.Write(number.ToString() + " ");
            }
            // Output: 6 8 10 12 14 16 18
            Console.ReadKey();
        }

        public static System.Collections.Generic.IEnumerable<int> EvenSequence(int firstNumber, int lastNumber)
        {
            // Yield even numbers in the range.
            for (int number = firstNumber; number <= lastNumber; number++)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }
}
