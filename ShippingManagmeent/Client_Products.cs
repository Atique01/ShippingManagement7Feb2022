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
    
    public partial class Client_Products
    {
        public Client_Products()
        {
            this.Client_Product_Plan = new HashSet<Client_Product_Plan>();
            this.InventoryPositions = new HashSet<InventoryPosition>();
            this.Product_Number = new HashSet<Product_Number>();
        }
    
        public int ID { get; set; }
        public int ClientID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string Location { get; set; }
        public Nullable<int> Plant { get; set; }
    
        public virtual ICollection<Client_Product_Plan> Client_Product_Plan { get; set; }
        public virtual SAMY_Client SAMY_Client { get; set; }
        public virtual SAMY_Products SAMY_Products { get; set; }
        public virtual ICollection<InventoryPosition> InventoryPositions { get; set; }
        public virtual ICollection<Product_Number> Product_Number { get; set; }
    }
}
