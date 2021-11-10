using System;

namespace EnhancedPatternMatching
{
    class Program
    {
        #region Switch expressions
        static int PerformOperation(string command) =>
           command switch
           {
               "SystemTest" => 0,
               "Start" => 1,
               "Stop" => 2,
               "Reset" => 3,
               _ => throw new ArgumentException("Invalid string value for command", nameof(command)),
           };
        #endregion

        #region Property patterns
        public class Address
        {
            public Address(String state) => State = state; 
            public string State { get; set; }
        }

        public static decimal ComputeSalesTax(Address location, decimal salePrice) =>
            location switch
            {
                { State: "WA" } => salePrice * 0.06M,
                { State: "MN" } => salePrice * 0.075M,
                { State: "MI" } => salePrice * 0.05M,
                // other cases removed for brevity...
                _ => 0M
            };
        #endregion

        #region Tuple patterns
        public static string RockPaperScissors(string first, string second)
            => (first, second) switch
            {
                ("rock", "paper") => "rock is covered by paper. Paper wins.",
                ("rock", "scissors") => "rock breaks scissors. Rock wins.",
                ("paper", "rock") => "paper covers rock. Paper wins.",
                ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
                ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
                ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
                (_, _) => "tie"
            };
        #endregion

        #region Positional patterns
        // Beginning with C# 8.0, you use a positional pattern to deconstruct an expression
        // result and match the resulting values against the corresponding nested patterns,
        // as the following example shows:

        public class Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y) => (X, Y) = (x, y);

            public void Deconstruct(out int x, out int y) =>
                (x, y) = (X, Y);
        }

        public enum Quadrant
        {
            Unknown,
            Origin,
            One,
            Two,
            Three,
            Four,
            OnBorder
        }

        static Quadrant GetQuadrant(Point point) => point switch
        {
            (0, 0) => Quadrant.Origin,
            var (x, y) when x > 0 && y > 0 => Quadrant.One,
            var (x, y) when x < 0 && y > 0 => Quadrant.Two,
            var (x, y) when x < 0 && y < 0 => Quadrant.Three,
            var (x, y) when x > 0 && y < 0 => Quadrant.Four,
            var (_, _) => Quadrant.OnBorder,
            _ => Quadrant.Unknown
        };
        #endregion


        static void Main(string[] args)
        {
            Console.WriteLine(PerformOperation("Start"));
            Console.WriteLine(ComputeSalesTax(new Address("WA"), 0.1m));
            Console.WriteLine(GetQuadrant(new Point(0, 0)));
        }
    }


}
