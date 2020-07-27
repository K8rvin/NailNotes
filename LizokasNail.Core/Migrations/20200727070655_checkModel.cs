using Microsoft.EntityFrameworkCore.Migrations;

namespace LizokasNail.Core.Migrations
{
    public partial class checkModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Check",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordId = table.Column<int>(nullable: false),
                    BaseId = table.Column<int>(nullable: true),
                    ColorId = table.Column<int>(nullable: true),
                    TopId = table.Column<int>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Check", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Check_Base_BaseId",
                        column: x => x.BaseId,
                        principalTable: "Base",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Check_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Check_Record_RecordId",
                        column: x => x.RecordId,
                        principalTable: "Record",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Check_Top_TopId",
                        column: x => x.TopId,
                        principalTable: "Top",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Design",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Design", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Check2Design",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCheck = table.Column<int>(nullable: false),
                    IdDesign = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Check2Design", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Check2Design_Check_IdCheck",
                        column: x => x.IdCheck,
                        principalTable: "Check",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Check2Design_Design_IdDesign",
                        column: x => x.IdDesign,
                        principalTable: "Design",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Check_BaseId",
                table: "Check",
                column: "BaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_ColorId",
                table: "Check",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_RecordId",
                table: "Check",
                column: "RecordId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Check_TopId",
                table: "Check",
                column: "TopId");

            migrationBuilder.CreateIndex(
                name: "IX_Check2Design_IdCheck",
                table: "Check2Design",
                column: "IdCheck");

            migrationBuilder.CreateIndex(
                name: "IX_Check2Design_IdDesign",
                table: "Check2Design",
                column: "IdDesign");

            migrationBuilder.CreateIndex(
                name: "IX_Design_Name",
                table: "Design",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Check2Design");

            migrationBuilder.DropTable(
                name: "Check");

            migrationBuilder.DropTable(
                name: "Design");
        }
    }
}
