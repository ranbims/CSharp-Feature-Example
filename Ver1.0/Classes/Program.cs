using System;

namespace Classes
{
    /// Ref: https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes
    class Program
    {
        public class Person
        {
            // Constructor that takes no arguments:
            public Person()
            {
                Name = "unknown";
            }

            // Constructor that takes one argument:
            public Person(string name)
            {
                Name = name;
            }

            private string name;

            public string Name 
            { 
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            // Method that overrides the base class (System.Object) implementation.
            public override string ToString()
            {
                return Name;
            }
        }
        class TestPerson
        {
            static void Main()
            {
                // Call the constructor that has no parameters.
                var person1 = new Person();
                Console.WriteLine(person1.Name);

                // Call the constructor that has one parameter.
                var person2 = new Person("Sarah Jones");
                Console.WriteLine(person2.Name);
                // Get the string representation of the person2 instance.
                Console.WriteLine(person2);
            }
        }
    }
}
