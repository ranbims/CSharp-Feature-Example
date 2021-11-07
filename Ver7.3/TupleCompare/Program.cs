using System;

namespace TupleCompare
{
    class Program
    {
        public class Test
        {
            int V;
            public Test(int v)
            {
                V = v;
            }

            public override bool Equals(object obj)
            {
                return V == (((Test)obj).V);
            }
        }

        static void Main(string[] args)
        {
            (string Alpha, string Beta) namedLetters = ("a", "b");
            var letters = ("a", "b");
            Console.WriteLine(namedLetters == letters);

            var a = (new Test(1), new Test(1));
            var b = (new Test(1), new Test(1));
            Console.WriteLine(a == b);
            
        }
    }
}
