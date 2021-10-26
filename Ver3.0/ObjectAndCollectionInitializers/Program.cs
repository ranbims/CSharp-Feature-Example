using System;
using System.Collections.Generic;

// Ref: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
namespace ObjectAndCollectionInitializers
{
    public class Cat
    {
        // Auto-implemented properties.
        public int Age { get; set; }
        public string Name { get; set; }

        public Cat()
        {
        }

        public Cat(string name)
        {
            this.Name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object initializers
            Cat cat = new Cat { Age = 10, Name = "Fluffy" };
            Cat sameCat = new Cat("Fluffy") { Age = 10 };

            // collection initializers
            List<int> digits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

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
        }
    }
}
