using eraasoftTask10.Models;
using Microsoft.AspNetCore.Mvc;

namespace eraasoftTask10.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BikeStores532Context _context;

        public CategoryController(BikeStores532Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();

            return View(categories);
        }
    }
}