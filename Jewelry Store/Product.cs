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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Order_Product = new HashSet<Order_Product>();
            this.Product_Component = new HashSet<Product_Component>();
        }
    
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public decimal TotalMass { get; set; }
        public int Store_ref { get; set; }
        public bool IsAvaliable { get; set; }
        public int Type_ref { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Product> Order_Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Component> Product_Component { get; set; }
        public virtual Store Store { get; set; }
        public virtual Type Type { get; set; }
    }
}