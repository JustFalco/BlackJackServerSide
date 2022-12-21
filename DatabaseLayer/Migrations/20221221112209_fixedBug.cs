using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class fixedBug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardInDecks");

            migrationBuilder.CreateTable(
                name: "CardCardDeck",
                columns: table => new
                {
                    CardDecksCardDeckId = table.Column<int>(type: "int", nullable: false),
                    CardsCardType = table.Column<int>(type: "int", nullable: false),
                    CardsValue = table.Column<int>(type: "int", nullable: false),
                    CardsColor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardCardDeck", x => new { x.CardDecksCardDeckId, x.CardsCardType, x.CardsValue, x.CardsColor });
                    table.ForeignKey(
                        name: "FK_CardCardDeck_CardDecks_CardDecksCardDeckId",
                        column: x => x.CardDecksCardDeckId,
                        principalTable: "CardDecks",
                        principalColumn: "CardDeckId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardCardDeck_Cards_CardsCardType_CardsValue_CardsColor",
                        columns: x => new { x.CardsCardType, x.CardsValue, x.CardsColor },
                        principalTable: "Cards",
                        principalColumns: new[] { "CardType", "Value", "Color" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardCardDeck_CardsCardType_CardsValue_CardsColor",
                table: "CardCardDeck",
                columns: new[] { "CardsCardType", "CardsValue", "CardsColor" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardCardDeck");

            migrationBuilder.CreateTable(
                name: "CardInDecks",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false),
                    CardDeckId = table.Column<int>(type: "int", nullable: false),
                    CardType = table.Column<int>(type: "int", nullable: false),
                    CardValue = table.Column<int>(type: "int", nullable: false),
                    CardColor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardInDecks", x => new { x.CardId, x.CardDeckId });
                    table.ForeignKey(
                        name: "FK_CardInDecks_CardDecks_CardDeckId",
                        column: x => x.CardDeckId,
                        principalTable: "CardDecks",
                        principalColumn: "CardDeckId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardInDecks_Cards_CardType_CardValue_CardColor",
                        columns: x => new { x.CardType, x.CardValue, x.CardColor },
                        principalTable: "Cards",
                        principalColumns: new[] { "CardType", "Value", "Color" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardInDecks_CardDeckId",
                table: "CardInDecks",
                column: "CardDeckId");

            migrationBuilder.CreateIndex(
                name: "IX_CardInDecks_CardType_CardValue_CardColor",
                table: "CardInDecks",
                columns: new[] { "CardType", "CardValue", "CardColor" });
        }
    }
}
