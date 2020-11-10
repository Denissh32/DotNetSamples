using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core.Model
{
    [DataContract]
    public class Details
    {
        [DataMember]
        public double temp { get; set; }

        [DataMember]
        public double feels_like { get; set; }

        [DataMember]
        public string icon { get; set; }

        [DataMember]
        public string condition { get; set; }

        [DataMember]
        public double wind_speed { get; set; }

        [DataMember]
        public double wind_gust { get; set; }

        [DataMember]
        public string wind_dir { get; set; }

        [DataMember]
        public double pressure_mm { get; set; }

        [DataMember]
        public double pressure_pa { get; set; }

        [DataMember]
        public double humidity { get; set; }

        [DataMember]
        public string daytime { get; set; }

        [DataMember]
        public bool polar { get; set; }

        [DataMember]
        public string season { get; set; }

        [DataMember]
        public double prec_type { get; set; }

        [DataMember]
        public double prec_strength { get; set; }

        [DataMember]
        public double cloudness { get; set; }

        [DataMember]
        public string obs_time { get; set; }
    }
}
