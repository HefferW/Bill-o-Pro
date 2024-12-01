using Bill_o_Pro.Data;
using Bill_o_Pro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bill_o_Pro.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var customerListFromDb = _context.Customer.ToList();
            return View(customerListFromDb);
        }

        public IActionResult ShowCustomerDetails(string id)
        {
            if (id == null) 
            {
                return View();
            }
            Guid customerId = new Guid(id);
            var dbCustomer = _context.Customer.SingleOrDefault(x => x.Id == customerId);
            return View(dbCustomer);
        }

        public IActionResult CreateEditCustomer(Customer customer)
        {
            if (customer == null)
            {
                return RedirectToAction("Index");
            }
            // Create new customer
            if (customer.Id == Guid.Empty)
            {
                customer.Id = Guid.NewGuid();
                _context.Customer.Add(customer);
            }
            // Update existing customer
            else
            {
                var dbCustomer = _context.Customer.SingleOrDefault(x => x.Id == customer.Id);
                if (dbCustomer == null)
                {
                    Console.WriteLine("An error occured. Can not find entry in database");
                    return NotFound();
                }
                // TODO: Add missing properties
                dbCustomer.Number = customer.Number;
                dbCustomer.CompanyName = customer.CompanyName;
                dbCustomer.Name = customer.Name;
                dbCustomer.TaxId = customer.TaxId;
                dbCustomer.TaxAuthority = customer.TaxAuthority;
                dbCustomer.Phone = customer.Phone;
                dbCustomer.Mobile = customer.Mobile;
                dbCustomer.Email = customer.Email;
            }
                _context.SaveChanges();
                return RedirectToAction("Index");
        }
    }
}
