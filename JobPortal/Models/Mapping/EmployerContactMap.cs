using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobPortal.Models.Mapping
{
    public class EmployerContactMap : EntityTypeConfiguration<EmployerContact>
    {
        public EmployerContactMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Address)
                .HasMaxLength(150);

            this.Property(t => t.District)
                .HasMaxLength(50);

            this.Property(t => t.State)
                .HasMaxLength(50);

            this.Property(t => t.Pincode)
                .HasMaxLength(20);

            this.Property(t => t.PrimaryPhoneNo)
                .HasMaxLength(20);

            this.Property(t => t.SecondaryPhonenNo)
                .HasMaxLength(20);

            this.Property(t => t.PrimaryEmailId)
                .HasMaxLength(100);

            this.Property(t => t.SecondaryEmailId)
                .HasMaxLength(100);

            this.Property(t => t.Website)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("EmployerContact");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.District).HasColumnName("District");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Pincode).HasColumnName("Pincode");
            this.Property(t => t.PrimaryPhoneNo).HasColumnName("PrimaryPhoneNo");
            this.Property(t => t.SecondaryPhonenNo).HasColumnName("SecondaryPhonenNo");
            this.Property(t => t.PrimaryEmailId).HasColumnName("PrimaryEmailId");
            this.Property(t => t.SecondaryEmailId).HasColumnName("SecondaryEmailId");
            this.Property(t => t.Website).HasColumnName("Website");
            this.Property(t => t.EmployerId).HasColumnName("EmployerId");

            // Relationships
            this.HasRequired(t => t.Employer)
                .WithMany(t => t.EmployerContacts)
                .HasForeignKey(d => d.EmployerId);

        }
    }
}
