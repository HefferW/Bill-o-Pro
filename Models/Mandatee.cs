namespace Bill_o_Pro.Models
{
    public class Mandatee
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string TaxId { get; set; }
        public string TaxAuthority { get; set; }
        public List<BankAccount> BankAccounts { get; set; }
        public List<Address> Addresses { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }
}
