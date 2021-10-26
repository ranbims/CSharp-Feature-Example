using System;

namespace PartialMethods
{
    partial class Program
    {
        partial void OnSomethingHappened(string s)
        {
            Console.WriteLine("Something happened: {0}", s);
        }
    }
}
