using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobPortal.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FatherName)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Employee");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.FatherName).HasColumnName("FatherName");
            this.Property(t => t.Dob).HasColumnName("Dob");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
        }
    }
}
