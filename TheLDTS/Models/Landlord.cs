namespace TheLDTS.Models
{
    public class Landlord
    {
        public int LandlordId { get; set; }
        public string FirstName { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
    }
}