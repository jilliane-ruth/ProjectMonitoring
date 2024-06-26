using Supabase.Postgrest.Attributes;

namespace ProjectMonitoring.Models
{
    public class ReportingForm
    {
        public int ReportingFormId { get; set; }
        public DateTime Date { get; set; }
        
        [Reference(typeof(SiteIssueForm))]
        public SiteIssueForm SiteIssueForm {  get; set; }
    }
}
