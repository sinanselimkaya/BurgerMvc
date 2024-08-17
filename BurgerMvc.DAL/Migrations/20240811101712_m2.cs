using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerMvc.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "MenuItems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "ExtraIngredients",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7738), 1.50m });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7741), 1.00m });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7743), 1.25m });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7745), 0.75m });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7747), 0.50m });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7750), 0.75m });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7752), 0.50m });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7754), 1.75m });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7756), 1.00m });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7758), 1.00m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7654), 7.99m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7665), 8.99m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7668), 9.49m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7671), 8.79m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7673), 8.29m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7676), 9.99m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7678), 10.49m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7681), 7.49m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7683), 8.59m });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7686), 8.99m });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7297));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalPrice",
                table: "Orders",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "MenuItems",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "ExtraIngredients",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(347), 1.5 });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(352), 1.0 });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(354), 1.25 });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(356), 0.75 });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(357), 0.5 });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(359), 0.75 });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(360), 0.5 });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(362), 1.75 });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(363), 1.0 });

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(365), 1.0 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(197), 7.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(203), 8.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(283), 9.4900000000000002 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(286), 8.7899999999999991 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(288), 8.2899999999999991 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(289), 9.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(291), 10.49 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(292), 7.4900000000000002 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(294), 8.5899999999999999 });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 3, 36, 189, DateTimeKind.Local).AddTicks(296), 8.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 16, 3, 36, 188, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 16, 3, 36, 188, DateTimeKind.Local).AddTicks(9870));
        }
    }
}
