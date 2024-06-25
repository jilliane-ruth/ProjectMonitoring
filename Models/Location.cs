using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace ProjectMonitoring.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public int ContractorId { get; set; }
        public int ProjectId { get; set; }
        [Required]
        [DisplayName("Location Name")]
        public string LocationName { get; set; }
        [DisplayName("Province")]
        public string Province { get; set; }
        [DisplayName("Site Type")]
        public string SiteType { get; set; }
        [DisplayName("Locality")]
        public string Locality { get; set; }
        [DisplayName("Site Coordinator Name")]
        public string SiteCoordinatorName { get; set; }
        [DisplayName("Site Coordinator Number")]
        public string SiteCoordniatorNumber { get; set; }

        public Contractor Contractor { get; set; }
        public Project Project { get; set; }
        
    }
}
