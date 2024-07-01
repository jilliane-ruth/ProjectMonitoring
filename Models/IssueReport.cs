using Supabase.Postgrest.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Supabase.Postgrest.Models;

namespace ProjectMonitoring.Models
{
    [Table("IssueReport")]
    public class IssueReport:BaseModel
    {
        [PrimaryKey("issuereport_id",false)] 
        public int IssueReportId { get; set; }
        [Column("time_stamp")]
        public DateTime TimeStamp { get; set; }
        [Column("email_address")]
        public string EmailAddress { get; set; }
        [Column("screenshot_issue")]
        public string SCofIssueReported { get; set; }
        [Column("screenshot_speedtest")]
        public string? SCofSpeedTest { get; set; }
        [Column("issue_description")]
        public string IssueDescription { get; set; }


        //Relationships
        [Column("location_id")]
        public int LocationId { get; set; }
        [Reference(typeof(SiteLocation))]
        public SiteLocation SiteLocation { get; set; }
        [Reference(typeof(SiteIssueForm))]
        public ICollection<SiteIssueForm> SiteIssueForms {get;set;}
    }
}
