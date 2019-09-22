using Microsoft.AspNetCore.Mvc;

namespace ecommerce_aspnet.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
        public IActionResult Contact() {
            return View();
        }
        public IActionResult Login() {
            return View();
        }
        public IActionResult RegisterClient() {
            return View();
        }
        public IActionResult Cart() {
            return View();
        }
    }
}