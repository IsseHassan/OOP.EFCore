using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OOP.EFCore.ConsoleApp.Migrations
{
    public partial class NewBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 23, 14, 12, 14, 272, DateTimeKind.Local).AddTicks(7041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 21, 22, 48, 32, 212, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Title",
                value: "Yldaki Isikler");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Title" },
                values: new object[] { 4, "Nageeye" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 21, 22, 48, 32, 212, DateTimeKind.Local).AddTicks(5431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 23, 14, 12, 14, 272, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Title",
                value: "YOldaki Isikler");
        }
    }
}
