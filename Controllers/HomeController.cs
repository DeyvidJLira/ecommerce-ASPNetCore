using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ecommerce_aspnet.Libraries.Email;
using ecommerce_aspnet.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ecommerce_aspnet.Controllers {
    public class HomeController : Controller {
        [HttpGet]
        public IActionResult Index() {
            return View();
        }
        [HttpPost]
        public IActionResult Index([FromForm] NewsletterEmail newsletter) {

            return View();
        }
        public IActionResult Contact() {
            return View();
        }
        public IActionResult ContactAction() {
            try {
                Contact contact = new Contact(HttpContext.Request.Form["name"], HttpContext.Request.Form["email"], HttpContext.Request.Form["message"]);
                
                var listMessagesValidation = new List<ValidationResult>();
                var context = new ValidationContext(contact);
                bool isValid = Validator.TryValidateObject(contact, context, listMessagesValidation, true);

                if(isValid) {
                    bool result = EmailService.SendContact(contact);
                    if(result)
                        ViewData["MSG_S"] = "Mensagem de contato enviada com sucesso!";
                    else {
                        ViewData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde! Cód. 15";
                        ViewData["CONTACT"] = contact;
                    }
                } else {
                    StringBuilder messages = new StringBuilder();
                    foreach(var message in listMessagesValidation) {
                        messages.Append(message.ErrorMessage +  "<br />");
                    }
                    ViewData["MSG_E"] = messages.ToString();
                    ViewData["CONTACT"] = contact;
                }
            } catch (Exception e) {
                ViewData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde! Cód. 05";
            }
            

            return View("Contact");
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