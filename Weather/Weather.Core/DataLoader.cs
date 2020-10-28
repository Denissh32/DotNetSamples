using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core
{
    public class DataHttpLoader : Interfaces.IWebLoader
    {
        public async Task<string> LoadDataToString(string source, string apiKey = null)
        {
            string result = null;
            using (HttpClient client = new HttpClient())
            {
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(source),
                    Method = HttpMethod.Get,
                };

                if (apiKey != null)
                {
                    request.Headers.Add("X-Yandex-API-Key", apiKey);
                }

                using (HttpResponseMessage response = await client.SendAsync(request))
                {
                    result = await response.Content.ReadAsStringAsync();
                }
            }

            return result;
        }
    }
}
