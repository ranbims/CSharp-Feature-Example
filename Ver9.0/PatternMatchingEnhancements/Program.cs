using System;

namespace PatternMatchingEnhancements
{
    // `and`, `or`, `not` could be used in this version.
    static class Program
    {
        public static bool IsLetter(this char c) => 
            c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

        public static bool IsLetterOrSeparator(this char c) =>
            c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';

        static void Main(string[] args)
        {
            char? c = 'a';
            if (c is not null)
            {
                Console.WriteLine(c?.IsLetterOrSeparator());
            }
        }
    }
}
