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
    
    public partial class School
    {
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolDesc { get; set; }
        public Nullable<int> AddressId { get; set; }
        public string DistrictName { get; set; }
        public Nullable<int> DistAddrId { get; set; }
        public string DistContact { get; set; }
        public string DistPhone { get; set; }
        public string ActiveInd { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    }
}
