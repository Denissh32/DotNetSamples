using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core.Model
{
    [DataContract]
    public class WeatherResponse
    {
        [DataMember(Name = "now")]
        public int Now { get; set; }

        [DataMember(Name = "now_dt")]
        public DateTime NowDt { get; set; }

        [DataMember(Name = "info")]
        public Info Info { get; set; }

        [DataMember(Name = "geo_object")]
        public GeoObject Geo { get; set; }

        [DataMember(Name = "fact")]
        public Details Facts { get; set; }

        [DataMember(Name = "forecasts")]
        public List<Forecast> Forecasts { get; set; }
    }
}
