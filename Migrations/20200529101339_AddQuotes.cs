using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuotesWebAPI.Migrations
{
    public partial class AddQuotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 1, "Dalai Lama", new DateTime(2020, 5, 29, 15, 13, 39, 24, DateTimeKind.Local).AddTicks(3951), "The purpose of our lives is to be happy." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 2, "John Lennon", new DateTime(2020, 5, 29, 15, 13, 39, 26, DateTimeKind.Local).AddTicks(4052), "Life is what happens when you’re busy making other plans." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 3, "Stephen King", new DateTime(2020, 5, 29, 15, 13, 39, 26, DateTimeKind.Local).AddTicks(4089), "Get busy living or get busy dying." });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 4, "Mae West", new DateTime(2020, 5, 29, 15, 13, 39, 26, DateTimeKind.Local).AddTicks(4091), "You only live once, but if you do it right, once is enough" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "InsertDate", "Text" },
                values: new object[] { 5, "Babe Ruth", new DateTime(2020, 5, 29, 15, 13, 39, 26, DateTimeKind.Local).AddTicks(4093), "Never let the fear of striking out keep you from playing the game" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
