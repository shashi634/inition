using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class Employee
    {
        public Employee()
        {
            this.AppliedHistories = new List<AppliedHistory>();
            this.EmployeeContactDetails = new List<EmployeeContactDetail>();
            this.EmployeeEducations = new List<EmployeeEducation>();
            this.EmployeeIdProofs = new List<EmployeeIdProof>();
            this.EmployeeWorkHistories = new List<EmployeeWorkHistory>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public System.DateTime Dob { get; set; }
        public bool Gender { get; set; }
        public System.Guid EmployeeId { get; set; }
        public virtual ICollection<AppliedHistory> AppliedHistories { get; set; }
        public virtual ICollection<EmployeeContactDetail> EmployeeContactDetails { get; set; }
        public virtual ICollection<EmployeeEducation> EmployeeEducations { get; set; }
        public virtual ICollection<EmployeeIdProof> EmployeeIdProofs { get; set; }
        public virtual ICollection<EmployeeWorkHistory> EmployeeWorkHistories { get; set; }
    }
}
