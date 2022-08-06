namespace TheLDTS.Models
{
    public class Property
    {
        public int PropertyId { get; set; }
        public int LandlordID { get; set; }
        public virtual Landlord? Landlord { get; set; }
        public int HouseNumber { get; set; }
    }
}
