using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class Employer
    {
        public Employer()
        {
            this.EmployerContacts = new List<EmployerContact>();
            this.JobRequirments = new List<JobRequirment>();
        }

        public decimal Id { get; set; }
        public string HrPersonName { get; set; }
        public string CompanyName { get; set; }
        public Nullable<System.Guid> CompanyId { get; set; }
        public string AboutCompany { get; set; }
        public virtual ICollection<EmployerContact> EmployerContacts { get; set; }
        public virtual ICollection<JobRequirment> JobRequirments { get; set; }
    }
}
