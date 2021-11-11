using System;

// Ref: https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#record-types
namespace RecordTypes
{
    class Program
    {
        public abstract record APerson(string FirstName, string LastName)
        {
            public string[] PhoneNumbers { get; init; }
        }

        public record Person(string FirstName, string LastName) 
            : APerson(FirstName, LastName);

        public static void Main()
        {
            Person person1 = new("Nancy", "Davolio") { PhoneNumbers = new string[1] };
            Console.WriteLine(person1);
            // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }

            Person person2 = person1 with { FirstName = "John" };
            Console.WriteLine(person2);
            // output: Person { FirstName = John, LastName = Davolio, PhoneNumbers = System.String[] }
            Console.WriteLine(person1 == person2); // output: False

            person2 = person1 with { PhoneNumbers = new string[1] };
            Console.WriteLine(person2);
            // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }
            Console.WriteLine(person1 == person2); // output: False

            person2 = person1 with { };
            Console.WriteLine(person1 == person2); // output: True
        }
    }
}
