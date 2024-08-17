using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerMvc.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6237), "ca978112ca1bbdcafac231b39a23dc4da786eff8147c4e72b9807785afee48bb" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 8, 11, 19, 45, 39, 209, DateTimeKind.Local).AddTicks(6209), "3e23e8160039594a33894f6564e1b1348bbd7a0088d42c4acb73eeaed59c009d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "ExtraIngredients",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7334), "a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 8, 11, 13, 17, 11, 66, DateTimeKind.Local).AddTicks(7297), "b" });
        }
    }
}
