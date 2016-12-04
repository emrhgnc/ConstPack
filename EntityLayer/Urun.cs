using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [DataContract]
    public class Urun
    {
        [DataMember]
        public int urunId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int katId { get; set; }
        [DataMember]
        public string urunAdi { get; set; }
        [DataMember]
        public bool durum { get; set; }
    }
}
