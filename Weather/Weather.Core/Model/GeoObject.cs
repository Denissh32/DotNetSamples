using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core.Model
{
    [DataContract]
    public class GeoObject
    {
        [DataMember(Name = "locality")]
        public GeoObjectPart Locality { get; set; }


        [DataMember(Name = "province")]
        public GeoObjectPart Province { get; set; }


        [DataMember(Name = "country")]
        public GeoObjectPart Country { get; set; }
    }
}
