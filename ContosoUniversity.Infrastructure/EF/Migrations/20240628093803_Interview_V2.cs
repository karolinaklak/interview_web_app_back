using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interview.EF.Migrations
{
    /// <inheritdoc />
    public partial class Interview_V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    IdAgent = table.Column<int>(type: "int", nullable: false),
                    IdCandidat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Quiz",
                columns: new[] { "Id", "IdAgent", "IdCandidat", "Name" },
                values: new object[] { 1, 3, 99, "Quiz1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quiz");
        }
    }
}
