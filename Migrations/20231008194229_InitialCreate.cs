using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FishBuddy.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FishList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FishName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperienceLevel = table.Column<int>(type: "int", nullable: true),
                    MaxLength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BestSeason = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishList", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "FishList",
                columns: new[] { "ID", "BestSeason", "ExperienceLevel", "FishName", "Location", "MaxLength", "MaxWeight" },
                values: new object[] { 1, null, null, "Largemouth Bass", "Lakes, Rivers, & Ponds", "27 Inches", "11.94 Pounds" });

            migrationBuilder.InsertData(
                table: "FishList",
                columns: new[] { "ID", "BestSeason", "ExperienceLevel", "FishName", "Location", "MaxLength", "MaxWeight" },
                values: new object[] { 2, null, null, "Northern Pike", "Lakes, Rivers, & Ponds", "51.5 Inches", "39 Pounds" });

            migrationBuilder.InsertData(
                table: "FishList",
                columns: new[] { "ID", "BestSeason", "ExperienceLevel", "FishName", "Location", "MaxLength", "MaxWeight" },
                values: new object[] { 3, null, null, "Walleye", "Lakes, Rivers, & Ponds", "35 Inches", "17.19 Pounds" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FishList");
        }
    }
}
