//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jewelry_Store
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Product
    {
        public int Product_ref { get; set; }
        public int Order_ref { get; set; }
        public Nullable<decimal> CurrentCost { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
