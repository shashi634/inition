using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobPortal.Models.Mapping
{
    public class EmployeeWorkHistoryMap : EntityTypeConfiguration<EmployeeWorkHistory>
    {
        public EmployeeWorkHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Company)
                .HasMaxLength(250);

            this.Property(t => t.Role)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("EmployeeWorkHistory");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Role).HasColumnName("Role");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.CompanyRating).HasColumnName("CompanyRating");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");

            // Relationships
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.EmployeeWorkHistories)
                .HasForeignKey(d => d.EmployeeId);

        }
    }
}
