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
    
    public partial class Aspnet_Users
    {
        public Aspnet_Users()
        {
            this.Aspnet_Membership = new HashSet<Aspnet_Membership>();
        }
    
        public int UserId { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    
        public virtual ICollection<Aspnet_Membership> Aspnet_Membership { get; set; }
    }
}
