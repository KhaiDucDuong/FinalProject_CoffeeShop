//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject_CoffeeShop_EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventory_info
    {
        public int check_id { get; set; }
        public int ingredient_id { get; set; }
        public double quantity_per_unit { get; set; }
    
        public virtual Ingredient Ingredient { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
