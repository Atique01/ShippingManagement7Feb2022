//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShippingManagmeent
{
    using System;
    using System.Collections.Generic;
    
    public partial class SAMY_Products
    {
        public SAMY_Products()
        {
            this.Client_Products = new HashSet<Client_Products>();
        }
    
        public int ID { get; set; }
        public string ProdutName { get; set; }
        public string ProductDescription { get; set; }
    
        public virtual ICollection<Client_Products> Client_Products { get; set; }
    }
}