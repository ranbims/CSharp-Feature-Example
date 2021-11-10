using System;
using System.Threading.Tasks;

namespace AsynchronousStreams
{
    // Ref: https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#asynchronous-streams
    class Program
    {
        public static async System.Collections.Generic.IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }

        static async Task Main(string[] args)
        {
            await foreach (var number in GenerateSequence())
            {
                Console.WriteLine(number);
            }
        }
    }
}
