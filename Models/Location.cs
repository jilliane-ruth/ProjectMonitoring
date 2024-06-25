using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace ProjectMonitoring.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public int ContractorId { get; set; }
        [Required]
        [DisplayName("Location Name")]
        public string LocationName { get; set; }
        [DisplayName("Province")]
        public string Province { get; set; }
        [DisplayName("Site Type")]
        public string SiteType { get; set; }
        [DisplayName("Site Type")]
        public string Locality { get; set; }
        [DisplayName("Locality")]
        public string SiteCoordniatorName { get; set; }
        [DisplayName("Site Coordinator Name")]
        public string SiteCoordniatorNumber { get; set; }

        public Contractor Contractor { get; set; }
        public Project Project { get; set; }
        
    }
}
