//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT()
        {
            this.RECEIPTS = new HashSet<RECEIPT>();
        }
    
        public string Product_ID { get; set; }
        public string Product_CategoryID { get; set; }
        public string Product_Name { get; set; }
        public int Product_Price { get; set; }
        public bool Product_Status { get; set; }
    
        public virtual CATEGORy CATEGORy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECEIPT> RECEIPTS { get; set; }
    }
}
