using System.ComponentModel.DataAnnotations;

namespace ecommerce_aspnet.Models {
    public class Contact {
        public Contact(string name, string email, string message) {
            this.Name = name;
            this.Email = email;
            this.Message = message;
        }
        
        [Required(ErrorMessageResourceType = typeof(ecommerce_aspnet.Libraries.Lang.Messages), ErrorMessageResourceName="MSG_E001")]
        [MinLength(4, ErrorMessageResourceType = typeof(ecommerce_aspnet.Libraries.Lang.Messages), ErrorMessageResourceName="MSG_E002")]
        [MaxLength(30)]
        public string Name {get; set;}

        [Required(ErrorMessageResourceType = typeof(ecommerce_aspnet.Libraries.Lang.Messages), ErrorMessageResourceName="MSG_E001")]
        [EmailAddress(ErrorMessageResourceType = typeof(ecommerce_aspnet.Libraries.Lang.Messages), ErrorMessageResourceName="MSG_E004")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(ecommerce_aspnet.Libraries.Lang.Messages), ErrorMessageResourceName="MSG_E001")]
        [MinLength(6, ErrorMessageResourceType = typeof(ecommerce_aspnet.Libraries.Lang.Messages), ErrorMessageResourceName="MSG_E002")]
        [MaxLength(10, ErrorMessageResourceType = typeof(ecommerce_aspnet.Libraries.Lang.Messages), ErrorMessageResourceName="MSG_E003")]
        public string Message { get; set; }
    }
}