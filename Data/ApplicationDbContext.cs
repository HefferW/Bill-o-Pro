using Bill_o_Pro.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bill_o_Pro.Models;

namespace Bill_o_Pro.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Address> Address { get; set; }
        public DbSet<BankAccount> BankAccount { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceItem> InvoiceItem { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<User> User { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
