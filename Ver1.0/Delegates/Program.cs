using System;

namespace Delegates
{
    class Program
    {
        public delegate void Del(string message);

        static void Main(string[] args)
        {
            // Instantiate the delegate. The v1.0 way.
            Del handler = new Del(DelegateMethod);

            // v2.0 way
            // Del handler = DelegateMethod;

            // Call the delegate.
            handler("Hello World");
        }

        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}
