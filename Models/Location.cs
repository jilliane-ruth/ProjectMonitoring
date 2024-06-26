using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace ProjectMonitoring.Models
{
    [Table("Location")]
    public class Location:BaseModel
    {
        [PrimaryKey("location_id", false)]
        [Required]
        [Column("Location Name")]
        public string LocationName { get; set; }
        [Column("Province")]
        public string Province { get; set; }
        [Column("Site Type")]
        public string SiteType { get; set; }
        [Column("Locality")]
        public string Locality { get; set; }
        [Column("Site Coordinator Name")]
        public string SiteCoordinatorName { get; set; }
        [Column("Site Coordinator Number")]
        public string SiteCoordniatorNumber { get; set; }


        //Relationships
        [Column("contractor_id")]
        public int ContractorId { get; set; }
        [Reference(typeof(Contractor))]
        public Contractor Contractor { get; set; }
        [Column("project_id")]
        public int ProjectId { get; set; }
        [Reference(typeof(Project))]
        public Project Project { get; set; }
        [Reference(typeof(IssueReport))] 
        public ICollection<IssueReport> IssueReports { get; set; }

    }
}
