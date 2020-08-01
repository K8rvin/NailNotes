using Microsoft.EntityFrameworkCore.Migrations;

namespace LizokasNail.Core.Migrations
{
    public partial class procedureModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Procedure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Record2Procedure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRecord = table.Column<int>(nullable: false),
                    IdProcedure = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Record2Procedure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Record2Procedure_Procedure_IdProcedure",
                        column: x => x.IdProcedure,
                        principalTable: "Procedure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Record2Procedure_Record_IdRecord",
                        column: x => x.IdRecord,
                        principalTable: "Record",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Procedure_Name",
                table: "Procedure",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Record2Procedure_IdProcedure",
                table: "Record2Procedure",
                column: "IdProcedure");

            migrationBuilder.CreateIndex(
                name: "IX_Record2Procedure_IdRecord",
                table: "Record2Procedure",
                column: "IdRecord");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Record2Procedure");

            migrationBuilder.DropTable(
                name: "Procedure");
        }
    }
}
