//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HWEShop.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public double ProductCost { get; set; }
        public double ProductPrice { get; set; }
        public string ProductSeller { get; set; }
        public string ProductImage { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
    
        public virtual Categories Categories { get; set; }
        public virtual Users Users { get; set; }
    }
}
