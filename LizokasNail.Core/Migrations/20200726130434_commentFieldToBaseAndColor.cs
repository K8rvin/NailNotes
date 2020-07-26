using Microsoft.EntityFrameworkCore.Migrations;

namespace LizokasNail.Core.Migrations
{
    public partial class commentFieldToBaseAndColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Color",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Base",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Color");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Base");
        }
    }
}
