using System.Collections.Generic;

namespace IndexInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Dictionary<int, string>
            {
                [7] = "seven",
                [9] = "nine",
                [13] = "thirteen"
            };

            var moreNumbers = new Dictionary<int, string>
            {
                {19, "nineteen" },
                {23, "twenty-three" },
                {42, "forty-two" }
            };

            var dict = new Dictionary<string, int>()
            {
                ["foo"] = 34,
                ["bar"] = 42
            };
        }
    }
}
