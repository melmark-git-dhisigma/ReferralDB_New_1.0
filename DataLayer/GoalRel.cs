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
    
    public partial class GoalRel
    {
        public int GoalRelId { get; set; }
        public int SchoolId { get; set; }
        public int GoalId { get; set; }
        public int MappedGoalId { get; set; }
        public int GoalRelTypeId { get; set; }
        public Nullable<System.DateTime> EffStartDate { get; set; }
        public Nullable<System.DateTime> EffEndDate { get; set; }
        public string ActiveInd { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }
    }
}
