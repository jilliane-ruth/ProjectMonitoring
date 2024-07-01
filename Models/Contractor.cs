using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace ProjectMonitoring.Models
{
    [Table("Contractor")]
    public class Contractor: BaseModel
    {
        [PrimaryKey("contractor_id", false)]
        public int ContractorId { get; set; }
        [Required]
        [DisplayName("Contractor Name")]
        [Column("contractor_name")]
        public string ContractorName { get; set; }
        [Column("contractor_description")]
        public string Description { get; set; }
        public int TelephoneNumber { get; set; }
        [Column("contact_number")]
        public int ContactNumber { get; set; }
        [Column("email_address")]
        public string EmailAddress { get; set; }
        [Column("company_address")]
        public string CompanyAddress { get; set; }

        [Reference(typeof(SiteLocation))]
        public ICollection<SiteLocation> Locations { get; set; }

    }
}
