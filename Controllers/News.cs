using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.BDContext;
using Shop.Models;

namespace Shop.Controllers
{
    public class News : Controller
    {
        ApplicationContext _context;
        public News(ApplicationContext context) 
        {
            _context = context;
        }
        public async Task<IActionResult> NewsView()
        {
            var value = await _context.PriceProducts.ToListAsync();

            return View( value);
        }
        public async Task<IActionResult> AddItemProduct()
        {
            List<Product> products = await _context.Products.ToListAsync();
            ViewBag.Prod = products;
            return View("AddItemProduct");
        }
        [HttpPost]
        public async Task<IActionResult> AddProd(string Name, string Description, string Price) 
        {
             _context.Products.Add(new Product(
                    Name,
                    Convert.ToDouble(Price),
                    Description,
                    "None"
                    ));
            await _context.SaveChangesAsync();

            return RedirectToAction("AddItemProduct");
        }
        [HttpPost]
        public IActionResult DeleteProduct(string id)
        {
            var element = _context.Products.FirstOrDefault(p => p.Name == id);
            if(element != null)
            {
                _context.Products.Remove(element);
                _context.SaveChanges();
            }

            return RedirectToAction("AddItemProduct");
        }
    }
}
