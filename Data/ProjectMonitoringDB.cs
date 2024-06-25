using ProjectMonitoring.Models;
using Microsoft.EntityFrameworkCore;
namespace ProjectMonitoring.Data
{
    public class ProjectMonitoringDB:DbContext
    {
        public ProjectMonitoringDB(DbContextOptions<ProjectMonitoringDB> options) : base(options) { } 

        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<IssueReport> IssueReports { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<ReportingForm> ReportingForms { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<SiteIssueForm> SiteIssueForms { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Contractor>().ToTable("Contractor");
            mb.Entity<IssueReport>().ToTable("IssueReport");
            mb.Entity<Location>().ToTable("Location");
            mb.Entity<ReportingForm>().ToTable("ReportingForm");
            mb.Entity<Project>().ToTable("Project");
            mb.Entity<SiteIssueForm>().ToTable("SiteIssueForm");

        }
       
    }
}
