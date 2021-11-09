using System;

namespace UsingDeclarations
{
    class Program
    {
        class TestDispose : IDisposable
        {
            public int Id { get; private set; }

            public TestDispose(int id) => Id = id;

            public void Dispose()
            {
                Console.WriteLine($"Dispose {Id} called.");
            }
        }

        static void Main(string[] args)
        {
            using var testDispose = new TestDispose(1);
            {
                using var testDispose2 = new TestDispose(2);
            }
        }
    }
}
