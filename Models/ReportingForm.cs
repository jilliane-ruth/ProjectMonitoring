namespace ProjectMonitoring.Models
{
    public class ReportingForm
    {
        public int MontoringReportId { get; set; }
        public DateTime Date { get; set; }
        public string LocationName { get; set; }
        public string Issue { get; set; }
        public string ActionsTakenByContractor { get; set; }
        public int TotalHourseDowntime { get; set; }

        public ICollection<SiteIssueForm> SiteIssueForms {  get; set; }
    }
}
