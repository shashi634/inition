using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobPortal.Models.Mapping
{
    public class JobRequirmentMap : EntityTypeConfiguration<JobRequirment>
    {
        public JobRequirmentMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(250);

            this.Property(t => t.Technology)
                .HasMaxLength(550);

            this.Property(t => t.Venue)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("JobRequirment");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Technology).HasColumnName("Technology");
            this.Property(t => t.JobDescription).HasColumnName("JobDescription");
            this.Property(t => t.Experience).HasColumnName("Experience");
            this.Property(t => t.Venue).HasColumnName("Venue");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.EmployerId).HasColumnName("EmployerId");

            // Relationships
            this.HasRequired(t => t.Employer)
                .WithMany(t => t.JobRequirments)
                .HasForeignKey(d => d.EmployerId);

        }
    }
}
