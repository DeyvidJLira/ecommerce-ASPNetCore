using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ecommerce_aspnet.Libraries.Email;
using ecommerce_aspnet.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ecommerce_aspnet.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
        public IActionResult Contact() {
            return View();
        }
        public IActionResult ContactAction() {
            try {
                Contact contact = new Contact(HttpContext.Request.Form["name"], HttpContext.Request.Form["email"], HttpContext.Request.Form["message"]);
                bool result = EmailService.SendContact(contact);
                if(result)
                    ViewData["MSG_S"] = "Mensagem de contato enviada com sucesso!";
                else
                    ViewData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde! Cód. 15";
            } catch (Exception e) {
                ViewData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde! Cód. 05";
            }
            

            return View("Content");
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