namespace Bill_o_Pro.Models
{
    public enum AddressType
    {
        billingAddress = 0,
        shippingAddress = 1,
        postOfficeBox = 2
    }
    public class Address
    {
        public Guid Id { get; set; }
        public Client Client { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public AddressType AddressType { get; set; }
    }
}
