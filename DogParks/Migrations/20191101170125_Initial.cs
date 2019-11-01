using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuildAnApi.Solution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DogParks",
                columns: table => new
                {
                    DogParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Hours = table.Column<string>(nullable: true),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogParks", x => x.DogParkId);
                });

            migrationBuilder.InsertData(
                table: "DogParks",
                columns: new[] { "DogParkId", "Address", "Area", "Hours", "Name", "PhotoPath" },
                values: new object[,]
                {
                    { 1, "N Fremont Street and Interstate Avenue", "North", "5AM-12AM", "Overlook Park", "https://www.portlandoregon.gov/parks/finder/index.cfm?action=ViewFile&PolPhotosID=250" },
                    { 2, "NW 19th Avenue and Glisan Street", "Northwest", "5AM-12AM", "Couch Park", "https://www.portlandoregon.gov/parks/finder/index.cfm?action=ViewFile&PolPhotosID=76" },
                    { 3, "SE Cesar E Chavez Blvd and Stark Street", "Southeast", "5AM-10:30PM", "Laurelhurst Park", "https://www.portlandoregon.gov/parks/finder/index.cfm?action=ViewFile&PolPhotosID=115" },
                    { 4, "SW 27th Avenue and Hillsdale Highway", "Southwest", "5AM-12AM", "Hillsdale Park", "https://www.portlandoregon.gov/parks/finder/index.cfm?action=ViewFile&PolPhotosID=799" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogParks");
        }
    }
}
