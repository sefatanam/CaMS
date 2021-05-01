using CaMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CaMS.Context
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}