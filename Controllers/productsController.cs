using asp.net101project.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.net101project.Controllers
{
    public class productsController : Controller
    {
        public IActionResult Index()
        {
            List<products> products1= new List<products>();
            products1.Add(new products() { Id=0,productName = "Pen", productImg= "pen.jpg",price=9}) ;
            products1.Add(new products() { Id=1, productName = "Book", productImg = "book.jpg", price = 100 });
            ViewData["product"] = products1;
            
            return View(products1);
            //return View();
        }
        public IActionResult Details(int Id)
        {
            
            products product= new products() { Id=3, productName="pencil",
            price=9
            };

            if (Id == product.Id) { ViewData["newProduct"] = product; }
            
            return View();
        }
    }
}
