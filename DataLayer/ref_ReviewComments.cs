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
    
    public partial class ref_ReviewComments
    {
        public int AcReviewId { get; set; }
        public Nullable<int> QueueStatusId { get; set; }
        public int StudentId { get; set; }
        public int SchoolId { get; set; }
        public string Comments { get; set; }
        public bool ApproveInd { get; set; }
        public string Type { get; set; }
        public string Draft { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
