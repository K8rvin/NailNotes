using Microsoft.EntityFrameworkCore.Migrations;

namespace LizokasNail.Core.Migrations
{
    public partial class clearidsfromCheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaseId",
                table: "Check");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Check");

            migrationBuilder.DropColumn(
                name: "TopId",
                table: "Check");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BaseId",
                table: "Check",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Check",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopId",
                table: "Check",
                type: "int",
                nullable: true);
        }
    }
}
