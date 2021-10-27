using System;
using System.Runtime.CompilerServices;

// Ref: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/attributes/caller-information
namespace CallerInfoAttributes
{
    class Program
    {
        public static void DoProcessing()
        {
            TraceMessage("Something happened.");
        }

        public static void TraceMessage(string message,
                [CallerMemberName] string memberName = "",
                [CallerFilePath] string sourceFilePath = "",
                [CallerLineNumber] int sourceLineNumber = 0)
        {
            Console.WriteLine("message: " + message);
            Console.WriteLine("member name: " + memberName);
            Console.WriteLine("source file path: " + sourceFilePath);
            Console.WriteLine("source line number: " + sourceLineNumber);
        }

        // Sample Output:
        //  message: Something happened.
        //  member name: DoProcessing
        //  source file path: c:\Visual Studio Projects\CallerInfoCS\CallerInfoCS\Form1.cs
        //  source line number: 31

        static void Main(string[] args)
        {
            DoProcessing();
        }
    }
}
