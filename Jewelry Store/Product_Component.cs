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
    
    public partial class Product_Component
    {
        public int Component_ref { get; set; }
        public int Product_ref { get; set; }
        public decimal PartMass { get; set; }
    
        public virtual Component Component { get; set; }
        public virtual Product Product { get; set; }
    }
}
