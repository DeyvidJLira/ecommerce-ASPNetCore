using System.ComponentModel.DataAnnotations;

namespace ecommerce_aspnet.Models {
    public class Contact {
        public Contact(string name, string email, string message) {
            this.Name = name;
            this.Email = email;
            this.Message = message;
        }
        
        [Required]
        [MinLength(4)]
        [MaxLength(30)]
        public string Name {get; set;}

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(10)]
        public string Message { get; set; }
    }
}