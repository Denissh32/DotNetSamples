using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Core.Model
{
    
    [DataContract]
    public class Parts
    {
        [DataMember(Name ="night")]
        public Part Night { get; set; }
       
        [DataMember(Name = "morning")]
        public Part Morning { get; set; }

        [DataMember(Name = "day")]
        public Part Day { get; set; }

        [DataMember(Name = "evening")]
        public Part Evening { get; set; }
    }
}
