using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstDB.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Beers_BeerEntityBeerId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_BeerEntityBeerId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "BeerEntityBeerId",
                table: "Ingredients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BeerEntityBeerId",
                table: "Ingredients",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_BeerEntityBeerId",
                table: "Ingredients",
                column: "BeerEntityBeerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Beers_BeerEntityBeerId",
                table: "Ingredients",
                column: "BeerEntityBeerId",
                principalTable: "Beers",
                principalColumn: "BeerId");
        }
    }
}
