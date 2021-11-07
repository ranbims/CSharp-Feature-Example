using System;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleUsage();
            PerformOperation("SystemTest");    
        }

        // simple usage
        static void SimpleUsage()
        {
            int input = 8;
            int sum = 0;
            if (input is int count)
                sum += count;
            Console.WriteLine(sum);
        }

        // Compare discrete values
        static int PerformOperation(string command) =>
           command switch
           {
               "SystemTest" => 0,
               "Start" => 1,
               "Stop" => 2,
               "Reset" => 3,
               _ => throw new ArgumentException("Invalid string value for command", nameof(command)),
           };

        // Relational patterns, see Version 9.0
        //string WaterState(int tempInFahrenheit) =>
        //    tempInFahrenheit switch
        //    {
        //        (> 32) and (< 212) => "liquid",
        //        < 32 => "solid",
        //        > 212 => "gas",
        //        32 => "solid/liquid transition",
        //        212 => "liquid / gas transition",
        //    };
    }
}
