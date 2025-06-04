using System;
using System.Collections.Generic;

namespace WeatherApp
{
    public class WeatherViewer
    {
        private static Dictionary<string, string> fakeWeatherData = new Dictionary<string, string>
        {
            { "Київ", "Сонячно, +25°C" },
            { "Львів", "Дощ, +18°C" },
            { "Одеса", "Хмарно, +22°C" }
        };

        public static string GetWeather(string city)
        {
            if (fakeWeatherData.ContainsKey(city))
            {
                return fakeWeatherData[city];
            }
            return "Погода для цього міста недоступна.";
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("=== Перегляд погоди ===");
            Console.Write("Введіть назву міста: ");
            string city = Console.ReadLine();
            string weather = GetWeather(city);
            Console.WriteLine($"Погода у місті {city}: {weather}");
        }
    }
}
