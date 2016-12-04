using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [DataContract]
    public class Kat
    {
        [DataMember]
        public int katid { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int blokId { get; set; }
        [DataMember]
        public string katAdi { get; set; }
        [DataMember]
        public bool durum { get; set; }
    }
}
