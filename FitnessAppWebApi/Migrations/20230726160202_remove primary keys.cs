using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessAppWebApi.Migrations
{
    /// <inheritdoc />
    public partial class removeprimarykeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Workouts",
                table: "Workouts");

            migrationBuilder.AlterColumn<string>(
                name: "Exercise",
                table: "Workouts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Workouts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workouts",
                table: "Workouts",
                columns: new[] { "UserID", "Date" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Workouts",
                table: "Workouts");

            migrationBuilder.AlterColumn<string>(
                name: "Exercise",
                table: "Workouts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Workouts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workouts",
                table: "Workouts",
                columns: new[] { "UserID", "Date", "Category", "Exercise" });
        }
    }
}
