using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class EmployeeContactDetail
    {
        public decimal Id { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string PrimaryMobileNo { get; set; }
        public string SecondaryMobileNo { get; set; }
        public string PrimaryEmailId { get; set; }
        public string SecondaryEmailId { get; set; }
        public decimal EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
