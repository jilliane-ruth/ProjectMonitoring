namespace ProjectMonitoring.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string ContractorName { get; set; }
        public string Province { get; set; }
        public string SiteType { get; set; }
        public string Locality { get; set; }
        public string SiteCoordniatorName { get; set; }
        public string SiteCoordniatorNumber { get; set; }

        public Contractor Contractor { get; set; }
        public Project Project { get; set; }
        
    }
}
