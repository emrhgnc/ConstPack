using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [DataContract]
    public class Kullanici
    {
        [DataMember]
        public int kullaniciId { get; set; }
        [DataMember]
        public string kullaniciAdi { get; set; }
        [DataMember]
        public string unvan { get; set; }
        [DataMember]
        public int rolId { get; set; }
        [DataMember]
        public string eposta { get; set; }
        [DataMember]
        public bool durum { get; set; }
        [DataMember(EmitDefaultValue =false)]
        public string password { get; set; }
    }
}
