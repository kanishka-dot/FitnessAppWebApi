using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessAppWebApi.Migrations
{
    /// <inheritdoc />
    public partial class IntialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Totcalories = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Totcarbs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Totprotien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Totfat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => new { x.UserID, x.Date });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meals");
        }
    }
}
