using System.Globalization;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace ProjectMonitoring.Models
{
    [Table("SiteIssueForm")]
    public class SiteIssueForm:BaseModel
    {
        [PrimaryKey("siteissueform_id",false)]
        public int SiteIssueFormId { get; set; }
        [Column("status")]
        public string Status { get; set; }
        [Column("prepared_by")]
        public string PreparedBy { get; set; }
        [Column("reviewed_by")]
        public string ReviewedBy { get; set; }
        [Column("approved_by")]
        public string ApprovedBy { get; set; }
        [Column("total_hours_downtime")]
        public int TotalHoursDownTime { get; set; }
        [Column("reported_date_time")]
        public DateTime ReportedDateTime { get; set; }
        [Column("resolved_date_time")]
        public DateTime ResolvedDateTime { get; set; }
        [Column("actions_taken_by_contractor")]
        public string ActionsTakenByContractor { get; set; }

        //Relationships
        [Column("issuereport_id")]
        public int IssueReportId { get; set; }
        [Reference(typeof(IssueReport))]
        public IssueReport IssueReport { get; set; }
        [Reference(typeof(ReportingForm))]
        public ICollection<ReportingForm> ReportingForms { get; set; }

    }
}
