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
    
    public partial class StdtStatu
    {
        public int StdtStatusId { get; set; }
        public int StudentId { get; set; }
        public Nullable<int> StdtIEPId { get; set; }
        public Nullable<int> AsmntYearId { get; set; }
        public Nullable<bool> ChooseAssess { get; set; }
        public Nullable<bool> ScoreAssesss { get; set; }
        public Nullable<bool> GenerateIEP { get; set; }
        public Nullable<bool> CompleteIEP { get; set; }
        public Nullable<bool> SubmitOrApprove { get; set; }
        public Nullable<bool> NewLP { get; set; }
        public Nullable<bool> CustomizeLP { get; set; }
        public Nullable<bool> AllLPApprove { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
