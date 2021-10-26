using System;

namespace Lambda
{
    class Program
    {
        // Ref: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));
            // Output:
            // 25

            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x;
            Console.WriteLine(e);
            // Output:
            // x => (x * x)

            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };
            greet("World");
            // Output:
            // Hello World!
        }
    }
}
