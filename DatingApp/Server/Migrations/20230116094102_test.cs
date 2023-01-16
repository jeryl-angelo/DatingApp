using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.Server.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 1,
                column: "DateMatched",
                value: new DateTime(2023, 1, 16, 17, 41, 2, 277, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 2,
                column: "DateMatched",
                value: new DateTime(2023, 1, 16, 17, 41, 2, 277, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 16, 17, 41, 2, 275, DateTimeKind.Local).AddTicks(899), new DateTime(2023, 1, 16, 17, 41, 2, 276, DateTimeKind.Local).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 16, 17, 41, 2, 276, DateTimeKind.Local).AddTicks(851), new DateTime(2023, 1, 16, 17, 41, 2, 276, DateTimeKind.Local).AddTicks(856) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 1,
                column: "DateMatched",
                value: new DateTime(2023, 1, 16, 17, 16, 46, 726, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Matches",
                keyColumn: "MatchId",
                keyValue: 2,
                column: "DateMatched",
                value: new DateTime(2023, 1, 16, 17, 16, 46, 726, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 16, 17, 16, 46, 724, DateTimeKind.Local).AddTicks(2149), new DateTime(2023, 1, 16, 17, 16, 46, 724, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 1, 16, 17, 16, 46, 725, DateTimeKind.Local).AddTicks(680), new DateTime(2023, 1, 16, 17, 16, 46, 725, DateTimeKind.Local).AddTicks(685) });
        }
    }
}
