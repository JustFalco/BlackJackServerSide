using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class reinstatedPrefChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
    }
}
