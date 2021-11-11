using System;

// Ref: https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#init-only-setters
namespace InitOnlySetters
{
    class Program
    {
        public struct WeatherObservation
        {
            public DateTime RecordedAt { get; init; }
            public decimal TemperatureInCelsius { get; init; }
            public decimal PressureInMillibars { get; init; }

            public override string ToString() =>
                $"At {RecordedAt:h:mm tt} on {RecordedAt:M/d/yyyy}: " +
                $"Temp = {TemperatureInCelsius}, with {PressureInMillibars} pressure";
        }

        static void Main(string[] args)
        {
            var now = new WeatherObservation
            {
                RecordedAt = DateTime.Now,
                TemperatureInCelsius = 20,
                PressureInMillibars = 998.0m
            };

            // Error! CS8852.
            // now.TemperatureInCelsius = 18;
        }
    }
}
