using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Market_Otomasyonu.Data.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FaturaID",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2023, 9, 26, 18, 15, 46, 479, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2023, 9, 26, 18, 15, 46, 479, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "ExpirationDate",
                value: new DateTime(2023, 9, 26, 18, 15, 46, 479, DateTimeKind.Local).AddTicks(9157));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FaturaID",
                table: "Sales");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2023, 9, 26, 17, 57, 17, 90, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2023, 9, 26, 17, 57, 17, 90, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "ExpirationDate",
                value: new DateTime(2023, 9, 26, 17, 57, 17, 90, DateTimeKind.Local).AddTicks(3559));
        }
    }
}
