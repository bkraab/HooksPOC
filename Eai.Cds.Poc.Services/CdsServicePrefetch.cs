//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class CdsServicePrefetch
    {
        public int CdsServicePrefetchId { get; set; }
        public int CdsServiceConfigId { get; set; }
        public string resourceName { get; set; }
        public string resourceString { get; set; }
        public string sequence { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateUser { get; set; }
    
        public virtual CdsServiceConfig CdsServiceConfig { get; set; }
    }
}