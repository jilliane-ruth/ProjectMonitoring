using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace ProjectMonitoring.Models
{
    [Table("Location")]
    public class SiteLocation:BaseModel
    {
        [PrimaryKey("location_id", false)]
        public int LocationId { get; set; }
        [Required]
        [Column("location_name")]
        public string LocationName { get; set; }
        [Column("province")]
        public string Province { get; set; }
        [Column("site_type")]
        public string SiteType { get; set; }
        [Column("locality")]
        public string Locality { get; set; }
        [Column("site_coordinator_name")]
        public string SiteCoordinatorName { get; set; }
        [Column("site_coordinator_number")]
        public string SiteCoordinatorNumber { get; set; }


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
