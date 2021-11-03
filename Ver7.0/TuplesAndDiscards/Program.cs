using System;

// Ref: https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#tuples-and-discards
namespace TuplesAndDiscards
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Alpha, string Beta) namedLetters = ("a", "b");
            Console.WriteLine($"{namedLetters.Alpha}, {namedLetters.Beta}");

            var alphabetStart = (Alpha: "a", Beta: "b");
            Console.WriteLine($"{alphabetStart.Alpha}, {alphabetStart.Beta}");

            int count = 5;
            string label = "Colors used in the map";
            var pair = (count, label); // element names are "count" and "label"

            // Discards
            var (_, pop, _) = QueryCityData("New York City");
        }

        private static (string name, int pop, double size) QueryCityData(string name)
        {
            if (name == "New York City")
                return (name, 8175133, 468.48);

            return ("", 0, 0);
        }
    }
}
