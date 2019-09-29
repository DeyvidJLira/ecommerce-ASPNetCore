using ecommerce_aspnet.Models;
using Microsoft.EntityFrameworkCore;

namespace ecommerce_aspnet.Database {
    public class ECommerceContext : DbContext {

        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options) {

        }

        public DbSet<Client> Clients {get; set;}
    
    }
}