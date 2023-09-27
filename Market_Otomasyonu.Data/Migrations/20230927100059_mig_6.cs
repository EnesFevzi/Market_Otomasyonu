using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Market_Otomasyonu.Data.Migrations
{
    public partial class mig_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IsWorking",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "ExpirationDate",
                value: new DateTime(2023, 9, 27, 13, 0, 58, 695, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "ExpirationDate",
                value: new DateTime(2023, 9, 27, 13, 0, 58, 695, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "ExpirationDate",
                value: new DateTime(2023, 9, 27, 13, 0, 58, 695, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "IsWorking" },
                values: new object[] { new DateTime(2023, 9, 27, 13, 0, 58, 695, DateTimeKind.Local).AddTicks(5749), "Çalışıyor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsWorking",
                table: "Users",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                columns: new[] { "CreatedDate", "IsWorking" },
                values: new object[] { new DateTime(2023, 9, 27, 11, 19, 55, 199, DateTimeKind.Local).AddTicks(7434), true });
        }
    }
}
