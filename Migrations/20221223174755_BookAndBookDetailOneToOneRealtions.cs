using Microsoft.EntityFrameworkCore.Migrations;

namespace OOP.EFCore.ConsoleApp.Migrations
{
    public partial class BookAndBookDetailOneToOneRealtions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetail_Books_BookId",
                table: "BookDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookDetail",
                table: "BookDetail");

            migrationBuilder.RenameTable(
                name: "BookDetail",
                newName: "BookDetailes");

            migrationBuilder.RenameIndex(
                name: "IX_BookDetail_BookId",
                table: "BookDetailes",
                newName: "IX_BookDetailes_BookId");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "BookDetailes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookDetailes",
                table: "BookDetailes",
                column: "BookDetailId");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "CategoryId",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetailes_Books_BookId",
                table: "BookDetailes",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetailes_Books_BookId",
                table: "BookDetailes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookDetailes",
                table: "BookDetailes");

            migrationBuilder.DropColumn(
                name: "City",
                table: "BookDetailes");

            migrationBuilder.RenameTable(
                name: "BookDetailes",
                newName: "BookDetail");

            migrationBuilder.RenameIndex(
                name: "IX_BookDetailes_BookId",
                table: "BookDetail",
                newName: "IX_BookDetail_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookDetail",
                table: "BookDetail",
                column: "BookDetailId");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "CategoryId",
                value: 3);

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetail_Books_BookId",
                table: "BookDetail",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
