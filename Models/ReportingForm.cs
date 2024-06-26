using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace ProjectMonitoring.Models
{
    [Table("ReportingForm")]
    public class ReportingForm:BaseModel
    {
        [PrimaryKey("reportingform_id",false)]
        public int ReportingFormId { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }

        //Relationships
        [Column("siteissueform_id")]
        public int SiteIssueFormId { get; set; }

        [Reference(typeof(SiteIssueForm))]
        public SiteIssueForm SiteIssueForm {  get; set; }
    }
}
