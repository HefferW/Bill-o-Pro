namespace Bill_o_Pro.Models
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public Client? Client { get; set; }
        public Invoice? Invoice { get; set; }
        public Item? Item { get; set; }
        public int Quantity { get; set; }
        public float Cycle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
