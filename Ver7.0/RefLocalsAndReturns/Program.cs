using System;

namespace RefLocalsAndReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 0, 1, 2, 3, 4, 5 };
            ref var ele = ref list[1];
            ele = 11;
            Console.WriteLine(list[1]);

            ref var ele2 = ref getElementAt(list, 2);
            ele2 = 12;
            Console.WriteLine(list[2]);
        }

        static ref int getElementAt(int[] list, int pos)
        {
            return ref list[pos];
        }
    }
}
