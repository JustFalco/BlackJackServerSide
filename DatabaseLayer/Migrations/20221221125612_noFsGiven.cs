using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DatabaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class noFsGiven : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 0, 0, 0 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 0, 0, 1 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 0, 0, 2 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 0, 0, 3 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 0, 0, 4 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 0, 0, 5 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 0, 0, 6 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 0, 0, 7 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 0, 0, 8 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 0, 0, 9 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 0, 0, 10 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 0, 0, 11 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 0, 0, 12 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 1, 1, 0 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 1, 1, 2 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 1, 1, 3 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 1, 1, 4 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 1, 1, 5 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 1, 1, 6 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 1, 1, 7 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 1, 1, 8 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 1, 1, 9 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 1, 1, 10 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 1, 1, 11 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 1, 1, 12 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 2, 0, 0 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 2, 0, 1 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 2, 0, 2 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 2, 0, 3 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 2, 0, 4 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 2, 0, 5 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 2, 0, 6 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 2, 0, 7 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 2, 0, 8 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 2, 0, 9 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 2, 0, 10 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 2, 0, 11 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 2, 0, 12 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 3, 1, 0 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 3, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 3, 1, 2 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 3, 1, 3 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 3, 1, 4 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 3, 1, 5 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 3, 1, 6 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 3, 1, 7 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 3, 1, 8 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 3, 1, 9 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 3, 1, 10 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 3, 1, 11 });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumns: new[] { "CardType", "Color", "Value" },
                keyValues: new object[] { 3, 1, 12 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardType", "Color", "Value", "ActiveCard", "IsHidden" },
                values: new object[,]
                {
                    { 0, 0, 0, true, false },
                    { 0, 0, 1, true, false },
                    { 0, 0, 2, true, false },
                    { 0, 0, 3, true, false },
                    { 0, 0, 4, true, false },
                    { 0, 0, 5, true, false },
                    { 0, 0, 6, true, false },
                    { 0, 0, 7, true, false },
                    { 0, 0, 8, true, false },
                    { 0, 0, 9, true, false },
                    { 0, 0, 10, true, false },
                    { 0, 0, 11, true, false },
                    { 0, 0, 12, true, false },
                    { 1, 1, 0, true, false },
                    { 1, 1, 1, true, false },
                    { 1, 1, 2, true, false },
                    { 1, 1, 3, true, false },
                    { 1, 1, 4, true, false },
                    { 1, 1, 5, true, false },
                    { 1, 1, 6, true, false },
                    { 1, 1, 7, true, false },
                    { 1, 1, 8, true, false },
                    { 1, 1, 9, true, false },
                    { 1, 1, 10, true, false },
                    { 1, 1, 11, true, false },
                    { 1, 1, 12, true, false },
                    { 2, 0, 0, true, false },
                    { 2, 0, 1, true, false },
                    { 2, 0, 2, true, false },
                    { 2, 0, 3, true, false },
                    { 2, 0, 4, true, false },
                    { 2, 0, 5, true, false },
                    { 2, 0, 6, true, false },
                    { 2, 0, 7, true, false },
                    { 2, 0, 8, true, false },
                    { 2, 0, 9, true, false },
                    { 2, 0, 10, true, false },
                    { 2, 0, 11, true, false },
                    { 2, 0, 12, true, false },
                    { 3, 1, 0, true, false },
                    { 3, 1, 1, true, false },
                    { 3, 1, 2, true, false },
                    { 3, 1, 3, true, false },
                    { 3, 1, 4, true, false },
                    { 3, 1, 5, true, false },
                    { 3, 1, 6, true, false },
                    { 3, 1, 7, true, false },
                    { 3, 1, 8, true, false },
                    { 3, 1, 9, true, false },
                    { 3, 1, 10, true, false },
                    { 3, 1, 11, true, false },
                    { 3, 1, 12, true, false }
                });
        }
    }
}
