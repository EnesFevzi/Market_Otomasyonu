using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Market_Otomasyonu.Data.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 1, "Atıştırmalık" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Brand", "CategoryID", "ExpirationDate", "IsContinued", "MarketID", "Name", "PurchasePrice", "Quantity", "SalePrice", "Stock", "TaxRatio", "Unit", "UnitPrice" },
                values: new object[] { 1, "Milka", 1, new DateTime(2023, 9, 26, 17, 57, 17, 90, DateTimeKind.Local).AddTicks(3545), true, null, "Çikolata", 7m, 0m, 10.59m, 100, 1.18m, 0, 5m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Brand", "CategoryID", "ExpirationDate", "IsContinued", "MarketID", "Name", "PurchasePrice", "Quantity", "SalePrice", "Stock", "TaxRatio", "Unit", "UnitPrice" },
                values: new object[] { 2, "Eti", 1, new DateTime(2023, 9, 26, 17, 57, 17, 90, DateTimeKind.Local).AddTicks(3557), true, null, "Çikolatalı Gofret", 8m, 0m, 15.59m, 100, 1.18m, 0, 6m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Brand", "CategoryID", "ExpirationDate", "IsContinued", "MarketID", "Name", "PurchasePrice", "Quantity", "SalePrice", "Stock", "TaxRatio", "Unit", "UnitPrice" },
                values: new object[] { 3, "Ülker", 1, new DateTime(2023, 9, 26, 17, 57, 17, 90, DateTimeKind.Local).AddTicks(3559), true, null, "Çikolatalı Gofret", 8m, 0m, 15.59m, 10, 1.18m, 0, 6m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);
        }
    }
}
