using FirstProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Controllers.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
