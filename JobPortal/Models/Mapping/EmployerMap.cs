using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace JobPortal.Models.Mapping
{
    public class EmployerMap : EntityTypeConfiguration<Employer>
    {
        public EmployerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.HrPersonName)
                .HasMaxLength(150);

            this.Property(t => t.CompanyName)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Employer");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.HrPersonName).HasColumnName("HrPersonName");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.AboutCompany).HasColumnName("AboutCompany");
        }
    }
}
