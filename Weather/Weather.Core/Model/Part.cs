using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core.Model
{
    [DataContract]
    public class Part: Details
    {
        [DataMember]
        public double temp_min { get; set; }

        [DataMember]
        public double temp_max { get; set; }

        [DataMember]
        public double temp_avg { get; set; }

        [DataMember]
        public double prec_mm { get; set; }

        [DataMember]
        public double prec_period { get; set; }
    }
}
