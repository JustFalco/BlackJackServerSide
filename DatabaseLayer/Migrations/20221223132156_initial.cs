using System;
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
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false),
                    CardType = table.Column<int>(type: "int", nullable: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActiveGame = table.Column<bool>(type: "bit", nullable: false),
                    CurrentPlayerIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
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

            migrationBuilder.CreateTable(
                name: "CardHand",
                columns: table => new
                {
                    CardInHandsHandId = table.Column<int>(type: "int", nullable: false),
                    cardsInHandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardHand", x => new { x.CardInHandsHandId, x.cardsInHandId });
                    table.ForeignKey(
                        name: "FK_CardHand_Cards_cardsInHandId",
                        column: x => x.cardsInHandId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardHand_Hands_CardInHandsHandId",
                        column: x => x.CardInHandsHandId,
                        principalTable: "Hands",
                        principalColumn: "HandId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardType", "Color", "IsHidden", "Value" },
                values: new object[,]
                {
                    { 1, 0, 0, false, 0 },
                    { 2, 0, 0, false, 1 },
                    { 3, 0, 0, false, 2 },
                    { 4, 0, 0, false, 3 },
                    { 5, 0, 0, false, 4 },
                    { 6, 0, 0, false, 5 },
                    { 7, 0, 0, false, 6 },
                    { 8, 0, 0, false, 7 },
                    { 9, 0, 0, false, 8 },
                    { 10, 0, 0, false, 9 },
                    { 11, 0, 0, false, 10 },
                    { 12, 0, 0, false, 11 },
                    { 13, 0, 0, false, 12 },
                    { 14, 1, 1, false, 0 },
                    { 15, 1, 1, false, 1 },
                    { 16, 1, 1, false, 2 },
                    { 17, 1, 1, false, 3 },
                    { 18, 1, 1, false, 4 },
                    { 19, 1, 1, false, 5 },
                    { 20, 1, 1, false, 6 },
                    { 21, 1, 1, false, 7 },
                    { 22, 1, 1, false, 8 },
                    { 23, 1, 1, false, 9 },
                    { 24, 1, 1, false, 10 },
                    { 25, 1, 1, false, 11 },
                    { 26, 1, 1, false, 12 },
                    { 27, 2, 0, false, 0 },
                    { 28, 2, 0, false, 1 },
                    { 29, 2, 0, false, 2 },
                    { 30, 2, 0, false, 3 },
                    { 31, 2, 0, false, 4 },
                    { 32, 2, 0, false, 5 },
                    { 33, 2, 0, false, 6 },
                    { 34, 2, 0, false, 7 },
                    { 35, 2, 0, false, 8 },
                    { 36, 2, 0, false, 9 },
                    { 37, 2, 0, false, 10 },
                    { 38, 2, 0, false, 11 },
                    { 39, 2, 0, false, 12 },
                    { 40, 3, 1, false, 0 },
                    { 41, 3, 1, false, 1 },
                    { 42, 3, 1, false, 2 },
                    { 43, 3, 1, false, 3 },
                    { 44, 3, 1, false, 4 },
                    { 45, 3, 1, false, 5 },
                    { 46, 3, 1, false, 6 },
                    { 47, 3, 1, false, 7 },
                    { 48, 3, 1, false, 8 },
                    { 49, 3, 1, false, 9 },
                    { 50, 3, 1, false, 10 },
                    { 51, 3, 1, false, 11 },
                    { 52, 3, 1, false, 12 },
                    { 53, 0, 0, false, 0 },
                    { 54, 0, 0, false, 1 },
                    { 55, 0, 0, false, 2 },
                    { 56, 0, 0, false, 3 },
                    { 57, 0, 0, false, 4 },
                    { 58, 0, 0, false, 5 },
                    { 59, 0, 0, false, 6 },
                    { 60, 0, 0, false, 7 },
                    { 61, 0, 0, false, 8 },
                    { 62, 0, 0, false, 9 },
                    { 63, 0, 0, false, 10 },
                    { 64, 0, 0, false, 11 },
                    { 65, 0, 0, false, 12 },
                    { 66, 1, 1, false, 0 },
                    { 67, 1, 1, false, 1 },
                    { 68, 1, 1, false, 2 },
                    { 69, 1, 1, false, 3 },
                    { 70, 1, 1, false, 4 },
                    { 71, 1, 1, false, 5 },
                    { 72, 1, 1, false, 6 },
                    { 73, 1, 1, false, 7 },
                    { 74, 1, 1, false, 8 },
                    { 75, 1, 1, false, 9 },
                    { 76, 1, 1, false, 10 },
                    { 77, 1, 1, false, 11 },
                    { 78, 1, 1, false, 12 },
                    { 79, 2, 0, false, 0 },
                    { 80, 2, 0, false, 1 },
                    { 81, 2, 0, false, 2 },
                    { 82, 2, 0, false, 3 },
                    { 83, 2, 0, false, 4 },
                    { 84, 2, 0, false, 5 },
                    { 85, 2, 0, false, 6 },
                    { 86, 2, 0, false, 7 },
                    { 87, 2, 0, false, 8 },
                    { 88, 2, 0, false, 9 },
                    { 89, 2, 0, false, 10 },
                    { 90, 2, 0, false, 11 },
                    { 91, 2, 0, false, 12 },
                    { 92, 3, 1, false, 0 },
                    { 93, 3, 1, false, 1 },
                    { 94, 3, 1, false, 2 },
                    { 95, 3, 1, false, 3 },
                    { 96, 3, 1, false, 4 },
                    { 97, 3, 1, false, 5 },
                    { 98, 3, 1, false, 6 },
                    { 99, 3, 1, false, 7 },
                    { 100, 3, 1, false, 8 },
                    { 101, 3, 1, false, 9 },
                    { 102, 3, 1, false, 10 },
                    { 103, 3, 1, false, 11 },
                    { 104, 3, 1, false, 12 },
                    { 105, 0, 0, false, 0 },
                    { 106, 0, 0, false, 1 },
                    { 107, 0, 0, false, 2 },
                    { 108, 0, 0, false, 3 },
                    { 109, 0, 0, false, 4 },
                    { 110, 0, 0, false, 5 },
                    { 111, 0, 0, false, 6 },
                    { 112, 0, 0, false, 7 },
                    { 113, 0, 0, false, 8 },
                    { 114, 0, 0, false, 9 },
                    { 115, 0, 0, false, 10 },
                    { 116, 0, 0, false, 11 },
                    { 117, 0, 0, false, 12 },
                    { 118, 1, 1, false, 0 },
                    { 119, 1, 1, false, 1 },
                    { 120, 1, 1, false, 2 },
                    { 121, 1, 1, false, 3 },
                    { 122, 1, 1, false, 4 },
                    { 123, 1, 1, false, 5 },
                    { 124, 1, 1, false, 6 },
                    { 125, 1, 1, false, 7 },
                    { 126, 1, 1, false, 8 },
                    { 127, 1, 1, false, 9 },
                    { 128, 1, 1, false, 10 },
                    { 129, 1, 1, false, 11 },
                    { 130, 1, 1, false, 12 },
                    { 131, 2, 0, false, 0 },
                    { 132, 2, 0, false, 1 },
                    { 133, 2, 0, false, 2 },
                    { 134, 2, 0, false, 3 },
                    { 135, 2, 0, false, 4 },
                    { 136, 2, 0, false, 5 },
                    { 137, 2, 0, false, 6 },
                    { 138, 2, 0, false, 7 },
                    { 139, 2, 0, false, 8 },
                    { 140, 2, 0, false, 9 },
                    { 141, 2, 0, false, 10 },
                    { 142, 2, 0, false, 11 },
                    { 143, 2, 0, false, 12 },
                    { 144, 3, 1, false, 0 },
                    { 145, 3, 1, false, 1 },
                    { 146, 3, 1, false, 2 },
                    { 147, 3, 1, false, 3 },
                    { 148, 3, 1, false, 4 },
                    { 149, 3, 1, false, 5 },
                    { 150, 3, 1, false, 6 },
                    { 151, 3, 1, false, 7 },
                    { 152, 3, 1, false, 8 },
                    { 153, 3, 1, false, 9 },
                    { 154, 3, 1, false, 10 },
                    { 155, 3, 1, false, 11 },
                    { 156, 3, 1, false, 12 },
                    { 157, 0, 0, false, 0 },
                    { 158, 0, 0, false, 1 },
                    { 159, 0, 0, false, 2 },
                    { 160, 0, 0, false, 3 },
                    { 161, 0, 0, false, 4 },
                    { 162, 0, 0, false, 5 },
                    { 163, 0, 0, false, 6 },
                    { 164, 0, 0, false, 7 },
                    { 165, 0, 0, false, 8 },
                    { 166, 0, 0, false, 9 },
                    { 167, 0, 0, false, 10 },
                    { 168, 0, 0, false, 11 },
                    { 169, 0, 0, false, 12 },
                    { 170, 1, 1, false, 0 },
                    { 171, 1, 1, false, 1 },
                    { 172, 1, 1, false, 2 },
                    { 173, 1, 1, false, 3 },
                    { 174, 1, 1, false, 4 },
                    { 175, 1, 1, false, 5 },
                    { 176, 1, 1, false, 6 },
                    { 177, 1, 1, false, 7 },
                    { 178, 1, 1, false, 8 },
                    { 179, 1, 1, false, 9 },
                    { 180, 1, 1, false, 10 },
                    { 181, 1, 1, false, 11 },
                    { 182, 1, 1, false, 12 },
                    { 183, 2, 0, false, 0 },
                    { 184, 2, 0, false, 1 },
                    { 185, 2, 0, false, 2 },
                    { 186, 2, 0, false, 3 },
                    { 187, 2, 0, false, 4 },
                    { 188, 2, 0, false, 5 },
                    { 189, 2, 0, false, 6 },
                    { 190, 2, 0, false, 7 },
                    { 191, 2, 0, false, 8 },
                    { 192, 2, 0, false, 9 },
                    { 193, 2, 0, false, 10 },
                    { 194, 2, 0, false, 11 },
                    { 195, 2, 0, false, 12 },
                    { 196, 3, 1, false, 0 },
                    { 197, 3, 1, false, 1 },
                    { 198, 3, 1, false, 2 },
                    { 199, 3, 1, false, 3 },
                    { 200, 3, 1, false, 4 },
                    { 201, 3, 1, false, 5 },
                    { 202, 3, 1, false, 6 },
                    { 203, 3, 1, false, 7 },
                    { 204, 3, 1, false, 8 },
                    { 205, 3, 1, false, 9 },
                    { 206, 3, 1, false, 10 },
                    { 207, 3, 1, false, 11 },
                    { 208, 3, 1, false, 12 },
                    { 209, 0, 0, false, 0 },
                    { 210, 0, 0, false, 1 },
                    { 211, 0, 0, false, 2 },
                    { 212, 0, 0, false, 3 },
                    { 213, 0, 0, false, 4 },
                    { 214, 0, 0, false, 5 },
                    { 215, 0, 0, false, 6 },
                    { 216, 0, 0, false, 7 },
                    { 217, 0, 0, false, 8 },
                    { 218, 0, 0, false, 9 },
                    { 219, 0, 0, false, 10 },
                    { 220, 0, 0, false, 11 },
                    { 221, 0, 0, false, 12 },
                    { 222, 1, 1, false, 0 },
                    { 223, 1, 1, false, 1 },
                    { 224, 1, 1, false, 2 },
                    { 225, 1, 1, false, 3 },
                    { 226, 1, 1, false, 4 },
                    { 227, 1, 1, false, 5 },
                    { 228, 1, 1, false, 6 },
                    { 229, 1, 1, false, 7 },
                    { 230, 1, 1, false, 8 },
                    { 231, 1, 1, false, 9 },
                    { 232, 1, 1, false, 10 },
                    { 233, 1, 1, false, 11 },
                    { 234, 1, 1, false, 12 },
                    { 235, 2, 0, false, 0 },
                    { 236, 2, 0, false, 1 },
                    { 237, 2, 0, false, 2 },
                    { 238, 2, 0, false, 3 },
                    { 239, 2, 0, false, 4 },
                    { 240, 2, 0, false, 5 },
                    { 241, 2, 0, false, 6 },
                    { 242, 2, 0, false, 7 },
                    { 243, 2, 0, false, 8 },
                    { 244, 2, 0, false, 9 },
                    { 245, 2, 0, false, 10 },
                    { 246, 2, 0, false, 11 },
                    { 247, 2, 0, false, 12 },
                    { 248, 3, 1, false, 0 },
                    { 249, 3, 1, false, 1 },
                    { 250, 3, 1, false, 2 },
                    { 251, 3, 1, false, 3 },
                    { 252, 3, 1, false, 4 },
                    { 253, 3, 1, false, 5 },
                    { 254, 3, 1, false, 6 },
                    { 255, 3, 1, false, 7 },
                    { 256, 3, 1, false, 8 },
                    { 257, 3, 1, false, 9 },
                    { 258, 3, 1, false, 10 },
                    { 259, 3, 1, false, 11 },
                    { 260, 3, 1, false, 12 },
                    { 261, 0, 0, false, 0 },
                    { 262, 0, 0, false, 1 },
                    { 263, 0, 0, false, 2 },
                    { 264, 0, 0, false, 3 },
                    { 265, 0, 0, false, 4 },
                    { 266, 0, 0, false, 5 },
                    { 267, 0, 0, false, 6 },
                    { 268, 0, 0, false, 7 },
                    { 269, 0, 0, false, 8 },
                    { 270, 0, 0, false, 9 },
                    { 271, 0, 0, false, 10 },
                    { 272, 0, 0, false, 11 },
                    { 273, 0, 0, false, 12 },
                    { 274, 1, 1, false, 0 },
                    { 275, 1, 1, false, 1 },
                    { 276, 1, 1, false, 2 },
                    { 277, 1, 1, false, 3 },
                    { 278, 1, 1, false, 4 },
                    { 279, 1, 1, false, 5 },
                    { 280, 1, 1, false, 6 },
                    { 281, 1, 1, false, 7 },
                    { 282, 1, 1, false, 8 },
                    { 283, 1, 1, false, 9 },
                    { 284, 1, 1, false, 10 },
                    { 285, 1, 1, false, 11 },
                    { 286, 1, 1, false, 12 },
                    { 287, 2, 0, false, 0 },
                    { 288, 2, 0, false, 1 },
                    { 289, 2, 0, false, 2 },
                    { 290, 2, 0, false, 3 },
                    { 291, 2, 0, false, 4 },
                    { 292, 2, 0, false, 5 },
                    { 293, 2, 0, false, 6 },
                    { 294, 2, 0, false, 7 },
                    { 295, 2, 0, false, 8 },
                    { 296, 2, 0, false, 9 },
                    { 297, 2, 0, false, 10 },
                    { 298, 2, 0, false, 11 },
                    { 299, 2, 0, false, 12 },
                    { 300, 3, 1, false, 0 },
                    { 301, 3, 1, false, 1 },
                    { 302, 3, 1, false, 2 },
                    { 303, 3, 1, false, 3 },
                    { 304, 3, 1, false, 4 },
                    { 305, 3, 1, false, 5 },
                    { 306, 3, 1, false, 6 },
                    { 307, 3, 1, false, 7 },
                    { 308, 3, 1, false, 8 },
                    { 309, 3, 1, false, 9 },
                    { 310, 3, 1, false, 10 },
                    { 311, 3, 1, false, 11 },
                    { 312, 3, 1, false, 12 },
                    { 313, 0, 0, false, 0 },
                    { 314, 0, 0, false, 1 },
                    { 315, 0, 0, false, 2 },
                    { 316, 0, 0, false, 3 },
                    { 317, 0, 0, false, 4 },
                    { 318, 0, 0, false, 5 },
                    { 319, 0, 0, false, 6 },
                    { 320, 0, 0, false, 7 },
                    { 321, 0, 0, false, 8 },
                    { 322, 0, 0, false, 9 },
                    { 323, 0, 0, false, 10 },
                    { 324, 0, 0, false, 11 },
                    { 325, 0, 0, false, 12 },
                    { 326, 1, 1, false, 0 },
                    { 327, 1, 1, false, 1 },
                    { 328, 1, 1, false, 2 },
                    { 329, 1, 1, false, 3 },
                    { 330, 1, 1, false, 4 },
                    { 331, 1, 1, false, 5 },
                    { 332, 1, 1, false, 6 },
                    { 333, 1, 1, false, 7 },
                    { 334, 1, 1, false, 8 },
                    { 335, 1, 1, false, 9 },
                    { 336, 1, 1, false, 10 },
                    { 337, 1, 1, false, 11 },
                    { 338, 1, 1, false, 12 },
                    { 339, 2, 0, false, 0 },
                    { 340, 2, 0, false, 1 },
                    { 341, 2, 0, false, 2 },
                    { 342, 2, 0, false, 3 },
                    { 343, 2, 0, false, 4 },
                    { 344, 2, 0, false, 5 },
                    { 345, 2, 0, false, 6 },
                    { 346, 2, 0, false, 7 },
                    { 347, 2, 0, false, 8 },
                    { 348, 2, 0, false, 9 },
                    { 349, 2, 0, false, 10 },
                    { 350, 2, 0, false, 11 },
                    { 351, 2, 0, false, 12 },
                    { 352, 3, 1, false, 0 },
                    { 353, 3, 1, false, 1 },
                    { 354, 3, 1, false, 2 },
                    { 355, 3, 1, false, 3 },
                    { 356, 3, 1, false, 4 },
                    { 357, 3, 1, false, 5 },
                    { 358, 3, 1, false, 6 },
                    { 359, 3, 1, false, 7 },
                    { 360, 3, 1, false, 8 },
                    { 361, 3, 1, false, 9 },
                    { 362, 3, 1, false, 10 },
                    { 363, 3, 1, false, 11 },
                    { 364, 3, 1, false, 12 },
                    { 365, 0, 0, false, 0 },
                    { 366, 0, 0, false, 1 },
                    { 367, 0, 0, false, 2 },
                    { 368, 0, 0, false, 3 },
                    { 369, 0, 0, false, 4 },
                    { 370, 0, 0, false, 5 },
                    { 371, 0, 0, false, 6 },
                    { 372, 0, 0, false, 7 },
                    { 373, 0, 0, false, 8 },
                    { 374, 0, 0, false, 9 },
                    { 375, 0, 0, false, 10 },
                    { 376, 0, 0, false, 11 },
                    { 377, 0, 0, false, 12 },
                    { 378, 1, 1, false, 0 },
                    { 379, 1, 1, false, 1 },
                    { 380, 1, 1, false, 2 },
                    { 381, 1, 1, false, 3 },
                    { 382, 1, 1, false, 4 },
                    { 383, 1, 1, false, 5 },
                    { 384, 1, 1, false, 6 },
                    { 385, 1, 1, false, 7 },
                    { 386, 1, 1, false, 8 },
                    { 387, 1, 1, false, 9 },
                    { 388, 1, 1, false, 10 },
                    { 389, 1, 1, false, 11 },
                    { 390, 1, 1, false, 12 },
                    { 391, 2, 0, false, 0 },
                    { 392, 2, 0, false, 1 },
                    { 393, 2, 0, false, 2 },
                    { 394, 2, 0, false, 3 },
                    { 395, 2, 0, false, 4 },
                    { 396, 2, 0, false, 5 },
                    { 397, 2, 0, false, 6 },
                    { 398, 2, 0, false, 7 },
                    { 399, 2, 0, false, 8 },
                    { 400, 2, 0, false, 9 },
                    { 401, 2, 0, false, 10 },
                    { 402, 2, 0, false, 11 },
                    { 403, 2, 0, false, 12 },
                    { 404, 3, 1, false, 0 },
                    { 405, 3, 1, false, 1 },
                    { 406, 3, 1, false, 2 },
                    { 407, 3, 1, false, 3 },
                    { 408, 3, 1, false, 4 },
                    { 409, 3, 1, false, 5 },
                    { 410, 3, 1, false, 6 },
                    { 411, 3, 1, false, 7 },
                    { 412, 3, 1, false, 8 },
                    { 413, 3, 1, false, 9 },
                    { 414, 3, 1, false, 10 },
                    { 415, 3, 1, false, 11 },
                    { 416, 3, 1, false, 12 }
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
                name: "IX_CardHand_cardsInHandId",
                table: "CardHand",
                column: "cardsInHandId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayer_PlayersInGameId",
                table: "GamePlayer",
                column: "PlayersInGameId");
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
        }
    }
}
