using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using e_commerce_DEMO.Models.Product;

namespace e_commerce_DEMO.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowAll()
        {
            ViewData["Heading"] = "Tüm ürünler";
            var products = new List<Product>();
            products.Add(new Product { ID = 101, Name = "Apple", Price = 1.1 });
            products.Add(new Product { ID = 202, Name = "Bike", Price = 2.2 });
            products.Add(new Product { ID = 303, Name = "Calculator", Price = 3.3 });

            products.Add(new Product { ID = 122, Name = "Çaklıt", Price = 4.4 });
            return View(products);
        }
    }
}
