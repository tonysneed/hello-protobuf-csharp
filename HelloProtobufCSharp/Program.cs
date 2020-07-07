using System;
using HelloProtobufCSharp.v1.Models;
using Google.Protobuf.WellKnownTypes;
using System.IO;
using Google.Protobuf;

namespace HelloProtobufCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Storage
            byte[] bytes;

            // New weather
            var weather = new WeatherData
            {
                Summary = "Sunny",
                TemperatureF = 70,
                DateTimeStamp = Timestamp.FromDateTime(DateTime.UtcNow)
            };

            // Save to buffer
            using (var memoryStream = new MemoryStream())
            {
                weather.WriteTo(memoryStream);
                bytes = memoryStream.ToArray();
            }

            // Copy from buffer
            var weatherCopy = WeatherData.Parser.ParseFrom(bytes);

            // Perform deep-comparison on equality
            var areEqual = weather.Equals(weatherCopy);
            Console.WriteLine($"Original Weather and copy are equal: {areEqual}");
        }
    }
}
