//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject_CoffeeShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class SupplyPurchase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SupplyPurchase()
        {
            this.SupplyPurchaseInfoes = new HashSet<SupplyPurchaseInfo>();
        }
    
        public int purchase_id { get; set; }
        public int employee_in_charge { get; set; }
        public Nullable<int> supplier_id { get; set; }
        public System.DateTime purchase_date { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyPurchaseInfo> SupplyPurchaseInfoes { get; set; }
    }
}