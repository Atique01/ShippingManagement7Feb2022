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
    
    public partial class Inbound_Shipment_Status
    {
        public Inbound_Shipment_Status()
        {
            this.Inbound_Shipment = new HashSet<Inbound_Shipment>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Inbound_Shipment> Inbound_Shipment { get; set; }
    }
}
