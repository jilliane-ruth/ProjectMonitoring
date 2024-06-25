﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace ProjectMonitoring.Models
{
    public class Contractor
    {
        public int ContractorId { get; set; }
        [Required]
        [DisplayName("Contractor Name")]
        public string ContractorName { get; set; }
        public string Description { get; set; }
        public int TelephoneNumber { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string CompanyAddress { get; set; }

        public ICollection<Location> Locations { get; set; }

    }
}
