using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobPortal.Models.Mapping
{
    public class EmployeeEducationMap : EntityTypeConfiguration<EmployeeEducation>
    {
        public EmployeeEducationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Degree)
                .HasMaxLength(100);

            this.Property(t => t.College)
                .HasMaxLength(200);

            this.Property(t => t.Specialization)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("EmployeeEducation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Degree).HasColumnName("Degree");
            this.Property(t => t.College).HasColumnName("College");
            this.Property(t => t.Specialization).HasColumnName("Specialization");
            this.Property(t => t.PassingYear).HasColumnName("PassingYear");
            this.Property(t => t.Percentage).HasColumnName("Percentage");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");

            // Relationships
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.EmployeeEducations)
                .HasForeignKey(d => d.EmployeeId);

        }
    }
}
