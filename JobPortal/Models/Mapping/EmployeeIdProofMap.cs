using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobPortal.Models.Mapping
{
    public class EmployeeIdProofMap : EntityTypeConfiguration<EmployeeIdProof>
    {
        public EmployeeIdProofMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.IdProofType)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.IdProofNo)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("EmployeeIdProof");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IdProofType).HasColumnName("IdProofType");
            this.Property(t => t.IdProofNo).HasColumnName("IdProofNo");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");

            // Relationships
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.EmployeeIdProofs)
                .HasForeignKey(d => d.EmployeeId);

        }
    }
}
