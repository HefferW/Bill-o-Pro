namespace Bill_o_Pro.Models
{
    public class InvoiceItem
    {
        public string Id { get; set; }
        public Invoice Invoice { get; set; }
        public Item Item { get; set; }
        public float Quantity { get; set; }
    }
}
