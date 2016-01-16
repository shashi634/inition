using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class EmployeeEducation
    {
        public decimal Id { get; set; }
        public string Degree { get; set; }
        public string College { get; set; }
        public string Specialization { get; set; }
        public Nullable<int> PassingYear { get; set; }
        public Nullable<int> Percentage { get; set; }
        public decimal EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
