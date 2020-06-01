using Microsoft.EntityFrameworkCore.Migrations;

namespace KitApp.Migrations
{
    public partial class ShoppingCartItemPropertyChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "ShoppingCartItems");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ShoppingCartItems",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ShoppingCartItems");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "ShoppingCartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
