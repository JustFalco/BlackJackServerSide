﻿// <auto-generated />
using System;
using DatabaseLayer.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseLayer.Migrations
{
    [DbContext(typeof(PlayerContext))]
    [Migration("20221221095340_changedDeckMechganism")]
    partial class changedDeckMechganism
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CardCardDeck", b =>
                {
                    b.Property<int>("CardDecksCardDeckId")
                        .HasColumnType("int");

                    b.Property<int>("CardsCardId")
                        .HasColumnType("int");

                    b.HasKey("CardDecksCardDeckId", "CardsCardId");

                    b.HasIndex("CardsCardId");

                    b.ToTable("CardCardDeck");
                });

            modelBuilder.Entity("CardHand", b =>
                {
                    b.Property<int>("CardInHandsHandId")
                        .HasColumnType("int");

                    b.Property<int>("cardsInHandCardId")
                        .HasColumnType("int");

                    b.HasKey("CardInHandsHandId", "cardsInHandCardId");

                    b.HasIndex("cardsInHandCardId");

                    b.ToTable("CardHand");
                });

            modelBuilder.Entity("DatabaseLayer.DAL.DomainModels.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardId"));

                    b.Property<bool>("ActiveCard")
                        .HasColumnType("bit");

                    b.Property<int>("CardType")
                        .HasColumnType("int");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<bool>("IsHidden")
                        .HasColumnType("bit");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("CardId");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            CardId = 1,
                            ActiveCard = true,
                            CardType = 0,
                            Color = 0,
                            IsHidden = false,
                            Value = 0
                        },
                        new
                        {
                            CardId = 2,
                            ActiveCard = true,
                            CardType = 0,
                            Color = 0,
                            IsHidden = false,
                            Value = 1
                        },
                        new
                        {
                            CardId = 3,
                            ActiveCard = true,
                            CardType = 0,
                            Color = 0,
                            IsHidden = false,
                            Value = 2
                        },
                        new
                        {
                            CardId = 4,
                            ActiveCard = true,
                            CardType = 0,
                            Color = 0,
                            IsHidden = false,
                            Value = 3
                        },
                        new
                        {
                            CardId = 5,
                            ActiveCard = true,
                            CardType = 0,
                            Color = 0,
                            IsHidden = false,
                            Value = 4
                        },
                        new
                        {
                            CardId = 6,
                            ActiveCard = true,
                            CardType = 0,
                            Color = 0,
                            IsHidden = false,
                            Value = 5
                        },
                        new
                        {
                            CardId = 7,
                            ActiveCard = true,
                            CardType = 0,
                            Color = 0,
                            IsHidden = false,
                            Value = 6
                        },
                        new
                        {
                            CardId = 8,
                            ActiveCard = true,
                            CardType = 0,
                            Color = 0,
                            IsHidden = false,
                            Value = 7
                        },
                        new
                        {
                            CardId = 9,
                            ActiveCard = true,
                            CardType = 0,
                            Color = 0,
                            IsHidden = false,
                            Value = 8
                        },
                        new
                        {
                            CardId = 10,
                            ActiveCard = true,
                            CardType = 0,
                            Color = 0,
                            IsHidden = false,
                            Value = 9
                        },
                        new
                        {
                            CardId = 11,
                            ActiveCard = true,
                            CardType = 0,
                            Color = 0,
                            IsHidden = false,
                            Value = 10
                        },
                        new
                        {
                            CardId = 12,
                            ActiveCard = true,
                            CardType = 0,
                            Color = 0,
                            IsHidden = false,
                            Value = 11
                        },
                        new
                        {
                            CardId = 13,
                            ActiveCard = true,
                            CardType = 0,
                            Color = 0,
                            IsHidden = false,
                            Value = 12
                        },
                        new
                        {
                            CardId = 14,
                            ActiveCard = true,
                            CardType = 1,
                            Color = 1,
                            IsHidden = false,
                            Value = 0
                        },
                        new
                        {
                            CardId = 15,
                            ActiveCard = true,
                            CardType = 1,
                            Color = 1,
                            IsHidden = false,
                            Value = 1
                        },
                        new
                        {
                            CardId = 16,
                            ActiveCard = true,
                            CardType = 1,
                            Color = 1,
                            IsHidden = false,
                            Value = 2
                        },
                        new
                        {
                            CardId = 17,
                            ActiveCard = true,
                            CardType = 1,
                            Color = 1,
                            IsHidden = false,
                            Value = 3
                        },
                        new
                        {
                            CardId = 18,
                            ActiveCard = true,
                            CardType = 1,
                            Color = 1,
                            IsHidden = false,
                            Value = 4
                        },
                        new
                        {
                            CardId = 19,
                            ActiveCard = true,
                            CardType = 1,
                            Color = 1,
                            IsHidden = false,
                            Value = 5
                        },
                        new
                        {
                            CardId = 20,
                            ActiveCard = true,
                            CardType = 1,
                            Color = 1,
                            IsHidden = false,
                            Value = 6
                        },
                        new
                        {
                            CardId = 21,
                            ActiveCard = true,
                            CardType = 1,
                            Color = 1,
                            IsHidden = false,
                            Value = 7
                        },
                        new
                        {
                            CardId = 22,
                            ActiveCard = true,
                            CardType = 1,
                            Color = 1,
                            IsHidden = false,
                            Value = 8
                        },
                        new
                        {
                            CardId = 23,
                            ActiveCard = true,
                            CardType = 1,
                            Color = 1,
                            IsHidden = false,
                            Value = 9
                        },
                        new
                        {
                            CardId = 24,
                            ActiveCard = true,
                            CardType = 1,
                            Color = 1,
                            IsHidden = false,
                            Value = 10
                        },
                        new
                        {
                            CardId = 25,
                            ActiveCard = true,
                            CardType = 1,
                            Color = 1,
                            IsHidden = false,
                            Value = 11
                        },
                        new
                        {
                            CardId = 26,
                            ActiveCard = true,
                            CardType = 1,
                            Color = 1,
                            IsHidden = false,
                            Value = 12
                        },
                        new
                        {
                            CardId = 27,
                            ActiveCard = true,
                            CardType = 2,
                            Color = 0,
                            IsHidden = false,
                            Value = 0
                        },
                        new
                        {
                            CardId = 28,
                            ActiveCard = true,
                            CardType = 2,
                            Color = 0,
                            IsHidden = false,
                            Value = 1
                        },
                        new
                        {
                            CardId = 29,
                            ActiveCard = true,
                            CardType = 2,
                            Color = 0,
                            IsHidden = false,
                            Value = 2
                        },
                        new
                        {
                            CardId = 30,
                            ActiveCard = true,
                            CardType = 2,
                            Color = 0,
                            IsHidden = false,
                            Value = 3
                        },
                        new
                        {
                            CardId = 31,
                            ActiveCard = true,
                            CardType = 2,
                            Color = 0,
                            IsHidden = false,
                            Value = 4
                        },
                        new
                        {
                            CardId = 32,
                            ActiveCard = true,
                            CardType = 2,
                            Color = 0,
                            IsHidden = false,
                            Value = 5
                        },
                        new
                        {
                            CardId = 33,
                            ActiveCard = true,
                            CardType = 2,
                            Color = 0,
                            IsHidden = false,
                            Value = 6
                        },
                        new
                        {
                            CardId = 34,
                            ActiveCard = true,
                            CardType = 2,
                            Color = 0,
                            IsHidden = false,
                            Value = 7
                        },
                        new
                        {
                            CardId = 35,
                            ActiveCard = true,
                            CardType = 2,
                            Color = 0,
                            IsHidden = false,
                            Value = 8
                        },
                        new
                        {
                            CardId = 36,
                            ActiveCard = true,
                            CardType = 2,
                            Color = 0,
                            IsHidden = false,
                            Value = 9
                        },
                        new
                        {
                            CardId = 37,
                            ActiveCard = true,
                            CardType = 2,
                            Color = 0,
                            IsHidden = false,
                            Value = 10
                        },
                        new
                        {
                            CardId = 38,
                            ActiveCard = true,
                            CardType = 2,
                            Color = 0,
                            IsHidden = false,
                            Value = 11
                        },
                        new
                        {
                            CardId = 39,
                            ActiveCard = true,
                            CardType = 2,
                            Color = 0,
                            IsHidden = false,
                            Value = 12
                        },
                        new
                        {
                            CardId = 40,
                            ActiveCard = true,
                            CardType = 3,
                            Color = 1,
                            IsHidden = false,
                            Value = 0
                        },
                        new
                        {
                            CardId = 41,
                            ActiveCard = true,
                            CardType = 3,
                            Color = 1,
                            IsHidden = false,
                            Value = 1
                        },
                        new
                        {
                            CardId = 42,
                            ActiveCard = true,
                            CardType = 3,
                            Color = 1,
                            IsHidden = false,
                            Value = 2
                        },
                        new
                        {
                            CardId = 43,
                            ActiveCard = true,
                            CardType = 3,
                            Color = 1,
                            IsHidden = false,
                            Value = 3
                        },
                        new
                        {
                            CardId = 44,
                            ActiveCard = true,
                            CardType = 3,
                            Color = 1,
                            IsHidden = false,
                            Value = 4
                        },
                        new
                        {
                            CardId = 45,
                            ActiveCard = true,
                            CardType = 3,
                            Color = 1,
                            IsHidden = false,
                            Value = 5
                        },
                        new
                        {
                            CardId = 46,
                            ActiveCard = true,
                            CardType = 3,
                            Color = 1,
                            IsHidden = false,
                            Value = 6
                        },
                        new
                        {
                            CardId = 47,
                            ActiveCard = true,
                            CardType = 3,
                            Color = 1,
                            IsHidden = false,
                            Value = 7
                        },
                        new
                        {
                            CardId = 48,
                            ActiveCard = true,
                            CardType = 3,
                            Color = 1,
                            IsHidden = false,
                            Value = 8
                        },
                        new
                        {
                            CardId = 49,
                            ActiveCard = true,
                            CardType = 3,
                            Color = 1,
                            IsHidden = false,
                            Value = 9
                        },
                        new
                        {
                            CardId = 50,
                            ActiveCard = true,
                            CardType = 3,
                            Color = 1,
                            IsHidden = false,
                            Value = 10
                        },
                        new
                        {
                            CardId = 51,
                            ActiveCard = true,
                            CardType = 3,
                            Color = 1,
                            IsHidden = false,
                            Value = 11
                        },
                        new
                        {
                            CardId = 52,
                            ActiveCard = true,
                            CardType = 3,
                            Color = 1,
                            IsHidden = false,
                            Value = 12
                        });
                });

            modelBuilder.Entity("DatabaseLayer.DAL.DomainModels.CardDeck", b =>
                {
                    b.Property<int>("CardDeckId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardDeckId"));

                    b.HasKey("CardDeckId");

                    b.ToTable("CardDecks");
                });

            modelBuilder.Entity("DatabaseLayer.DAL.DomainModels.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"));

                    b.Property<int>("CardsCardDeckId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentPlayerIndex")
                        .HasColumnType("int");

                    b.Property<bool>("IsActiveGame")
                        .HasColumnType("bit");

                    b.HasKey("GameId");

                    b.HasIndex("CardsCardDeckId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("DatabaseLayer.DAL.DomainModels.Hand", b =>
                {
                    b.Property<int>("HandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HandId"));

                    b.Property<bool>("IsActiveHand")
                        .HasColumnType("bit");

                    b.HasKey("HandId");

                    b.ToTable("Hands");
                });

            modelBuilder.Entity("DatabaseLayer.DAL.DomainModels.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("GamePlayer", b =>
                {
                    b.Property<int>("GamesPlayedGameId")
                        .HasColumnType("int");

                    b.Property<int>("PlayersInGameId")
                        .HasColumnType("int");

                    b.HasKey("GamesPlayedGameId", "PlayersInGameId");

                    b.HasIndex("PlayersInGameId");

                    b.ToTable("GamePlayer");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CardCardDeck", b =>
                {
                    b.HasOne("DatabaseLayer.DAL.DomainModels.CardDeck", null)
                        .WithMany()
                        .HasForeignKey("CardDecksCardDeckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseLayer.DAL.DomainModels.Card", null)
                        .WithMany()
                        .HasForeignKey("CardsCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CardHand", b =>
                {
                    b.HasOne("DatabaseLayer.DAL.DomainModels.Hand", null)
                        .WithMany()
                        .HasForeignKey("CardInHandsHandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseLayer.DAL.DomainModels.Card", null)
                        .WithMany()
                        .HasForeignKey("cardsInHandCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DatabaseLayer.DAL.DomainModels.Game", b =>
                {
                    b.HasOne("DatabaseLayer.DAL.DomainModels.CardDeck", "Cards")
                        .WithMany()
                        .HasForeignKey("CardsCardDeckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cards");
                });

            modelBuilder.Entity("GamePlayer", b =>
                {
                    b.HasOne("DatabaseLayer.DAL.DomainModels.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesPlayedGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseLayer.DAL.DomainModels.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayersInGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("DatabaseLayer.DAL.DomainModels.Player", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("DatabaseLayer.DAL.DomainModels.Player", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseLayer.DAL.DomainModels.Player", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("DatabaseLayer.DAL.DomainModels.Player", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
