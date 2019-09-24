namespace ecommerce_aspnet.Models {
    public class Contact {
        public Contact(string name, string email, string message) {
            this.Name = name;
            this.Email = email;
            this.Message = message;
        }
        
        public string Name {get; set;}
        public string Email { get; set; }
        public string Message { get; set; }
    }
}