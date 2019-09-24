using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ecommerce_aspnet.Models;
using Newtonsoft.Json;

namespace ecommerce_aspnet.Libraries.Email {
    public class EmailService {
        public static bool SendContact(Contact contact) {
            StringContent content = new StringContent(JsonConvert.SerializeObject(contact), Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient(); 

            System.Net.Http.HttpResponseMessage response = client.PostAsync("https://us-central1-deyvidjlira-personal.cloudfunctions.net/api/mail/formContact", content).Result;
            if(response.StatusCode == System.Net.HttpStatusCode.OK) {
                return true;
            } else {
                return false;
            }
        }
    }
}