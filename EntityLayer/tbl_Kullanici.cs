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
    
    public partial class tbl_Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Kullanici()
        {
            this.tbl_Is = new HashSet<tbl_Is>();
        }
    
        public int intKullaniciId { get; set; }
        public string strKullaniciAdi { get; set; }
        public string strUnvan { get; set; }
        public int intRol { get; set; }
        public string strEposta { get; set; }
        public Nullable<bool> blOturum { get; set; }
        public bool blDurum { get; set; }
        public Nullable<System.DateTime> dtSonGiris { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Is> tbl_Is { get; set; }
        public virtual tbl_Rol tbl_Rol { get; set; }
    }
}
