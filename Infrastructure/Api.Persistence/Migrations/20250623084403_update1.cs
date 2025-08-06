using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 23, 11, 44, 3, 562, DateTimeKind.Local).AddTicks(9091), "Toys" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 23, 11, 44, 3, 562, DateTimeKind.Local).AddTicks(9099), "Toys" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 23, 11, 44, 3, 562, DateTimeKind.Local).AddTicks(9106), "Health" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 23, 11, 44, 3, 563, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 23, 11, 44, 3, 563, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 23, 11, 44, 3, 563, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 23, 11, 44, 3, 563, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 6, 23, 11, 44, 3, 564, DateTimeKind.Local).AddTicks(7735), "Koyun dignissimos çünkü biber layıkıyla aperiam bahar adanaya.\nOdio gül balıkhaneye domates eos magni.\nSequi sokaklarda qui.\nOdio ki voluptatum çorba voluptate ipsum nesciunt quis salladı quaerat.\nAlias adanaya sit ea layıkıyla minima sevindi.", "Voluptatem labore ekşili sandalye labore ea dışarı sit çarpan." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 6, 23, 11, 44, 3, 564, DateTimeKind.Local).AddTicks(7952), "Gülüyorum et umut olduğu doğru mutlu makinesi blanditiis sıradanlıktan ışık.\nGazete anlamsız düşünüyor sandalye.\nQuasi voluptatem esse illo fugit.\nNihil ipsa masaya masaya ut aliquid türemiş masanın ducimus.\nExplicabo hesap nesciunt quia voluptate çarpan ötekinden gitti.", "Eum molestiae voluptate yazın mıknatıslı perferendis karşıdakine ut balıkhaneye.\nVoluptatem nemo ut için neque çünkü düşünüyor sequi voluptatem." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 6, 23, 11, 44, 3, 564, DateTimeKind.Local).AddTicks(8111), "Sed sed sokaklarda ışık sit quia camisi quia biber.\nKoyun vitae quia autem gitti ut exercitationem consequatur.\nConsequatur orta odit ona bilgisayarı sit amet.\nCommodi ki doğru ex hesap aliquam quia biber ullam.\nSayfası sit commodi türemiş.", "Sinema architecto un biber blanditiis kulu masaya sinema laudantium quia." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 23, 11, 44, 3, 567, DateTimeKind.Local).AddTicks(814), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9.653320985909630m, 800.64m, "Tasty Wooden Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 23, 11, 44, 3, 567, DateTimeKind.Local).AddTicks(842), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 6.938967967494770m, 585.90m, "Fantastic Fresh Bacon" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

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

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 13, 11, 37, 43, 348, DateTimeKind.Local).AddTicks(3347), "Kids" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 13, 11, 37, 43, 348, DateTimeKind.Local).AddTicks(3354), "Electronics" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 6, 13, 11, 37, 43, 348, DateTimeKind.Local).AddTicks(3360), "Clothing" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 13, 11, 37, 43, 348, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 13, 11, 37, 43, 348, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 13, 11, 37, 43, 348, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 6, 13, 11, 37, 43, 348, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 6, 13, 11, 37, 43, 350, DateTimeKind.Local).AddTicks(6477), "Quia quia değirmeni et aliquam.\nÇobanın ve karşıdakine salladı inventore aut aperiam gitti.\nModi esse magnam şafak mi odio veniam çorba okuma.\nAçılmadan accusantium mi esse bilgisayarı.\nPatlıcan duyulmamış quis için gitti inventore koştum.", "Perferendis nostrum sit koyun blanditiis sıradanlıktan." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 6, 13, 11, 37, 43, 350, DateTimeKind.Local).AddTicks(6706), "Et deleniti inventore voluptatem.\nMi ea düşünüyor teldeki voluptas mi teldeki.\nEt sinema sarmal ona veniam suscipit öyle.\nPatlıcan deleniti koştum.\nAliquam adipisci anlamsız quia.", "Dicta sıradanlıktan dicta fugit illo dolorem blanditiis ratione in qui.\nArchitecto autem kutusu quam dolayı sed." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 6, 13, 11, 37, 43, 350, DateTimeKind.Local).AddTicks(6826), "Dicta ut adanaya.\nVe gidecekmiş minima numquam lambadaki reprehenderit autem.\nEkşili in değerli veritatis corporis aut quia.\nYapacakmış accusantium dergi de totam sunt eos dolorem velit.\nNihil salladı quia.", "Qui ut koyun nesciunt quam et koşuyorlar yaptı consequatur." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 13, 11, 37, 43, 352, DateTimeKind.Local).AddTicks(6579), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 9.63399701540110m, 482.68m, "Incredible Rubber Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 6, 13, 11, 37, 43, 352, DateTimeKind.Local).AddTicks(6605), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 5.035051225811230m, 870.54m, "Fantastic Fresh Chair" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");
        }
    }
}
