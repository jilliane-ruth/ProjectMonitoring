namespace ProjectMonitoring.Models
{
    public class IssueReport
    {
        public int IssueReportId { get; set; }
        public int LocationId { get; set; }
        public int ContractorId { get; set; }
        public DateTime DateTimeReported { get; set; }
        public string EmailAddress { get; set; }
        public string SCofIssueReported { get; set; }
        public string? SCofSpeedTest { get; set; }
        public string IssueDescription { get; set; }
        public DateTime TimeOfIssueReported { get; set; }
        public string SiteCoordinator { get; set; }
        public int SiteCoordinatorNumber { get; set; }

        public Location Location { get; set; }
        public Contractor Contractor { get; set; }

        public ICollection<SiteIssueForm> SiteIssueForms {get;set;}
    }
}
