using Microsoft.EntityFrameworkCore.Migrations;

namespace LizokasNail.Core.Migrations
{
    public partial class many2manyRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Check_Base_BaseId",
                table: "Check");

            migrationBuilder.DropForeignKey(
                name: "FK_Check_Color_ColorId",
                table: "Check");

            migrationBuilder.DropForeignKey(
                name: "FK_Check_Top_TopId",
                table: "Check");

            migrationBuilder.DropIndex(
                name: "IX_Check_BaseId",
                table: "Check");

            migrationBuilder.DropIndex(
                name: "IX_Check_ColorId",
                table: "Check");

            migrationBuilder.DropIndex(
                name: "IX_Check_TopId",
                table: "Check");

            migrationBuilder.CreateTable(
                name: "Check2Base",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCheck = table.Column<int>(nullable: false),
                    IdBase = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Check2Base", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Check2Base_Base_IdBase",
                        column: x => x.IdBase,
                        principalTable: "Base",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Check2Base_Check_IdCheck",
                        column: x => x.IdCheck,
                        principalTable: "Check",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Check2Color",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCheck = table.Column<int>(nullable: false),
                    IdColor = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Check2Color", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Check2Color_Check_IdCheck",
                        column: x => x.IdCheck,
                        principalTable: "Check",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Check2Color_Color_IdColor",
                        column: x => x.IdColor,
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Check2Top",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCheck = table.Column<int>(nullable: false),
                    IdTop = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Check2Top", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Check2Top_Check_IdCheck",
                        column: x => x.IdCheck,
                        principalTable: "Check",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Check2Top_Top_IdTop",
                        column: x => x.IdTop,
                        principalTable: "Top",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Check2Base_IdBase",
                table: "Check2Base",
                column: "IdBase");

            migrationBuilder.CreateIndex(
                name: "IX_Check2Base_IdCheck",
                table: "Check2Base",
                column: "IdCheck");

            migrationBuilder.CreateIndex(
                name: "IX_Check2Color_IdCheck",
                table: "Check2Color",
                column: "IdCheck");

            migrationBuilder.CreateIndex(
                name: "IX_Check2Color_IdColor",
                table: "Check2Color",
                column: "IdColor");

            migrationBuilder.CreateIndex(
                name: "IX_Check2Top_IdCheck",
                table: "Check2Top",
                column: "IdCheck");

            migrationBuilder.CreateIndex(
                name: "IX_Check2Top_IdTop",
                table: "Check2Top",
                column: "IdTop");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Check2Base");

            migrationBuilder.DropTable(
                name: "Check2Color");

            migrationBuilder.DropTable(
                name: "Check2Top");

            migrationBuilder.CreateIndex(
                name: "IX_Check_BaseId",
                table: "Check",
                column: "BaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_ColorId",
                table: "Check",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Check_TopId",
                table: "Check",
                column: "TopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Base_BaseId",
                table: "Check",
                column: "BaseId",
                principalTable: "Base",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Color_ColorId",
                table: "Check",
                column: "ColorId",
                principalTable: "Color",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Top_TopId",
                table: "Check",
                column: "TopId",
                principalTable: "Top",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
