using System;

namespace ExpressionBodiedMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            Console.WriteLine(p.ToString());
        }

        public override string ToString() => "This is an expression body";
    }
}
