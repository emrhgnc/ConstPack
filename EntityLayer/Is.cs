using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    [DataContract]
    public class Is
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int isId { get; set; }
        [DataMember]
        public int sorumlu { get; set; }
        [DataMember]
        public string ozellik { get; set; }
        [DataMember]
        public int miktar { get; set; }
        [DataMember]
        public int mahalId { get; set; }
        [DataMember]
        public bool tamamlandi { get; set; }
    }
}
