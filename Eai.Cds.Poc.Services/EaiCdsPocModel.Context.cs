﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eai.Cds.Poc.Services
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EaiDBEntities : DbContext
    {
        public EaiDBEntities()
            : base("name=EaiDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CdsServiceConfig> CdsServiceConfig { get; set; }
        public virtual DbSet<CdsServicePrefetch> CdsServicePrefetch { get; set; }
        public virtual DbSet<Insight> Insight { get; set; }
        public virtual DbSet<InsightLink> InsightLink { get; set; }
        public virtual DbSet<VV_InsightLink> VV_InsightLink { get; set; }
    }
}
