using Bill_o_Pro.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bill_o_Pro.Models;

namespace Bill_o_Pro.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Mandatee> Mandatees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
