//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KingBKOT.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_PurchaseMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_PurchaseMaster()
        {
            this.tbl_PurchaseDetails = new HashSet<tbl_PurchaseDetails>();
        }
    
        public long pId { get; set; }
        public string refNo { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<decimal> totalWeight { get; set; }
        public string unit { get; set; }
        public Nullable<decimal> totalAmt { get; set; }
        public string remarks { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PurchaseDetails> tbl_PurchaseDetails { get; set; }
    }
}