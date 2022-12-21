using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class tryBugFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardCardDeck");

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "CardDecks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CardDecks_CardId",
                table: "CardDecks",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_CardDecks_Cards_CardId",
                table: "CardDecks",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "CardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardDecks_Cards_CardId",
                table: "CardDecks");

            migrationBuilder.DropIndex(
                name: "IX_CardDecks_CardId",
                table: "CardDecks");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "CardDecks");

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
