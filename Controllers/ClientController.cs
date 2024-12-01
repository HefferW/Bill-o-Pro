using Bill_o_Pro.Data;
using Bill_o_Pro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bill_o_Pro.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var clientListFromDb = _context.Client.ToList();
            return View(clientListFromDb);
        }
        public IActionResult ShowClientDetails(string id)
        {
            if (id == null)
            {
                return View();
            }
            Guid clientId = new Guid(id);
            var dbClient = _context.Client.SingleOrDefault(x => x.Id == clientId);
            return View(dbClient);
        }
        public IActionResult CreateEditClient(Client client)
        {
            if (client == null)
            {
                return RedirectToAction("Index");
            }
            // Create new client
            //if (client.Id.ToString() == "00000000-0000-0000-0000-000000000000") //{00000000-0000-0000-0000-000000000000}
            if (client.Id == Guid.Empty)
                {
                // TODO: Check for valid client number
                client.Id = Guid.NewGuid();
                _context.Client.Add(client);
            }
            // Update existing client
            else
            {
                var dbClient = _context.Client.SingleOrDefault(x => x.Id == client.Id);
                if (dbClient == null)
                {
                    Console.WriteLine("An error occured. Can not find entry in database");
                    return NotFound();
                }

                // TODO: Add missing properties
                dbClient.Number = client.Number;
                dbClient.CompanyName = client.CompanyName;
                dbClient.Name = client.Name;
                dbClient.Phone = client.Phone;
                dbClient.Mobile = client.Mobile;
                dbClient.Email = client.Email;
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
