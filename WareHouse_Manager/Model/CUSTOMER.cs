//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WareHouse_Manager.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            this.OUTPUT = new HashSet<OUTPUT>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public string MORE_INFO { get; set; }
        public Nullable<int> REGULAR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OUTPUT> OUTPUT { get; set; }
    }
}
