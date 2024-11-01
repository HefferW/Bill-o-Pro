namespace Bill_o_Pro.Models
{
    public class Mandatee
    {
        public string id { get; set; }
        public string companyName { get; set; }
        public string name { get; set; }
        public string taxId { get; set; }
        public string taxAuthority { get; set; }
        public List<BankAccount> bankAccounts { get; set; }
        public List<Address> addresses { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
    }
}
