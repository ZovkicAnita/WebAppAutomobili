using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppAutomobili.Migrations
{
    public partial class DrugaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Automobili_Kategorija_KategorijaId",
                table: "Automobili");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Automobili",
                table: "Automobili");

            migrationBuilder.RenameTable(
                name: "Automobili",
                newName: "Automobil");

            migrationBuilder.RenameIndex(
                name: "IX_Automobili_KategorijaId",
                table: "Automobil",
                newName: "IX_Automobil_KategorijaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Automobil",
                table: "Automobil",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Automobil_Kategorija_KategorijaId",
                table: "Automobil",
                column: "KategorijaId",
                principalTable: "Kategorija",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Automobil_Kategorija_KategorijaId",
                table: "Automobil");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Automobil",
                table: "Automobil");

            migrationBuilder.RenameTable(
                name: "Automobil",
                newName: "Automobili");

            migrationBuilder.RenameIndex(
                name: "IX_Automobil_KategorijaId",
                table: "Automobili",
                newName: "IX_Automobili_KategorijaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Automobili",
                table: "Automobili",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Automobili_Kategorija_KategorijaId",
                table: "Automobili",
                column: "KategorijaId",
                principalTable: "Kategorija",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
