//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Urun()
        {
            this.tbl_Mahal = new HashSet<tbl_Mahal>();
        }
    
        public int intUrun { get; set; }
        public int intKatId { get; set; }
        public string strAdi { get; set; }
        public string strQrCode { get; set; }
        public bool blDurum { get; set; }
    
        public virtual tbl_Kat tbl_Kat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Mahal> tbl_Mahal { get; set; }
    }
}
