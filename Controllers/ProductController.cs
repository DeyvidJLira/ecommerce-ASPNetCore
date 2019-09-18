using Microsoft.AspNetCore.Mvc;

namespace ecommerce_aspnet.Controllers {
    public class ProductController : Controller {
        public ActionResult Visualizar() {
            return new ContentResult() { Content = "<h3>Produto visualizar</h3>", ContentType = "text/html" };
        }
    } 
}