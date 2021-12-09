using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousMembers
{
    public class AwaitBehaviorExample
    {
        private static async Task CountAsync()
        {
            Console.WriteLine(1);
            await Task.Delay(10);
            Console.WriteLine(2);
        }

        public static async Task TestAwaitBehaviorAsync()
        {
            Console.WriteLine(0);
            await CountAsync();
            Console.WriteLine(3);
            // expected output: 0 1 2 3
        }

        public static async Task TestUnawaitBehaviorAsync()
        {
            Console.WriteLine(0);
            CountAsync();
            Console.WriteLine(3);
            // expected output: 0 1 3 2
        }
    }
}
