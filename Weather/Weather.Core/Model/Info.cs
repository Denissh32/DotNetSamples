using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core.Model
{
    [DataContract]
    public class Info
    {
        [DataMember(Name = "lat")]
        public double Latitude { get; set; }

        [DataMember(Name = "lon")]
        public double Longitude { get; set; }

        [DataMember(Name = "geoid")]
        public int Geoid { get; set; }

        [DataMember]
        public string slug { get; set; }

        [DataMember(Name = "def_pressure_mm")]
        public int DefPressureMM { get; set; }

        [DataMember(Name = "def_pressure_pa")]
        public int DefPressurePA { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }
    }
}
