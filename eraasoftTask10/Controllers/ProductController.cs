using eraasoftTask10.Models;
using Microsoft.AspNetCore.Mvc;
using eraasoftTask10.ViewModels;

namespace eraasoftTask10.Controllers
{
    public class ProductController : Controller
    {
        private readonly BikeStores532Context _context;

        public ProductController(BikeStores532Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();

            return View(products);
        }

        public IActionResult First()
        {
            var product = _context.Products.FirstOrDefault();

            return View(product);
        }

        public IActionResult Details(int id)
        {
            var product = _context.Products
                .FirstOrDefault(p => p.ProductId == id);

            return View(product);
        }

        public IActionResult ByYear(int year)
        {
            var products = _context.Products
                .Where(p => p.ModelYear == year)
                .ToList();

            return View(products);
        }
        public IActionResult ProductsWithBrands()
        {
            var products = _context.Products
                .Select(p => new ProductBrandViewModel
                {
                    ProductName = p.ProductName,
                    BrandName = p.Brand.BrandName
                })
                .ToList();

            return View(products);
        }
        public IActionResult CountByCategory(int id)
        {
            var count = _context.Products
                .Count(p => p.CategoryId == id);

            ViewBag.CategoryId = id;
            ViewBag.ProductCount = count;

            return View();
        }
        public IActionResult TotalPriceByCategory(int id)
        {
            var total = _context.Products
                .Where(p => p.CategoryId == id)
                .Sum(p => p.ListPrice);

            ViewBag.CategoryId = id;
            ViewBag.TotalPrice = total;

            return View();
        }
        public IActionResult AveragePrice()
        {
            var average = _context.Products
                .Average(p => p.ListPrice);

            ViewBag.AveragePrice = average;

            return View();
        }
    }
}