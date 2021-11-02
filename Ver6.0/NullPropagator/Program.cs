using System;

namespace NullPropagator
{
    // Ref: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-
    class Program
    {
        static int GetSumOfFirstTwoOrDefault(int[] numbers)
        {
            if ((numbers?.Length ?? 0) < 2)
            {
                return 0;
            }
            return numbers[0] + numbers[1];
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetSumOfFirstTwoOrDefault(null));  // output: 0
            Console.WriteLine(GetSumOfFirstTwoOrDefault(new int[0]));  // output: 0
            Console.WriteLine(GetSumOfFirstTwoOrDefault(new[] { 3, 4, 5 }));  // output: 7
        }
    }
}
