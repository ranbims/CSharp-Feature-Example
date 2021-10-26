using System.Collections.Generic;

// `var` could be used in ver3.0
namespace ImplicitlyTypedLocalVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 10; // Implicitly typed.
            var xs = new List<int>();
        }
    }
}
