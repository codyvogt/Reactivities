using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WeatherForcasts",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC" },
                values: new object[] { 1, new DateTime(2019, 9, 3, 14, 58, 33, 673, DateTimeKind.Local).AddTicks(4380), "It is warm out today", 30 });

            migrationBuilder.InsertData(
                table: "WeatherForcasts",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC" },
                values: new object[] { 2, new DateTime(2019, 9, 2, 14, 58, 33, 675, DateTimeKind.Local).AddTicks(5041), "It is cold out today", 20 });

            migrationBuilder.InsertData(
                table: "WeatherForcasts",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC" },
                values: new object[] { 3, new DateTime(2019, 9, 1, 14, 58, 33, 675, DateTimeKind.Local).AddTicks(5142), "It is HOT out today", 45 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeatherForcasts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WeatherForcasts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WeatherForcasts",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
