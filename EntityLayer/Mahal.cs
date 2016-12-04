using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [DataContract]
    public class Mahal
    {
        [DataMember]
        public int mahalId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int urunId { get; set; }
        [DataMember]
        public int mahalTipId { get; set; }
        [DataMember]
        public string mahalAdi { get; set; }
        [DataMember]
        public bool durum { get; set; }
    }
}
