﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAH
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RonPentaEntities : DbContext
    {
        public RonPentaEntities()
            : base("name=RonPentaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Emblem_Order_Information> Emblem_Order_Information { get; set; }
        public virtual DbSet<tblCustomer> tblCustomers { get; set; }
        public virtual DbSet<tblNPI_Emblem_Order> tblNPI_Emblem_Orders { get; set; }
        public virtual DbSet<tblNPI_Emblem_Orders_Backup> tblNPI_Emblem_Orders_Backups { get; set; }
    }
}