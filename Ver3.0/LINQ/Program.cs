using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    // Ref: https://docs.microsoft.com/en-us/dotnet/csharp/linq/
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            // Output: 97 92 81
        }
    }
}
