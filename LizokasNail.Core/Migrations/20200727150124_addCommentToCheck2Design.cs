using Microsoft.EntityFrameworkCore.Migrations;

namespace LizokasNail.Core.Migrations
{
    public partial class addCommentToCheck2Design : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Check2Design",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Check2Design");
        }
    }
}
