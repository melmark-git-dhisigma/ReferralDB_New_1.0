//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class ref_TeamAssign
    {
        public int TeamAssignId { get; set; }
        public Nullable<int> QueueStatusId { get; set; }
        public Nullable<bool> Complete { get; set; }
        public Nullable<int> ReferalId { get; set; }
        public Nullable<int> ProcessId { get; set; }
        public Nullable<int> TeamId { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}