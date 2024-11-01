namespace Bill_o_Pro.Models
{
    public class Order
    {
        public string Id { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Bom { get; set; }
    }
}
