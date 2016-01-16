using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobPortal.Models.Mapping
{
    public class AppliedHistoryMap : EntityTypeConfiguration<AppliedHistory>
    {
        public AppliedHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("AppliedHistory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.JobId).HasColumnName("JobId");
            this.Property(t => t.AppliedDate).HasColumnName("AppliedDate");

            // Relationships
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.AppliedHistories)
                .HasForeignKey(d => d.EmployeeId);
            this.HasRequired(t => t.JobRequirment)
                .WithMany(t => t.AppliedHistories)
                .HasForeignKey(d => d.JobId);

        }
    }
}
