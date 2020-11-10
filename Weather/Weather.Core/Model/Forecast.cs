using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core.Model
{
    
    [DataContract]
    public class Forecast
    {
        [DataMember(Name ="date")]
        public string Date { get; set; }

        [DataMember(Name = "date_ts")]
        public int DateTS { get; set; }

        [DataMember(Name = "week")]
        public int Week { get; set; }

        [DataMember(Name = "sunrise")]
        public string Sunrise { get; set; }
        
        [DataMember(Name = "sunset")]
        public string Sunset { get; set; }

        [DataMember(Name = "moon_code")]
        public int MoonCode { get; set; }

        [DataMember(Name = "moon_text")]
        public string MoonText { get; set; }
        public Parts parts { get; set; }
    }
}
