namespace Bill_o_Pro.Models
{
    public class BankAccount
    {
        public Guid Id { get; set; }
        public Client Client { get; set; }
        public string AccountHolder { get; set; }
        public string InstitutionName { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }
        public string Unit { get; set; }
    }
}
