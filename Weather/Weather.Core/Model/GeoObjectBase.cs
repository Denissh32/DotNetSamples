using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core.Model
{
    [DataContract]
    public class GeoObjectPart
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
