using System;
using System.Collections.Generic;

namespace JobPortal.Models
{
    public partial class JobRequirment
    {
        public JobRequirment()
        {
            this.AppliedHistories = new List<AppliedHistory>();
        }

        public decimal Id { get; set; }
        public string Title { get; set; }
        public string Technology { get; set; }
        public string JobDescription { get; set; }
        public Nullable<int> Experience { get; set; }
        public string Venue { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public decimal EmployerId { get; set; }
        public virtual ICollection<AppliedHistory> AppliedHistories { get; set; }
        public virtual Employer Employer { get; set; }
    }
}
