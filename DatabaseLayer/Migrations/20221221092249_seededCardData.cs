using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DatabaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class seededCardData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardDeckId",
                table: "Cards");

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "ActiveCard", "CardType", "Color", "IsHidden", "Value" },
                values: new object[,]
                {
                    { 1, true, 0, 0, false, 0 },
                    { 2, true, 0, 0, false, 1 },
                    { 3, true, 0, 0, false, 2 },
                    { 4, true, 0, 0, false, 3 },
                    { 5, true, 0, 0, false, 4 },
                    { 6, true, 0, 0, false, 5 },
                    { 7, true, 0, 0, false, 6 },
                    { 8, true, 0, 0, false, 7 },
                    { 9, true, 0, 0, false, 8 },
                    { 10, true, 0, 0, false, 9 },
                    { 11, true, 0, 0, false, 10 },
                    { 12, true, 0, 0, false, 11 },
                    { 13, true, 0, 0, false, 12 },
                    { 14, true, 1, 1, false, 0 },
                    { 15, true, 1, 1, false, 1 },
                    { 16, true, 1, 1, false, 2 },
                    { 17, true, 1, 1, false, 3 },
                    { 18, true, 1, 1, false, 4 },
                    { 19, true, 1, 1, false, 5 },
                    { 20, true, 1, 1, false, 6 },
                    { 21, true, 1, 1, false, 7 },
                    { 22, true, 1, 1, false, 8 },
                    { 23, true, 1, 1, false, 9 },
                    { 24, true, 1, 1, false, 10 },
                    { 25, true, 1, 1, false, 11 },
                    { 26, true, 1, 1, false, 12 },
                    { 27, true, 2, 0, false, 0 },
                    { 28, true, 2, 0, false, 1 },
                    { 29, true, 2, 0, false, 2 },
                    { 30, true, 2, 0, false, 3 },
                    { 31, true, 2, 0, false, 4 },
                    { 32, true, 2, 0, false, 5 },
                    { 33, true, 2, 0, false, 6 },
                    { 34, true, 2, 0, false, 7 },
                    { 35, true, 2, 0, false, 8 },
                    { 36, true, 2, 0, false, 9 },
                    { 37, true, 2, 0, false, 10 },
                    { 38, true, 2, 0, false, 11 },
                    { 39, true, 2, 0, false, 12 },
                    { 40, true, 3, 1, false, 0 },
                    { 41, true, 3, 1, false, 1 },
                    { 42, true, 3, 1, false, 2 },
                    { 43, true, 3, 1, false, 3 },
                    { 44, true, 3, 1, false, 4 },
                    { 45, true, 3, 1, false, 5 },
                    { 46, true, 3, 1, false, 6 },
                    { 47, true, 3, 1, false, 7 },
                    { 48, true, 3, 1, false, 8 },
                    { 49, true, 3, 1, false, 9 },
                    { 50, true, 3, 1, false, 10 },
                    { 51, true, 3, 1, false, 11 },
                    { 52, true, 3, 1, false, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 52);

            migrationBuilder.AddColumn<int>(
                name: "CardDeckId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
