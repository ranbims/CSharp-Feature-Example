using System;

namespace AnonymousTypes
{
    // Ref: https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types
    class Program
    {
        static void Main(string[] args)
        {
            var v = new { Amount = 108, Message = "Hello" };

            // Rest the mouse pointer over v.Amount and v.Message in the following
            // statement to verify that their inferred types are int and string.
            Console.WriteLine(v.Amount + v.Message);
        }
    }
}
