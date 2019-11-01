using Microsoft.EntityFrameworkCore.Migrations;

namespace BuildAnApi.Solution.Migrations
{
    public partial class addSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DogParks",
                columns: new[] { "DogParkId", "Address", "Area", "Hours", "Name", "PhotoPath" },
                values: new object[] { 5, "SE 60th Avenue and Salmon Street", "Southeast", "5AM-12AM", "Mt.Tabor Park", "https://www.portlandoregon.gov/parks/finder/index.cfm?action=ViewFile&PolPhotosID=33" });

            migrationBuilder.InsertData(
                table: "DogParks",
                columns: new[] { "DogParkId", "Address", "Area", "Hours", "Name", "PhotoPath" },
                values: new object[] { 6, "NE 37th Avenue and Ainsworth Street", "Northeast", "5AM-12AM", "Fernhill Park", "https://www.portlandoregon.gov/parks/finder/index.cfm?action=ViewFile&PolPhotosID=90" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogParks",
                keyColumn: "DogParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DogParks",
                keyColumn: "DogParkId",
                keyValue: 6);
        }
    }
}
