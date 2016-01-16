using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobPortal.Models.Mapping
{
    public class EmployeeContactDetailMap : EntityTypeConfiguration<EmployeeContactDetail>
    {
        public EmployeeContactDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Address)
                .HasMaxLength(300);

            this.Property(t => t.District)
                .HasMaxLength(100);

            this.Property(t => t.State)
                .HasMaxLength(50);

            this.Property(t => t.Pincode)
                .HasMaxLength(50);

            this.Property(t => t.PrimaryMobileNo)
                .HasMaxLength(20);

            this.Property(t => t.SecondaryMobileNo)
                .HasMaxLength(20);

            this.Property(t => t.PrimaryEmailId)
                .HasMaxLength(250);

            this.Property(t => t.SecondaryEmailId)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("EmployeeContactDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.District).HasColumnName("District");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Pincode).HasColumnName("Pincode");
            this.Property(t => t.PrimaryMobileNo).HasColumnName("PrimaryMobileNo");
            this.Property(t => t.SecondaryMobileNo).HasColumnName("SecondaryMobileNo");
            this.Property(t => t.PrimaryEmailId).HasColumnName("PrimaryEmailId");
            this.Property(t => t.SecondaryEmailId).HasColumnName("SecondaryEmailId");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");

            // Relationships
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.EmployeeContactDetails)
                .HasForeignKey(d => d.EmployeeId);

        }
    }
}
