using System;

namespace DefaultLiteralExpressions
{
    // Ref: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/default#default-literal
    class Program
    {
        static T[] InitializeArray<T>(int length, T initialValue = default)
        {
            if (length < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), "Array length must be nonnegative.");
            }

            var array = new T[length];
            for (var i = 0; i < length; i++)
            {
                array[i] = initialValue;
            }
            return array;
        }

        static void Display<T>(T[] values) => Console.WriteLine($"[ {string.Join(", ", values)} ]");

        static void Main(string[] args)
        {
            Func<string, bool> whereClause = default(Func<string, bool>);
            Func<string, bool> whereClause2 = default;
            Console.WriteLine(whereClause == null);
            Console.WriteLine(whereClause2 == null);

            Display(InitializeArray<int>(3));  // output: [ 0, 0, 0 ]
            Display(InitializeArray<bool>(4, default));  // output: [ False, False, False, False ]

            System.Numerics.Complex fillValue = default;
            Display(InitializeArray(3, fillValue));  // output: [ (0, 0), (0, 0), (0, 0) ]
        }
    }
}
