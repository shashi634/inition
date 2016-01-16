using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class EmployeeWorkHistory
    {
        public decimal Id { get; set; }
        public string Company { get; set; }
        public string Role { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> CompanyRating { get; set; }
        public string Comment { get; set; }
        public Nullable<decimal> EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
