using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstDB.Migrations
{
    public partial class Idupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_BeerColors_ColorID",
                table: "Beers");

            migrationBuilder.RenameColumn(
                name: "IngredientId",
                table: "Ingredients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Countrys",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BreweryId",
                table: "Brewerys",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StyleId",
                table: "BeerStyles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ColorID",
                table: "Beers",
                newName: "ColorId");

            migrationBuilder.RenameColumn(
                name: "BeerId",
                table: "Beers",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Beers_ColorID",
                table: "Beers",
                newName: "IX_Beers_ColorId");

            migrationBuilder.RenameColumn(
                name: "ColorID",
                table: "BeerColors",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_BeerColors_ColorId",
                table: "Beers",
                column: "ColorId",
                principalTable: "BeerColors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_BeerColors_ColorId",
                table: "Beers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ingredients",
                newName: "IngredientId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Countrys",
                newName: "CountryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Brewerys",
                newName: "BreweryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BeerStyles",
                newName: "StyleId");

            migrationBuilder.RenameColumn(
                name: "ColorId",
                table: "Beers",
                newName: "ColorID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Beers",
                newName: "BeerId");

            migrationBuilder.RenameIndex(
                name: "IX_Beers_ColorId",
                table: "Beers",
                newName: "IX_Beers_ColorID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BeerColors",
                newName: "ColorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_BeerColors_ColorID",
                table: "Beers",
                column: "ColorID",
                principalTable: "BeerColors",
                principalColumn: "ColorID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
