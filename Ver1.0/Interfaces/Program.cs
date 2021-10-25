using System;

namespace Interfaces
{
    // Ref: https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces
    class Program
    {
        interface IEquatable
        {
            bool Equals(object obj);
        }

        public class Car : IEquatable
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public string Year { get; set; }

            // Implementation of IEquatable<T> interface
            public override bool Equals(object obj)
            {
                if (!(obj is Car))
                {
                    return false;
                }

                Car car = (Car)obj;
                return (this.Make, this.Model, this.Year) ==
                    (car.Make, car.Model, car.Year);
            }
        }

        static void Main(string[] args)
        {
            Car carA = new Car { Make = "test_make", Model = "test_model", Year = "2021" };
            Car carB = new Car { Make = "test_make", Model = "test_model", Year = "2021" };
            Console.WriteLine(carA.Equals(carB));
        }
    }
}
