using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Interview.EF.Migrations
{
    /// <inheritdoc />
    public partial class Interview_V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IdLevel = table.Column<int>(type: "int", nullable: false),
                    IdTechno = table.Column<int>(type: "int", nullable: false),
                    IdAdmin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "IdAdmin", "IdLevel", "IdTechno", "Name" },
                values: new object[,]
                {
                    { 1, 0, 65, 0, "Chemistry" },
                    { 2, 0, 65, 0, "Microeconomics" },
                    { 3, 0, 66, 0, "Macroeconomics" },
                    { 4, 0, 65, 0, "Calculus" },
                    { 5, 0, 67, 0, "Trigonometry" },
                    { 6, 0, 65, 0, "Composition" },
                    { 7, 0, 67, 0, "Literature" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Role" },
                values: new object[,]
                {
                    { 1, "Carson", "Alexander", 2 },
                    { 2, "Meredith", "Alonso", 2 },
                    { 3, "Arturo", "Anand", 1 },
                    { 4, "Gytis", "Barzdukas", 3 },
                    { 5, "Yan", "Li", 2 },
                    { 6, "Peggy", "Justice", 3 },
                    { 7, "Laura", "Norman", 2 },
                    { 8, "Nino", "Olivetto", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
