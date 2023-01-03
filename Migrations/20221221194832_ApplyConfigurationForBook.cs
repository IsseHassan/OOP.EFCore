using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OOP.EFCore.ConsoleApp.Migrations
{
    public partial class ApplyConfigurationForBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 21, 22, 48, 32, 212, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Title" },
                values: new object[] { 1, "Devlet" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Title" },
                values: new object[] { 2, "YOldaki Isikler" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Title" },
                values: new object[] { 3, "Yanlizlik Sozleri" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);
        }
    }
}
