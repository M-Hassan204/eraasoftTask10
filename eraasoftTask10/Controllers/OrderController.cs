using eraasoftTask10.Models;
using Microsoft.AspNetCore.Mvc;

namespace eraasoftTask10.Controllers
{
    public class OrderController : Controller
    {
        private readonly BikeStores532Context _context;

        public OrderController(BikeStores532Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Status()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Status(byte status)
        {
            var orders = _context.Orders
                .Where(o => o.OrderStatus == status)
                .ToList();

            ViewBag.Status = status;

            return View(orders);
        }
    }
}