using System;

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello Extension Methods";

            // This is a call to extension method.
            int i = s.WordCount();

            Console.WriteLine(i);
        }
    }
}
