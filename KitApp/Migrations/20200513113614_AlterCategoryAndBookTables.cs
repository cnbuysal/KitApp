using Microsoft.EntityFrameworkCore.Migrations;

namespace KitApp.Migrations
{
    public partial class AlterCategoryAndBookTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentCategoryId",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Dimensions", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPreferredBook", "Language", "Name", "PageNumber", "Price", "PublicationDate", "Publisher" },
                values: new object[] { 13, "Harold Caleb Kelly", 4, "It covers the theory behind clock movement and design, including the particulars of escapements, pendulums, balance wheels, and even the sheet music for popular chimes. The American striking clock, the 400-day clock, and the alarm clock receive special attention. The in-depth information, including explanations of clock repairing terminology and details on the tools, materials, and supplies that are needed for success, will benefit even skilled enthusiasts.", "14x21", "~/images/BookThumbnails/clock.jpg", "", 18, false, "English", "Clock Repairing as a Hobby", "128", 84.99m, "2007", "Skyhorse Publishing" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Dimensions", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPreferredBook", "Language", "Name", "PageNumber", "Price", "PublicationDate", "Publisher" },
                values: new object[] { 14, "Bluey", 6, "Bluey and Bingo love being creative! Get making with loads of egg-cellent Easter activities for the whole family.Bluey has been a phenomenal success since airing on ABC KIDS in October 2018,amassing legions of dedicated fans and taking the coveted position of being the most watched program ever on ABC iView,with over 200 million plays.It has also topped the Australian iTunes Kids Chart with the series peaking at #1 and consistently remaining in the Top 5.", "14x29.5", "~/images/BookThumbnails/bluey.jpg", "", 78, false, "English", "Bluey: Easter Fun! : A Craft Book", "24", 124.32m, "2020", "Penguin Books Australia" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CategoryName",
                value: "Children's Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.AddColumn<int>(
                name: "ParentCategoryId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CategoryName",
                value: "Novel");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "ParentCategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "ParentCategoryId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "ParentCategoryId",
                value: 6);
        }
    }
}
