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
    
    public partial class OUTPUT_DETAIL
    {
        public int ID { get; set; }
        public string OUTPUT_ID { get; set; }
        public Nullable<int> INPUT_DETAIL_ID { get; set; }
        public Nullable<int> AMOUNT { get; set; }
    
        public virtual INPUT_DETAIL INPUT_DETAIL { get; set; }
        public virtual OUTPUT OUTPUT { get; set; }
    }
}
