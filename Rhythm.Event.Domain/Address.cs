namespace Rhythm.Event.Domain
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Unit { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string  State { get; set; }
        public int PinCode { get; set; }
        public string Country { get; set; }
    }
}