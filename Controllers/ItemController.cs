using Bill_o_Pro.Data;
using Bill_o_Pro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bill_o_Pro.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var itemListFromDb = _context.Item.ToList();
            return View(itemListFromDb);
        }

        public IActionResult ShowItemDetails(string id)
        {
            if (id == null)
            {
                return View();
            }
            Guid itemId = new Guid(id);
            var dbItem = _context.Item.SingleOrDefault(x => x.Id == itemId);
            return View(dbItem);
        }

        public IActionResult CreateEditItem(Item item)
        {
            if (item == null)
            {
                item.Id = Guid.NewGuid();
                _context.Item.Add(item);
            }
            else
            {
                var dbItem = _context.Item.SingleOrDefault(x => x.Id == item.Id);
                if (dbItem == null)
                {
                    Console.WriteLine("An error occured. Can not find entry in database");
                    return NotFound();
                }

                dbItem.Name = item.Name;
                dbItem.Description = item.Description;
                dbItem.Unit = item.Unit;
                dbItem.Price = item.Price;
                dbItem.Tax = item.Tax;
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
