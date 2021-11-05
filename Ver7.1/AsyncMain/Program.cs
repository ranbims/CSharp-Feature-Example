using System;
using System.Threading.Tasks;

namespace AsyncMain
{
    class Program
    {
        static async Task<int> Main()
        {
            await Task.Delay(100);
            Console.WriteLine("Executed a task");
            return 0;
        }
    }
}
