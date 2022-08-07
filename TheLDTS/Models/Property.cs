using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TheLDTS.Models
{
    public class Property
    {
        public int PropertyId { get; set; }

        public int LandlordID { get; set; }

        public virtual Landlord? Landlord { get; set; }

        [Display(Name = "House Number")]
        public int HouseNumber { get; set; }

        [Display(Name = "Street Name")]
        public string StreetName { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Type { get; set; }

        [Display(Name = "Rent per month")]
        [DataType(DataType.Currency)]
        public int Rent { get; set; }

        [Display(Name = "Available?")]
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

        [Display(Name = "Legionella Risk Assessment")]
        [DataType(DataType.Date)]
        public DateTime LegionellaTest { get; set; }
    }
}

#nullable enable
