using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace ProjectMonitoring.Models
{
    [Table("Project")]
    public class Project:BaseModel
    {
        [PrimaryKey("project_id",false)]
        public int ProjectId { get; set; }
        [Required]
        [Column("project_name")]
        public string ProjectName { get; set; }
        [Column("project_description")]
        public string ProjectDescription { get; set; }
        [Reference(typeof(SiteLocation))]
        public ICollection<SiteLocation> SiteLocations { get; set; }

    }
}
