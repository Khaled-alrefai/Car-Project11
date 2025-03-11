using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        public DbSet<Car> Cars { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<CarAndImg> CarAndImges { get; set; }
             
        // Main Image Edite
        public DbSet<HomeImge> HomeImges { get; set; }
        // ad Edite
        public DbSet<Advertisement> Advertisements { get; set; }
    }
}
