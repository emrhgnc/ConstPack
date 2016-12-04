using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [DataContract]
    public class Proje
    {
        [DataMember]
        public int projeId { get; set; }
        [DataMember]
        public string projeAdi { get; set; }
        [DataMember(EmitDefaultValue =false)]
        public int userId { get; set; }
    }
}
