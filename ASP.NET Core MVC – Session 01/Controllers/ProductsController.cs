using ASP.NET_Core_MVC___Session_01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System.Xml.Linq;

namespace ASP.NET_Core_MVC___Session_01.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product {Id=1,Name="Laptop",Price=154},
                new Product {Id=2,Name="IPhone",Price=142},
                new Product {Id=3,Name="Keyboard",Price=200}
            };

            return View(products);
        }

        public IActionResult Details(int id)
        {
            Product product = null;
            if (id == 1)
            {
                product = new Product()
                {
                    Id = 1, Name = "Lap", Price = 115
                };
            } else if (id == 2) {
                product = new Product()
                {
                    Id = 2,
                    Name = "Tap",
                    Price = 115
                };
            }
            else return NotFound();


                return View(product);
            } 
        public IActionResult GetProduct()
        {
            var product = new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 25000
            };

            return Json(product);
        }
        public IActionResult GetMessage()
        {

            return Content("Welcome to Products Page!");
        }

        public IActionResult NotFoundTest()
        {
            return NotFound();
        }

        //[NonAction]
        public IActionResult RedirectTest()
        {
            return RedirectToAction("Index");
        }




    }
}
