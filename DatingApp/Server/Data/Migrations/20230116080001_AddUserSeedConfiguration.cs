using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.Server.Data.Migrations
{
    public partial class AddUserSeedConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 16, 16, 0, 0, 665, DateTimeKind.Local).AddTicks(6413), new DateTime(2023, 1, 16, 16, 0, 0, 666, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 16, 16, 0, 0, 666, DateTimeKind.Local).AddTicks(5058), new DateTime(2023, 1, 16, 16, 0, 0, 666, DateTimeKind.Local).AddTicks(5063) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 16, 15, 58, 22, 186, DateTimeKind.Local).AddTicks(3888), new DateTime(2023, 1, 16, 15, 58, 22, 187, DateTimeKind.Local).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 16, 15, 58, 22, 187, DateTimeKind.Local).AddTicks(2628), new DateTime(2023, 1, 16, 15, 58, 22, 187, DateTimeKind.Local).AddTicks(2634) });
        }
    }
}
