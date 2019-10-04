using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherAppLibrary
{
    public class ViewWeather
    {
        public static async Task<WeatherInformation> WeatherCastAsync()
        {
            HttpClient httpClient = new HttpClient();
            string Cast = await httpClient.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?q=Cape%20Town&appid=cd5c338abf09f934650cc60c94480f25 ");

            WeatherData view = JsonConvert.DeserializeObject<WeatherData>(Cast);


            
            var info = new WeatherInformation();
            info.Humidity = view.main.humidity;
            info.Temperature = view.main.temperature;
          
            foreach (var weather in view.weather)
            {
                
                info.Weather = weather.description;

            }



            return info;

        }
    }
}

