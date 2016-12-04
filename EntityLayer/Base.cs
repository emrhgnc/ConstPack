using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [DataContract]
    public class Base
    {
        [DataMember]
        public bool result { get; set; }
        [DataMember]
        public int errorId { get; set; }
        [DataMember]
        public string errorMsg { get; set; }
        [DataMember]
        public Object data { get; set; }

    }
}
