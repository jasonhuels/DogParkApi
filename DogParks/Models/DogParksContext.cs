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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DogPark>().HasData(
                new DogPark
                {
                    DogParkId = 1,
                    Name = "Overlook Park",
                    Area = "North",
                    Address = "N Fremont Street and Interstate Avenue",
                    Hours = "5AM-12AM",
                    PhotoPath = "https://www.portlandoregon.gov/parks/finder/index.cfm?action=ViewFile&PolPhotosID=250"
                },
                new DogPark
                {
                    DogParkId = 2,
                    Name = "Couch Park",
                    Area = "Northwest",
                    Address = "NW 19th Avenue and Glisan Street",
                    Hours = "5AM-12AM",
                    PhotoPath = "https://www.portlandoregon.gov/parks/finder/index.cfm?action=ViewFile&PolPhotosID=76"
                },
                new DogPark
                {
                    DogParkId = 3,
                    Name = "Laurelhurst Park",
                    Area = "Southeast",
                    Address = "SE Cesar E Chavez Blvd and Stark Street",
                    Hours = "5AM-10:30PM",
                    PhotoPath = "https://www.portlandoregon.gov/parks/finder/index.cfm?action=ViewFile&PolPhotosID=115"
                },
                new DogPark
                {
                    DogParkId = 4,
                    Name = "Hillsdale Park",
                    Area = "Southwest",
                    Address = "SW 27th Avenue and Hillsdale Highway",
                    Hours = "5AM-12AM",
                    PhotoPath = "https://www.portlandoregon.gov/parks/finder/index.cfm?action=ViewFile&PolPhotosID=799"
                }
            );
        }
    }
}