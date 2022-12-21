using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DatabaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class removedCardKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardHand_Cards_cardsInHandCardId",
                table: "CardHand");

            migrationBuilder.DropForeignKey(
                name: "FK_CardInDecks_Cards_CardId",
                table: "CardInDecks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardHand",
                table: "CardHand");

            migrationBuilder.DropIndex(
                name: "IX_CardHand_cardsInHandCardId",
                table: "CardHand");

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyColumnType: "int",
                keyValue: 52);

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "cardsInHandCardId",
                table: "CardHand",
                newName: "cardsInHandColor");

            migrationBuilder.AddColumn<int>(
                name: "CardColor",
                table: "CardInDecks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CardType",
                table: "CardInDecks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CardValue",
                table: "CardInDecks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cardsInHandCardType",
                table: "CardHand",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cardsInHandValue",
                table: "CardHand",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                columns: new[] { "CardType", "Value", "Color" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardHand",
                table: "CardHand",
                columns: new[] { "CardInHandsHandId", "cardsInHandCardType", "cardsInHandValue", "cardsInHandColor" });

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

            migrationBuilder.CreateIndex(
                name: "IX_CardInDecks_CardType_CardValue_CardColor",
                table: "CardInDecks",
                columns: new[] { "CardType", "CardValue", "CardColor" });

            migrationBuilder.CreateIndex(
                name: "IX_CardHand_cardsInHandCardType_cardsInHandValue_cardsInHandColor",
                table: "CardHand",
                columns: new[] { "cardsInHandCardType", "cardsInHandValue", "cardsInHandColor" });

            migrationBuilder.AddForeignKey(
                name: "FK_CardHand_Cards_cardsInHandCardType_cardsInHandValue_cardsInHandColor",
                table: "CardHand",
                columns: new[] { "cardsInHandCardType", "cardsInHandValue", "cardsInHandColor" },
                principalTable: "Cards",
                principalColumns: new[] { "CardType", "Value", "Color" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardInDecks_Cards_CardType_CardValue_CardColor",
                table: "CardInDecks",
                columns: new[] { "CardType", "CardValue", "CardColor" },
                principalTable: "Cards",
                principalColumns: new[] { "CardType", "Value", "Color" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardHand_Cards_cardsInHandCardType_cardsInHandValue_cardsInHandColor",
                table: "CardHand");

            migrationBuilder.DropForeignKey(
                name: "FK_CardInDecks_Cards_CardType_CardValue_CardColor",
                table: "CardInDecks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_CardInDecks_CardType_CardValue_CardColor",
                table: "CardInDecks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardHand",
                table: "CardHand");

            migrationBuilder.DropIndex(
                name: "IX_CardHand_cardsInHandCardType_cardsInHandValue_cardsInHandColor",
                table: "CardHand");

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

            migrationBuilder.DropColumn(
                name: "CardColor",
                table: "CardInDecks");

            migrationBuilder.DropColumn(
                name: "CardType",
                table: "CardInDecks");

            migrationBuilder.DropColumn(
                name: "CardValue",
                table: "CardInDecks");

            migrationBuilder.DropColumn(
                name: "cardsInHandCardType",
                table: "CardHand");

            migrationBuilder.DropColumn(
                name: "cardsInHandValue",
                table: "CardHand");

            migrationBuilder.RenameColumn(
                name: "cardsInHandColor",
                table: "CardHand",
                newName: "cardsInHandCardId");

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                column: "CardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardHand",
                table: "CardHand",
                columns: new[] { "CardInHandsHandId", "cardsInHandCardId" });

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

            migrationBuilder.CreateIndex(
                name: "IX_CardHand_cardsInHandCardId",
                table: "CardHand",
                column: "cardsInHandCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardHand_Cards_cardsInHandCardId",
                table: "CardHand",
                column: "cardsInHandCardId",
                principalTable: "Cards",
                principalColumn: "CardId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardInDecks_Cards_CardId",
                table: "CardInDecks",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "CardId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
