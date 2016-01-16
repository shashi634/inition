using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using JobPortal.Models.Mapping;

namespace JobPortal.Models
{
    public partial class JobPortalContext : DbContext
    {
        static JobPortalContext()
        {
            Database.SetInitializer<JobPortalContext>(null);
        }

        public JobPortalContext()
            : base("Name=JobPortalContext")
        {
        }

        public DbSet<AppliedHistory> AppliedHistories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeContactDetail> EmployeeContactDetails { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }
        public DbSet<EmployeeIdProof> EmployeeIdProofs { get; set; }
        public DbSet<EmployeeWorkHistory> EmployeeWorkHistories { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<EmployerContact> EmployerContacts { get; set; }
        public DbSet<JobRequirment> JobRequirments { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppliedHistoryMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeContactDetailMap());
            modelBuilder.Configurations.Add(new EmployeeEducationMap());
            modelBuilder.Configurations.Add(new EmployeeIdProofMap());
            modelBuilder.Configurations.Add(new EmployeeWorkHistoryMap());
            modelBuilder.Configurations.Add(new EmployerMap());
            modelBuilder.Configurations.Add(new EmployerContactMap());
            modelBuilder.Configurations.Add(new JobRequirmentMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
