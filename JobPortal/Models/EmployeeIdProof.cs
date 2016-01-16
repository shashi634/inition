using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class EmployeeIdProof
    {
        public decimal Id { get; set; }
        public string IdProofType { get; set; }
        public string IdProofNo { get; set; }
        public decimal EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
