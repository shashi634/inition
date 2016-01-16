using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class AppliedHistory
    {
        public decimal Id { get; set; }
        public decimal EmployeeId { get; set; }
        public decimal JobId { get; set; }
        public System.DateTime AppliedDate { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual JobRequirment JobRequirment { get; set; }
    }
}
