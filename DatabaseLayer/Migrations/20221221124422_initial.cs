﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DatabaseLayer.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "Cards",
                columns: table => new
                {
                    Value = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false),
                    CardType = table.Column<int>(type: "int", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false),
                    ActiveCard = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => new { x.CardType, x.Value, x.Color });
                });

            migrationBuilder.CreateTable(
                name: "Hands",
                columns: table => new
                {
                    HandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActiveHand = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hands", x => x.HandId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardsCardDeckId = table.Column<int>(type: "int", nullable: false),
                    IsActiveGame = table.Column<bool>(type: "bit", nullable: false),
                    CurrentPlayerIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_CardDecks_CardsCardDeckId",
                        column: x => x.CardsCardDeckId,
                        principalTable: "CardDecks",
                        principalColumn: "CardDeckId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "CardHand",
                columns: table => new
                {
                    CardInHandsHandId = table.Column<int>(type: "int", nullable: false),
                    cardsInHandCardType = table.Column<int>(type: "int", nullable: false),
                    cardsInHandValue = table.Column<int>(type: "int", nullable: false),
                    cardsInHandColor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardHand", x => new { x.CardInHandsHandId, x.cardsInHandCardType, x.cardsInHandValue, x.cardsInHandColor });
                    table.ForeignKey(
                        name: "FK_CardHand_Cards_cardsInHandCardType_cardsInHandValue_cardsInHandColor",
                        columns: x => new { x.cardsInHandCardType, x.cardsInHandValue, x.cardsInHandColor },
                        principalTable: "Cards",
                        principalColumns: new[] { "CardType", "Value", "Color" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardHand_Hands_CardInHandsHandId",
                        column: x => x.CardInHandsHandId,
                        principalTable: "Hands",
                        principalColumn: "HandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamePlayer",
                columns: table => new
                {
                    GamesPlayedGameId = table.Column<int>(type: "int", nullable: false),
                    PlayersInGameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlayer", x => new { x.GamesPlayedGameId, x.PlayersInGameId });
                    table.ForeignKey(
                        name: "FK_GamePlayer_AspNetUsers_PlayersInGameId",
                        column: x => x.PlayersInGameId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlayer_Games_GamesPlayedGameId",
                        column: x => x.GamesPlayedGameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CardCardDeck_CardsCardType_CardsValue_CardsColor",
                table: "CardCardDeck",
                columns: new[] { "CardsCardType", "CardsValue", "CardsColor" });

            migrationBuilder.CreateIndex(
                name: "IX_CardHand_cardsInHandCardType_cardsInHandValue_cardsInHandColor",
                table: "CardHand",
                columns: new[] { "cardsInHandCardType", "cardsInHandValue", "cardsInHandColor" });

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayer_PlayersInGameId",
                table: "GamePlayer",
                column: "PlayersInGameId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_CardsCardDeckId",
                table: "Games",
                column: "CardsCardDeckId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CardCardDeck");

            migrationBuilder.DropTable(
                name: "CardHand");

            migrationBuilder.DropTable(
                name: "GamePlayer");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Hands");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "CardDecks");
        }
    }
}