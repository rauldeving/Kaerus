using Microsoft.EntityFrameworkCore;
using Kaerus.Models;


namespace Kaerus.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> MyProperty {  get; set; }

    }
}
