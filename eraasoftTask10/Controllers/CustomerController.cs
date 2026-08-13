using eraasoftTask10.Models;
using Microsoft.AspNetCore.Mvc;

namespace eraasoftTask10.Controllers
{
    public class CustomerController : Controller
    {
        private readonly BikeStores532Context _context;

        public CustomerController(BikeStores532Context context)
        {
            _context = context;
        }

        public IActionResult Details(int id)
        {
            var customer = _context.Customers
                .FirstOrDefault(c => c.CustomerId == id);

            return View(customer);
        }
    }
}