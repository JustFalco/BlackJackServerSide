using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class masterDeckUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_CardDecks_CardsCardDeckId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "CardCardDeck");

            migrationBuilder.DropTable(
                name: "CardDecks");

            migrationBuilder.DropIndex(
                name: "IX_Games_CardsCardDeckId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "CardsCardDeckId",
                table: "Games");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CardsCardDeckId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CardDecks",
                columns: table => new
                {
                    CardDeckId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardDecks", x => x.CardDeckId);
                });

            migrationBuilder.CreateTable(
                name: "CardCardDeck",
                columns: table => new
                {
                    CardDecksCardDeckId = table.Column<int>(type: "int", nullable: false),
                    CardsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardCardDeck", x => new { x.CardDecksCardDeckId, x.CardsId });
                    table.ForeignKey(
                        name: "FK_CardCardDeck_CardDecks_CardDecksCardDeckId",
                        column: x => x.CardDecksCardDeckId,
                        principalTable: "CardDecks",
                        principalColumn: "CardDeckId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardCardDeck_Cards_CardsId",
                        column: x => x.CardsId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CardDecks",
                column: "CardDeckId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Games_CardsCardDeckId",
                table: "Games",
                column: "CardsCardDeckId");

            migrationBuilder.CreateIndex(
                name: "IX_CardCardDeck_CardsId",
                table: "CardCardDeck",
                column: "CardsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_CardDecks_CardsCardDeckId",
                table: "Games",
                column: "CardsCardDeckId",
                principalTable: "CardDecks",
                principalColumn: "CardDeckId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
