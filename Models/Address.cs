namespace Bill_o_Pro.Models
{
    public enum Addresstype
    {
        billingAddress = 0,
        shippingAddress = 1,
        postOfficeBox = 2
    }
    public class Address
    {
        public string id { get; set; }
        public string name { get; set; }
        public string street { get; set; }
        public string houseNumber { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public Addresstype addresstype { get; set; }
    }
}
