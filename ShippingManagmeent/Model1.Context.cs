﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SAMYEntities : DbContext
    {
        public SAMYEntities()
            : base("name=SAMYEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Batch_Comments> Batch_Comments { get; set; }
        public DbSet<Client_Product_Plan> Client_Product_Plan { get; set; }
        public DbSet<Client_Products> Client_Products { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<EmployeeMaster> EmployeeMasters { get; set; }
        public DbSet<Inbound_Shipment> Inbound_Shipment { get; set; }
        public DbSet<Inbound_Shipment_Status> Inbound_Shipment_Status { get; set; }
        public DbSet<InventoryPosition> InventoryPositions { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Outbound_Shipment> Outbound_Shipment { get; set; }
        public DbSet<Outbound_Status> Outbound_Status { get; set; }
        public DbSet<Packing_Batch> Packing_Batch { get; set; }
        public DbSet<Packing_Details> Packing_Details { get; set; }
        public DbSet<Packing_Type> Packing_Type { get; set; }
        public DbSet<Product_Number> Product_Number { get; set; }
        public DbSet<Product_Number_Analysis> Product_Number_Analysis { get; set; }
        public DbSet<Product_Number_Batch> Product_Number_Batch { get; set; }
        public DbSet<Product_Number_Batch_History> Product_Number_Batch_History { get; set; }
        public DbSet<Product_Number_Batch_Location> Product_Number_Batch_Location { get; set; }
        public DbSet<Product_Number_Batch_Status> Product_Number_Batch_Status { get; set; }
        public DbSet<Product_Number_Batch_Trans> Product_Number_Batch_Trans { get; set; }
        public DbSet<Product_Quality> Product_Quality { get; set; }
        public DbSet<Product_Status> Product_Status { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<SalesOrder_Customer> SalesOrder_Customer { get; set; }
        public DbSet<SalesOrder_Line> SalesOrder_Line { get; set; }
        public DbSet<SAMY_Client> SAMY_Client { get; set; }
        public DbSet<SAMY_Products> SAMY_Products { get; set; }
    }
}
