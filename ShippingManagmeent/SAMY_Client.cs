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
    
    public partial class SAMY_Client
    {
        public SAMY_Client()
        {
            this.Client_Products = new HashSet<Client_Products>();
            this.SalesOrders = new HashSet<SalesOrder>();
        }
    
        public int ID { get; set; }
        public string ClientName { get; set; }
        public string ClientLocation { get; set; }
        public Nullable<System.DateTime> CtrateDate { get; set; }
        public Nullable<System.DateTime> Updatedate { get; set; }
    
        public virtual ICollection<Client_Products> Client_Products { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}