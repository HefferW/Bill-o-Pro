﻿namespace Bill_o_Pro.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string TaxId { get; set; }
        public string TaxAuthority { get; set; }
        public List<BankAccount> BankAccount { get; set; }
        public List<Address> Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public List<User> User { get; set; }
    }
}
