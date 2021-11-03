using System;

// Starting with C# 7.0, throw can be used as an expression as well as a statement. 
namespace ThrowExpressions
{
    class Program
    {
        private string name;

        // the conditional operator
        private static void DisplayFirstNumber(string[] args)
        {
            string arg = args.Length >= 1 ? args[0] :
                                       throw new ArgumentException("You must supply an argument");
            if (Int64.TryParse(arg, out var number))
                Console.WriteLine($"You entered {number:F0}");
            else
                Console.WriteLine($"{arg} is not a number.");
        }

        // the null-coalescing operator.
        public string Name
        {
            get => name;
            set => name = value ??
                throw new ArgumentNullException(paramName: nameof(value), message: "Name cannot be null");
        }

        // an expression-bodied lambda or method. 
        DateTime ToDateTime(IFormatProvider provider) =>
         throw new InvalidCastException("Conversion to a DateTime is not supported.");

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
