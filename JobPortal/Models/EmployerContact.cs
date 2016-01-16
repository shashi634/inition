using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class EmployerContact
    {
        public decimal Id { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string PrimaryPhoneNo { get; set; }
        public string SecondaryPhonenNo { get; set; }
        public string PrimaryEmailId { get; set; }
        public string SecondaryEmailId { get; set; }
        public string Website { get; set; }
        public decimal EmployerId { get; set; }
        public virtual Employer Employer { get; set; }
    }
}
