using Bill_o_Pro.Data;
using Bill_o_Pro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bill_o_Pro.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var userListFromDb = _context.Users.ToList();
            return View(userListFromDb);
        }

        public IActionResult ShowUserDetails(string id)
        {
            return View();
        }
        public IActionResult CreateEditUser(User user)
        {
            return RedirectToAction("Index");
        }
    }
}
