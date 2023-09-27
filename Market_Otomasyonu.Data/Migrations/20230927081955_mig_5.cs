using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Market_Otomasyonu.Data.Migrations
{
    public partial class mig_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkUnit",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2023, 9, 27, 11, 19, 55, 199, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2023, 9, 27, 11, 19, 55, 199, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "ExpirationDate",
                value: new DateTime(2023, 9, 27, 11, 19, 55, 199, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 27, 11, 19, 55, 199, DateTimeKind.Local).AddTicks(7434));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkUnit",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2023, 9, 27, 10, 59, 9, 639, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2023, 9, 27, 10, 59, 9, 639, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "ExpirationDate",
                value: new DateTime(2023, 9, 27, 10, 59, 9, 639, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 27, 10, 59, 9, 639, DateTimeKind.Local).AddTicks(1577));
        }
    }
}
