using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ntp.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class ilkmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    Sort = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Details_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsDeleted", "Name", "Sort", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Elektronik", 1, 0 },
                    { 2, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Moda", 2, 0 },
                    { 3, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Oto, Bahçe, Yapı Merket", 3, 0 },
                    { 4, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Bilgisayar ve Tablet", 1, 1 },
                    { 5, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, false, "Beyaz Eşye", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Asus TUF Gaming FX607VU-RL017 Intel Core 5 210H 16GB 512GB SSD RTX4050 Freedos 16\" Taşınabilir Bilgisayar\r\nAsus TUF Gaming FX607VU-RL017 Intel Core 5 210H 16GB 512GB SSD RTX4050 Freedos 16\" Taşınabilir Bilgisayar\r\nAsus TUF Gaming FX607VU-RL017 Intel Core 5 210H 16GB 512GB SSD RTX4050 Freedos 16\" Taşınabilir Bilgisayar\r\nAsus TUF Gaming FX607VU-RL017 Intel Core 5 210H 16GB 512GB SSD RTX4050 Freedos 16\" Taşınabilir Bilgisayar\r\n", false, "Asus TUF Gaming FX607VU-RL017 Intel Core 5 210H 16GB 512GB SSD RTX4050 Freedos 16\" Taşınabilir Bilgisayar", 43899 },
                    { 2, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Lenovo Thınkbook 16 21CY006FTR I5-1235U 8gb 512GB SSD 16\" Fdos\r\nLENOVO THINKBOOK 16 21CY006FTR i5-1235U 8GB 512GB SSD 16\" FDOSLenovo Thınkbook 16 21CY006FTR I5-1235U 8gb 512GB SSD 16\" Fdos\r\nLENOVO THINKBOOK 16 21CY006FTR i5-1235U 8GB 512GB SSD 16\" FDOSLenovo Thınkbook 16 21CY006FTR I5-1235U 8gb 512GB SSD 16\" Fdos\r\nLENOVO THINKBOOK 16 21CY006FTR i5-1235U 8GB 512GB SSD 16\" FDOSLenovo Thınkbook 16 21CY006FTR I5-1235U 8gb 512GB SSD 16\" Fdos\r\nLENOVO THINKBOOK 16 21CY006FTR i5-1235U 8GB 512GB SSD 16\" FDOS", false, "Lenovo Thınkbook 16 21CY006FTR I5-1235U 8gb 512GB SSD 16\" Fdos\r\n", 35000 },
                    { 3, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "GENEL ÖZELLİKLER Boy: 70 cm Kol Boyu: 62 cm Desen: Düz Renk Kumaş.; Wellsoft Ek Özellik: Kapüşonlu “Ürünümüz wellsoft kumaştan üretilmiştir. Kumaşın doğası gereği ilk kullanımda hafif tüy bırakabilir, ancak bu durum ilk yıkamadan sonra tamamen ortadan kalkar. Bu, kumaşın özelliğinden kaynaklıdır ve ürünün kalitesine olumsuz bir etkisi yoktur.” YIKAMA ÖZELLİKLERİ - Maksimum 30 derecede yıkayınız.; - Yüksek ısıda ütü yapmayınız.; - Ağartıcı ve kimyasal madde kullanmayınız.; - Kurutma makinesine atmayınız.; KUMAŞ ÖZELLİKLERİ - Rahat ve yumuşak dokusu ile ön plana çıkan welsoft kumaşlar, tamamen polyesterden üretilmiş olan kumaş türleridir.; - Welsoft kumaş pek çok farklı özelliği ile günümüzde sağlık açısından büyük öneme sahip kumaş türlerinden biridir.; - özelliğe sahiptir.; - Alerji ve ile gibi durumlarda çocuklar ve yetişkinler için kullanılır.", false, "Kapüşonlu Polar Welsoft Peluş Hırka", 470 },
                    { 4, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Yaman Market Kadın Uzun Kollu Önü Açık Desenli Şardonlu Dalgıç Ceket\r\nKadın Uzun Kollu önü Açık Desenli şardonlu Dalgıç CeketYaman Market Kadın Uzun Kollu Önü Açık Desenli Şardonlu Dalgıç Ceket\r\nKadın Uzun Kollu önü Açık Desenli şardonlu Dalgıç CeketYaman Market Kadın Uzun Kollu Önü Açık Desenli Şardonlu Dalgıç Ceket\r\nKadın Uzun Kollu önü Açık Desenli şardonlu Dalgıç Ceket", false, "Yaman Market Kadın Uzun Kollu Önü Açık Desenli Şardonlu Dalgıç Ceket", 1000 },
                    { 5, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Asus deletedAsus deletedAsus deletedAsus deletedAsus deletedAsus deletedAsus deletedAsus deletedAsus deletedAsus deleted", true, "Asus deleted", 10000 }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Cat3DetailDescription1", false, "Cat3DetailTitle1" },
                    { 2, 3, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Cat3DetailDescription2", false, "Cat3DetailTitle2" },
                    { 3, 4, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Cat4DetailDescription1", false, "Cat4DetailTitle1" },
                    { 4, 4, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Cat4DetailDescription2", true, "Cat4DetailTitle2" },
                    { 5, 4, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, "Cat4DetailDescription3", false, "Cat4DetailTitle3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_CategoryId",
                table: "Details",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
