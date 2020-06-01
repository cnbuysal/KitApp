using Microsoft.EntityFrameworkCore.Migrations;

namespace KitApp.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ParentCategoryId",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "Edebiyat", null },
                    { 2, "Eğitim", null },
                    { 3, "Foreign Languages", null },
                    { 4, "Hobi", null },
                    { 5, "Şiir", 1 },
                    { 6, "Roman", 1 },
                    { 7, "Fantastik", 6 },
                    { 8, "Polisiye", 6 },
                    { 9, "Bilim Kurgu", 6 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Dimensions", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPreferredBook", "Language", "Name", "PageNumber", "Price", "PublicationDate", "Publisher" },
                values: new object[] { 1, "J.R.R. Tolkien", 1, "Bir yolculuk, bir büyüme öyküsü; fedakârlık ve dostluk üzerine, hırs ve ihanet üzerine bir roman.", "13x20", "~/images/lotr.jpg", "~/images/lotr.jpg", 25, true, "Türkçe", "Yüzük Kardeşliği", "496", 51.20m, "2000", "Metis Yayıncılık" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Dimensions", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPreferredBook", "Language", "Name", "PageNumber", "Price", "PublicationDate", "Publisher" },
                values: new object[] { 2, "George R. R. Martin", 1, "Yazların on yıllar, kışların bir insan ömrü sürebildiği diyarda, dehşetli ve soğuk zamanlar yaklaşmaktadır. Kışyarı'nın kuzeyindeki buzul topraklarda, Yedi Krallık'ı koruyan Sur'un ötesinde tehditkâr doğaüstü güçler toplanmaktadır. ", "13x20", "~/images/taht.jpg", "~/images/taht.jpg", 14, false, "Türkçe", "Taht Oyunları", "850", 36.75m, "2011", "Epsilon Yayınevi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "ParentCategoryId",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
