using Microsoft.EntityFrameworkCore;

namespace DogParks.Models
{
    public class DogParksContext : DbContext
    {
        public DogParksContext(DbContextOptions<DogParksContext> options)
            : base(options)
        {
        }

        public DbSet<DogPark> DogParks { get; set; }
    }
}