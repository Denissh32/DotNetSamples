using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core
{
    public class WeatherRepository
    {
        private Interfaces.ISerializer<Model.WeatherResponse> serializer;
        private Interfaces.IWebLoader loader;

        private const string source = "https://api.weather.yandex.ru/v1/forecast";
        private const string apiKey = "6209aed2-2e6e-4028-a003-67986871b108";

        public WeatherRepository()
        {
            serializer = new JsonSerializer<WeatherResponse>();0
            loader = new DataHttpLoader();
        }

        public async Task<Model.WeatherResponse> GetWeather(string lat, string lon)
        {
            string request = $"{source}?lat={lat}&lon={lon}" +
                $"&lang=ru_RU&limit=2&extra=true";

            string response;
            try
            {
                response = await loader.LoadDataToString(request, apiKey);
            }
            catch
            {
                return null;
            }

            return serializer.DeserializeFromString(response);
        }
    }
}
