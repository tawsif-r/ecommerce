using Microsoft.EntityFrameworkCore;
using ecommerce.Models;

namespace ecommerce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        // public DbSet<Person> Persons { get; set; }
        // public DbSet<Office> Offices { get; set; }
        
    }
}