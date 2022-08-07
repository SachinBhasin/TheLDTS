using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TheLDTS.Models
{
    public class Landlord
    {
        public int LandlordId { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        public string Password { get; set; }

        public virtual ICollection<Property>? Properties { get; set; }
    }
}

#nullable enable
