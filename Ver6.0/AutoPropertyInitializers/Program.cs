using System;

namespace AutoPropertyInitializers
{
    public class Person
    {
        public string FirstName { get; set; } = string.Empty;
    }


    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            Console.WriteLine(person.FirstName != null);
        }
    }
}
