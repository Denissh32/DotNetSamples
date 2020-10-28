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
    }
}
