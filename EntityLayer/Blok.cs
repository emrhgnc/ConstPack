using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EntityLayer
{
    [DataContract]
    public class Blok : Base
    {
        [DataMember]
        public int blokId { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int projeId { get; set; }
        [DataMember]
        public string blokAdi { get; set; }
        [DataMember]
        public bool durum { get; set; }
    }
    
}
