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
    
    public partial class Insight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Insight()
        {
            this.InsightLink = new HashSet<InsightLink>();
        }
    
        public int InsightId { get; set; }
        public string MemberMessageHeadline { get; set; }
        public string MemberMessage { get; set; }
        public string ProviderMessageheadline { get; set; }
        public string ProviderMessage { get; set; }
        public string MessageType { get; set; }
        public int Sensitiveind { get; set; }
        public string RuleNameFriendly { get; set; }
        public string RuleName { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateUser { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InsightLink> InsightLink { get; set; }
    }
}
