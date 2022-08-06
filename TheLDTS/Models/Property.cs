using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheLDTS.Models
{
    public class Property
    {
        public int PropertyId { get; set; }

        public int LandlordID { get; set; }

        public virtual Landlord? Landlord { get; set; }

        [Required]
        public int HouseNumber { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string StreetName { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string City { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 4)]
        public string Country { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Type { get; set; }

        [DataType(DataType.Currency)]
        public int Rent { get; set; }

        public bool Available { get; set; }

        [Display(Name = "Gas Safety Certificate")]
        [DataType(DataType.Date)]
        public DateTime CP12 { get; set; }

        [Display(Name = "Portable Appliance Testing")]
        [DataType(DataType.Date)]
        public DateTime PAT { get; set; }

        [Display(Name = "Electrical Installation Condition Report")]
        [DataType(DataType.Date)]
        public DateTime EICR { get; set; }

        [Display(Name = "Energy Performance Certificate")]
        [DataType(DataType.Date)]
        public DateTime EPC { get; set; }

        [Display(Name = "Legionalla Risk Assessment")]
        [DataType(DataType.Date)]
        public DateTime LegionellaTest { get; set; }

    }
}