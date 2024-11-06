namespace Bill_o_Pro.Models
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public DateOnly Date { get; set; }
        public DateOnly DeliveryDate { get; set; }
        public DateOnly payDate { get; set; }
        public List<InvoiceItem> Bom { get; set; }
        public string Number { get; set; }
        public int Tax { get; set; }
        public string Email { get; set; }
        public float Total { get; set; }
        public List<Order> Order { get; set; }
    }
}
