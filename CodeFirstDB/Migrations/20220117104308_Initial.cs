using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstDB.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeerColors",
                columns: table => new
                {
                    ColorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeerColors", x => x.ColorID);
                });

            migrationBuilder.CreateTable(
                name: "BeerStyles",
                columns: table => new
                {
                    StyleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeerStyles", x => x.StyleId);
                });

            migrationBuilder.CreateTable(
                name: "Countrys",
                columns: table => new
                {
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countrys", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Brewerys",
                columns: table => new
                {
                    BreweryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brewerys", x => x.BreweryId);
                    table.ForeignKey(
                        name: "FK_Brewerys_Countrys_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countrys",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Beers",
                columns: table => new
                {
                    BeerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ibu = table.Column<float>(type: "real", nullable: false),
                    Degree = table.Column<float>(type: "real", nullable: false),
                    BreweryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StyleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ColorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beers", x => x.BeerId);
                    table.ForeignKey(
                        name: "FK_Beers_BeerColors_ColorID",
                        column: x => x.ColorID,
                        principalTable: "BeerColors",
                        principalColumn: "ColorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Beers_BeerStyles_StyleId",
                        column: x => x.StyleId,
                        principalTable: "BeerStyles",
                        principalColumn: "StyleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Beers_Brewerys_BreweryId",
                        column: x => x.BreweryId,
                        principalTable: "Brewerys",
                        principalColumn: "BreweryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    IngredientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeerEntityBeerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ebc = table.Column<float>(type: "real", nullable: true),
                    AlphaAcid = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.IngredientId);
                    table.ForeignKey(
                        name: "FK_Ingredients_Beers_BeerEntityBeerId",
                        column: x => x.BeerEntityBeerId,
                        principalTable: "Beers",
                        principalColumn: "BeerId");
                });

            migrationBuilder.CreateTable(
                name: "BeerIngredients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BeerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IngredientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeerIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BeerIngredients_Beers_BeerId",
                        column: x => x.BeerId,
                        principalTable: "Beers",
                        principalColumn: "BeerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BeerIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BeerIngredients_BeerId",
                table: "BeerIngredients",
                column: "BeerId");

            migrationBuilder.CreateIndex(
                name: "IX_BeerIngredients_IngredientId",
                table: "BeerIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_Beers_BreweryId",
                table: "Beers",
                column: "BreweryId");

            migrationBuilder.CreateIndex(
                name: "IX_Beers_ColorID",
                table: "Beers",
                column: "ColorID");

            migrationBuilder.CreateIndex(
                name: "IX_Beers_StyleId",
                table: "Beers",
                column: "StyleId");

            migrationBuilder.CreateIndex(
                name: "IX_Brewerys_CountryId",
                table: "Brewerys",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_BeerEntityBeerId",
                table: "Ingredients",
                column: "BeerEntityBeerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BeerIngredients");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Beers");

            migrationBuilder.DropTable(
                name: "BeerColors");

            migrationBuilder.DropTable(
                name: "BeerStyles");

            migrationBuilder.DropTable(
                name: "Brewerys");

            migrationBuilder.DropTable(
                name: "Countrys");
        }
    }
}
