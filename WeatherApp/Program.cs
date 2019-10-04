using System;
using System.Threading.Tasks;
using WeatherAppLibrary;

namespace WeatherApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var info = await ViewWeather.WeatherCastAsync();

          
            Console.WriteLine("Huminity:" + info.Humidity);
            Console.WriteLine("Temperature:" + info.Temperature);
            Console.WriteLine("Weather:" + info.Weather);
         
        }
    }
}
       


