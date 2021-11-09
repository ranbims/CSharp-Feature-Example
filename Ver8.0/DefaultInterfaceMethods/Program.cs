using System;

namespace DefaultInterfaceMethods
{
    class Program
    {
        public interface ITest
        {
            public static void StaticMethod()
            {
                Console.WriteLine("This is a static method.");
            }

            public void Method()
            {
                Console.WriteLine("This is a method.");
            }
        }

        class Test : ITest { }

        static void Main(string[] args)
        {
            ITest test = new Test();
            test.Method();

            // not compile
            // test.StaticMethod();

            var test2 = new Test();
            // not compile
            // test2.Method();
        }
    }
}
