using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BurgerMvc.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExtraIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraIngredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    TotalPrice = table.Column<double>(type: "float", nullable: true),
                    IsOrderConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrdersExtras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ExtraIngredientId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersExtras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersExtras_ExtraIngredients_ExtraIngredientId",
                        column: x => x.ExtraIngredientId,
                        principalTable: "ExtraIngredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersExtras_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersMenu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    MenuItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersMenu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersMenu_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersMenu_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ExtraIngredients",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "Name", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(347), null, false, null, "Cheddar Peyniri", "cheddar.jpeg", 1.5 },
                    { 2, new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(352), null, false, null, "Jalapeno Biberi", "jalapeno.jpeg", 1.0 },
                    { 3, new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(354), null, false, null, "Mantar", "mantar.jpeg", 1.25 },
                    { 4, new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(356), null, false, null, "Soğan", "soğan.jpeg", 0.75 },
                    { 5, new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(357), null, false, null, "Turşu", "turşu.jpeg", 0.5 },
                    { 6, new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(359), null, false, null, "Domates", "domates.jpeg", 0.75 },
                    { 7, new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(360), null, false, null, "Marul", "marul.jpeg", 0.5 },
                    { 8, new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(362), null, false, null, "Avokado", "avokado.jpeg", 1.75 },
                    { 9, new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(363), null, false, null, "Siyah Zeytin", "siyahzeytin.jpg", 1.0 },
                    { 10, new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(365), null, false, null, "Yeşil Zeytin", "yeşilzeytin.jpeg", 1.0 }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Content", "CreatedDate", "DeletedDate", "IsDeleted", "ModifiedDate", "Photo", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Siyah çavdar ekmeği, dana köftesi, cheddar peyniri, marul, domates, soğan, özel Python sosu (barbekü sos bazlı, hafif baharatlı).", new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(197), null, false, null, "python.jpeg", 7.9900000000000002, "Python Burger" },
                    { 2, "Tam buğday ekmeği, tavuk veya dana köftesi, çift cheddar peyniri, bacon, marul, domates,soğan,özelJava       sosu      (kahve ve hardal karışımı).", new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(203), null, false, null, "java.jpg", 8.9900000000000002, "Java Burger" },
                    { 3, "Siyah ekmek, renkli köfte (kırmızı pancar, havuç gibi sebzelerle), mavi peynir, marul, domates,soğan, özel        JavaScript sosu (tatlı ve ekşi karışımı).", new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(283), null, false, null, "javascript.jpeg", 9.4900000000000002, "JavaScript Burger" },
                    { 4, "Tam buğday ekmeği, baharatlı dana köftesi, mavi peynir, jalapeno biber, marul, domates, soğan, özel C++ sosu (acı biber sosu bazlı).", new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(286), null, false, null, "c++.jpeg", 8.7899999999999991, "C++ Burger" },
                    { 5, "Beyaz ekmek, tavuk veya dana köftesi, cheddar peyniri, marul, domates, soğan, özel C# sosu (barbeküsos ve      mayonez    karışımı).", new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(288), null, false, null, "csharp.jpeg", 8.2899999999999991, "C# Burger" },
                    { 6, "Siyah ekmek, elma ve cevizli köfte, brie peyniri, marul, elma dilimleri, özel Swift sosu (elma sirkes ve    bal       karışımı).", new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(289), null, false, null, "swift.jpeg", 9.9900000000000002, "Swift Burger" },
                    { 7, "Tam buğday ekmeği, somon veya tofu köftesi, avokado, marul, domates, soğan, özel Ruby on Rails sosu (limonlu        mayonez bazlı).", new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(291), null, false, null, "ruby.jpg", 10.49, "Ruby on Rails Burger" },
                    { 8, "Beyaz ekmek, dana köftesi, cheddar peyniri, marul, domates, soğan, özel PHP sosu (barbekü sos ve ketçap karışımı).", new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(292), null, false, null, "php.jpg", 7.4900000000000002, "PHP Burger" },
                    { 9, "Tam buğday ekmeği, dana köftesi, cheddar peyniri, marul, domates, soğan, özel Go sosu (soya sosu ve zencefil        karışımı).", new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(294), null, false, null, "go.jpg", 8.5899999999999999, "Go Burger" },
                    { 10, "Siyah çavdar ekmeği, tavuk veya dana köftesi, gruyère peyniri, marul, domates, soğan, özel Kotlin sos       (hardal,  mayonez ve bal karışımı).", new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(296), null, false, null, "kotlin.jpeg", 8.9900000000000002, "Kotlin Burger" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Birthdate", "CreatedDate", "DeletedDate", "Email", "IsAdmin", "IsDeleted", "ModifiedDate", "Name", "Password", "Photo", "Surname" },
                values: new object[,]
                {
                    { 2, new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 16, 3, 36, 188, DateTimeKind.Local).AddTicks(9897), null, "a", true, false, null, "Jane", "a", "jane_smith_photo.jpg", "Smith" },
                    { 3, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 16, 3, 36, 188, DateTimeKind.Local).AddTicks(9870), null, "b", false, false, null, "John", "b", "john_doe_photo.jpg", "Doe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersExtras_ExtraIngredientId",
                table: "OrdersExtras",
                column: "ExtraIngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersExtras_OrderId",
                table: "OrdersExtras",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersMenu_MenuItemId",
                table: "OrdersMenu",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersMenu_OrderId",
                table: "OrdersMenu",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdersExtras");

            migrationBuilder.DropTable(
                name: "OrdersMenu");

            migrationBuilder.DropTable(
                name: "ExtraIngredients");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
