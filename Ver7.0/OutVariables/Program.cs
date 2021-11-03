using System;

namespace OutVariables
{
    public class B
    {
        public B(int i, out int j)
        {
            j = i;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 0;
            var B = new B(i, out j);
            Console.WriteLine(j); // 1
        }
    }
}
