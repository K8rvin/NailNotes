using Microsoft.EntityFrameworkCore.Migrations;

namespace LizokasNail.Core.Migrations
{
    public partial class commentField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "User");
        }
    }
}
