using Microsoft.EntityFrameworkCore.Migrations;

namespace KitApp.Migrations
{
    public partial class AddedCityPropertyToOrderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Orders");
        }
    }
}
