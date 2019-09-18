using ecommerce_aspnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_aspnet.Controllers {
    public class ProductController : Controller {
        public ActionResult Detail() {
            Product product = GetProduct();

            return View(product);
            //return new ContentResult() { Content = "<h3>Produto visualizar</h3>", ContentType = "text/html" };
        }


        private Product GetProduct() {
            return new Product() {
                Id  = 1,
                Name = "Xbox one X",
                Description = "Jogue em 4k",
                Value = 2000.00M
            };
        }
    } 
}