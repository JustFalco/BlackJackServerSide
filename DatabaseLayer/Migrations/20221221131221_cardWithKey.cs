using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class cardWithKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardCardDeck_Cards_CardsCardType_CardsValue_CardsColor",
                table: "CardCardDeck");

            migrationBuilder.DropForeignKey(
                name: "FK_CardHand_Cards_cardsInHandCardType_cardsInHandValue_cardsInHandColor",
                table: "CardHand");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardHand",
                table: "CardHand");

            migrationBuilder.DropIndex(
                name: "IX_CardHand_cardsInHandCardType_cardsInHandValue_cardsInHandColor",
                table: "CardHand");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardCardDeck",
                table: "CardCardDeck");

            migrationBuilder.DropIndex(
                name: "IX_CardCardDeck_CardsCardType_CardsValue_CardsColor",
                table: "CardCardDeck");

            migrationBuilder.DropColumn(
                name: "cardsInHandCardType",
                table: "CardHand");

            migrationBuilder.DropColumn(
                name: "cardsInHandValue",
                table: "CardHand");

            migrationBuilder.DropColumn(
                name: "CardsCardType",
                table: "CardCardDeck");

            migrationBuilder.DropColumn(
                name: "CardsValue",
                table: "CardCardDeck");

            migrationBuilder.RenameColumn(
                name: "cardsInHandColor",
                table: "CardHand",
                newName: "cardsInHandId");

            migrationBuilder.RenameColumn(
                name: "CardsColor",
                table: "CardCardDeck",
                newName: "CardsId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardHand",
                table: "CardHand",
                columns: new[] { "CardInHandsHandId", "cardsInHandId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardCardDeck",
                table: "CardCardDeck",
                columns: new[] { "CardDecksCardDeckId", "CardsId" });

            migrationBuilder.CreateIndex(
                name: "IX_CardHand_cardsInHandId",
                table: "CardHand",
                column: "cardsInHandId");

            migrationBuilder.CreateIndex(
                name: "IX_CardCardDeck_CardsId",
                table: "CardCardDeck",
                column: "CardsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardCardDeck_Cards_CardsId",
                table: "CardCardDeck",
                column: "CardsId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardHand_Cards_cardsInHandId",
                table: "CardHand",
                column: "cardsInHandId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardCardDeck_Cards_CardsId",
                table: "CardCardDeck");

            migrationBuilder.DropForeignKey(
                name: "FK_CardHand_Cards_cardsInHandId",
                table: "CardHand");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardHand",
                table: "CardHand");

            migrationBuilder.DropIndex(
                name: "IX_CardHand_cardsInHandId",
                table: "CardHand");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CardCardDeck",
                table: "CardCardDeck");

            migrationBuilder.DropIndex(
                name: "IX_CardCardDeck_CardsId",
                table: "CardCardDeck");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "cardsInHandId",
                table: "CardHand",
                newName: "cardsInHandColor");

            migrationBuilder.RenameColumn(
                name: "CardsId",
                table: "CardCardDeck",
                newName: "CardsColor");

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

            migrationBuilder.AddColumn<int>(
                name: "CardsCardType",
                table: "CardCardDeck",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CardsValue",
                table: "CardCardDeck",
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

            migrationBuilder.AddPrimaryKey(
                name: "PK_CardCardDeck",
                table: "CardCardDeck",
                columns: new[] { "CardDecksCardDeckId", "CardsCardType", "CardsValue", "CardsColor" });

            migrationBuilder.CreateIndex(
                name: "IX_CardHand_cardsInHandCardType_cardsInHandValue_cardsInHandColor",
                table: "CardHand",
                columns: new[] { "cardsInHandCardType", "cardsInHandValue", "cardsInHandColor" });

            migrationBuilder.CreateIndex(
                name: "IX_CardCardDeck_CardsCardType_CardsValue_CardsColor",
                table: "CardCardDeck",
                columns: new[] { "CardsCardType", "CardsValue", "CardsColor" });

            migrationBuilder.AddForeignKey(
                name: "FK_CardCardDeck_Cards_CardsCardType_CardsValue_CardsColor",
                table: "CardCardDeck",
                columns: new[] { "CardsCardType", "CardsValue", "CardsColor" },
                principalTable: "Cards",
                principalColumns: new[] { "CardType", "Value", "Color" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardHand_Cards_cardsInHandCardType_cardsInHandValue_cardsInHandColor",
                table: "CardHand",
                columns: new[] { "cardsInHandCardType", "cardsInHandValue", "cardsInHandColor" },
                principalTable: "Cards",
                principalColumns: new[] { "CardType", "Value", "Color" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
