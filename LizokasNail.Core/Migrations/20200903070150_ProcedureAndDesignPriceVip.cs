using Microsoft.EntityFrameworkCore.Migrations;

namespace LizokasNail.Core.Migrations
{
    public partial class ProcedureAndDesignPriceVip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "PriceVip",
                table: "Procedure",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PriceVip",
                table: "Design",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceVip",
                table: "Procedure");

            migrationBuilder.DropColumn(
                name: "PriceVip",
                table: "Design");
        }
    }
}
