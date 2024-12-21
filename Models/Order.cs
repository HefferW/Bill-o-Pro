namespace Bill_o_Pro.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Client? Client { get; set; }
        public User? User { get; set; }
        public Customer? Customer { get; set; }
        public List<OrderItem>? Bom { get; set; }
        public DateTime Date { get; set; }
    }
}
