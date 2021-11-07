using System;
using System.Collections;
using System.Collections.Generic;

namespace PatternMachingForGenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> testList = new List<int>();
            Console.WriteLine(testList is List<int>);
            Console.WriteLine(testList is IList);
        }
    }
}
