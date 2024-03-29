﻿// <auto-generated />
using DogParks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BuildAnApi.Solution.Migrations
{
    [DbContext(typeof(DogParksContext))]
    partial class DogParksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DogParks.Models.DogPark", b =>
                {
                    b.Property<int>("DogParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Area");

                    b.Property<string>("Hours");

                    b.Property<string>("Name");

                    b.Property<string>("PhotoPath");

                    b.HasKey("DogParkId");

                    b.ToTable("DogParks");

                    b.HasData(
                        new
                        {
                            DogParkId = 1,
                            Address = "N Fremont Street and Interstate Avenue",
                            Area = "North",
                            Hours = "5AM-12AM",
                            Name = "Overlook Park",
                            PhotoPath = "https://www.portlandoregon.gov/parks/finder/index.cfm?action=ViewFile&PolPhotosID=250"
                        },
                        new
                        {
                            DogParkId = 2,
                            Address = "NW 19th Avenue and Glisan Street",
                            Area = "Northwest",
                            Hours = "5AM-12AM",
                            Name = "Couch Park",
                            PhotoPath = "https://www.portlandoregon.gov/parks/finder/index.cfm?action=ViewFile&PolPhotosID=76"
                        },
                        new
                        {
                            DogParkId = 3,
                            Address = "SE Cesar E Chavez Blvd and Stark Street",
                            Area = "Southeast",
                            Hours = "5AM-10:30PM",
                            Name = "Laurelhurst Park",
                            PhotoPath = "https://www.portlandoregon.gov/parks/finder/index.cfm?action=ViewFile&PolPhotosID=115"
                        },
                        new
                        {
                            DogParkId = 4,
                            Address = "SW 27th Avenue and Hillsdale Highway",
                            Area = "Southwest",
                            Hours = "5AM-12AM",
                            Name = "Hillsdale Park",
                            PhotoPath = "https://www.portlandoregon.gov/parks/finder/index.cfm?action=ViewFile&PolPhotosID=799"
                        },
                        new
                        {
                            DogParkId = 5,
                            Address = "SE 60th Avenue and Salmon Street",
                            Area = "Southeast",
                            Hours = "5AM-12AM",
                            Name = "Mt.Tabor Park",
                            PhotoPath = "https://www.portlandoregon.gov/parks/finder/index.cfm?action=ViewFile&PolPhotosID=33"
                        },
                        new
                        {
                            DogParkId = 6,
                            Address = "NE 37th Avenue and Ainsworth Street",
                            Area = "Northeast",
                            Hours = "5AM-12AM",
                            Name = "Fernhill Park",
                            PhotoPath = "https://www.portlandoregon.gov/parks/finder/index.cfm?action=ViewFile&PolPhotosID=90"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
