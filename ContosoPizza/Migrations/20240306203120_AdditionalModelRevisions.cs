using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoPizza.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalModelRevisions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Sauces_SauceId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaTopping_Pizza_PizzasId",
                table: "PizzaTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizza",
                table: "Pizza");

            migrationBuilder.RenameTable(
                name: "Pizza",
                newName: "Pizzas");

            migrationBuilder.RenameIndex(
                name: "IX_Pizza_SauceId",
                table: "Pizzas",
                newName: "IX_Pizzas_SauceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Sauces_SauceId",
                table: "Pizzas",
                column: "SauceId",
                principalTable: "Sauces",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaTopping_Pizzas_PizzasId",
                table: "PizzaTopping",
                column: "PizzasId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Sauces_SauceId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaTopping_Pizzas_PizzasId",
                table: "PizzaTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizzas",
                table: "Pizzas");

            migrationBuilder.RenameTable(
                name: "Pizzas",
                newName: "Pizza");

            migrationBuilder.RenameIndex(
                name: "IX_Pizzas_SauceId",
                table: "Pizza",
                newName: "IX_Pizza_SauceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizza",
                table: "Pizza",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Sauces_SauceId",
                table: "Pizza",
                column: "SauceId",
                principalTable: "Sauces",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaTopping_Pizza_PizzasId",
                table: "PizzaTopping",
                column: "PizzasId",
                principalTable: "Pizza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
