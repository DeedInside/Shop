using Microsoft.AspNetCore.Mvc;
using Shop.BDContext;
using Shop.Models;

namespace Shop.Controllers
{
    public class News : Controller
    {
        public IActionResult NewsView()
        {
            return View(ApplicationContext.priceProducts);
        }
        public IActionResult AddItemProduct()
        {
            return View("AddItemProduct");
        }
        [HttpPost]
        public IActionResult AddProd(string Name, string Description, string Price) 
        {
            ApplicationContext.ListProducts.Add(
                new Product(
                    Name,
                    Convert.ToDouble(Price),
                    Description,
                    "None"
                    )
            {

            });
            return View("AddItemProduct", ApplicationContext.ListProducts);
        }
        [HttpPost]
        public IActionResult DeleteProduct(string id)
        {
                var element = ApplicationContext.ListProducts.FirstOrDefault(p => p.Name == id);
            if(element != null)
            {
                ApplicationContext.ListProducts.Remove(element);
            }

            return View("AddItemProduct", ApplicationContext.ListProducts);
        }
    }
}
