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
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter letters only!")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter letters only!")]
        public string LastName { get; set; }

        [StringLength(40)]
        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address!")]
        public string Email { get; set; }

        [StringLength(11, MinimumLength = 11)]
        public string PhoneNumber { get; set; }

        [Required]
        public string Password { get; set; }

        public virtual ICollection<Property>? Properties { get; set; }
    }
}

#nullable enable
