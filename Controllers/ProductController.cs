using Microsoft.AspNetCore.Mvc;
using MyMvcWebApplication.Models;

namespace MyMvcWebApplication.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>() {
        new Product() { ProductId = 100, Name = "Product1", Price = 98},
        new Product() { ProductId = 200, Name = "Product2", Price = 50},
        new Product() { ProductId = 300, Name = "Product3", Price = 38},
        };
        public IActionResult Index()
        {
            return View(products);
        }
    }
}
