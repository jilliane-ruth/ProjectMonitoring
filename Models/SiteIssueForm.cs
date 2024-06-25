namespace ProjectMonitoring.Models
{
    public class SiteIssueForm
    {
        public int SiteIssueFormId { get; set; }
        public int IssueReportId { get; set; }
        public int ReportingFormId { get; set; }

        public string Status { get; set; }
        public string Remarks { get; set; }
        public string PreparedBy { get; set; }
        public string ReviewedBy { get; set; }
        public string ApprovedBy { get; set; }
        public int TotalHourseDowntime {get;set;}
        
        public string ActionsTakenByContractor { get; set; }
        public DateTime DateTimeResolved { get; set; }

        //Issue Report
        public DateTime DateTimeReported { get; set; }
        public string SCofIssueReported { get; set; }
        public string? SCofSpeedTest { get; set; }
        public string IssueDescription { get; set; }
        public string EmailAddress {get;set;}
        public string ContractorName { get; set; }
        public string LocationName { get; set; }
        public string SiteType { get; set; }
        public string Province { get; set; }


        //Relationships
        public IssueReport IssueReport { get; set; }
        public ReportingForm ReportingForm { get; set; }

    }
}
