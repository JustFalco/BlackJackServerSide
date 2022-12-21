using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class reAddedManyToManyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardCardDeck");

            migrationBuilder.CreateTable(
                name: "CardInDecks",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false),
                    CardDeckId = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_CardInDecks_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "CardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardInDecks_CardDeckId",
                table: "CardInDecks",
                column: "CardDeckId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardInDecks");

            migrationBuilder.CreateTable(
                name: "CardCardDeck",
                columns: table => new
                {
                    CardDecksCardDeckId = table.Column<int>(type: "int", nullable: false),
                    CardsCardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardCardDeck", x => new { x.CardDecksCardDeckId, x.CardsCardId });
                    table.ForeignKey(
                        name: "FK_CardCardDeck_CardDecks_CardDecksCardDeckId",
                        column: x => x.CardDecksCardDeckId,
                        principalTable: "CardDecks",
                        principalColumn: "CardDeckId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardCardDeck_Cards_CardsCardId",
                        column: x => x.CardsCardId,
                        principalTable: "Cards",
                        principalColumn: "CardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardCardDeck_CardsCardId",
                table: "CardCardDeck",
                column: "CardsCardId");
        }
    }
}
