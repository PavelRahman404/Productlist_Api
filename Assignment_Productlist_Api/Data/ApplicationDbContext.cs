using Microsoft.EntityFrameworkCore;
using Assignment_Productlist_Api.Models;

namespace Assignment_Productlist_Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        

        public DbSet<Product> Products { get; set; }
        
    }

}
