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
    
    public partial class DSTempSetColCalc
    {
        public int DSTempSetColCalcId { get; set; }
        public int SchoolId { get; set; }
        public int DSTempSetColId { get; set; }
        public string CalcType { get; set; }
        public string CalcLabel { get; set; }
        public string CalcFormula { get; set; }
        public string CalcRptLabel { get; set; }
        public Nullable<int> MaxLen { get; set; }
        public Nullable<int> MaxVal { get; set; }
        public Nullable<int> MinVal { get; set; }
        public string ValText { get; set; }
        public string ActiveInd { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> CalcuType { get; set; }
        public Nullable<bool> IncludeInGraph { get; set; }
    }
}
