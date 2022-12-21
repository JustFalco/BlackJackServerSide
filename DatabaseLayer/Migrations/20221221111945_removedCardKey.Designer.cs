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
    [Migration("20221221111945_removedCardKey")]
    partial class removedCardKey
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CardHand", b =>
                {
                    b.Property<int>("CardInHandsHandId")
                        .HasColumnType("int");

                    b.Property<int>("cardsInHandCardType")
                        .HasColumnType("int");

                    b.Property<int>("cardsInHandValue")
                        .HasColumnType("int");

                    b.Property<int>("cardsInHandColor")
                        .HasColumnType("int");

                    b.HasKey("CardInHandsHandId", "cardsInHandCardType", "cardsInHandValue", "cardsInHandColor");

                    b.HasIndex("cardsInHandCardType", "cardsInHandValue", "cardsInHandColor");

                    b.ToTable("CardHand");
                });

            modelBuilder.Entity("DatabaseLayer.DAL.DomainModels.Card", b =>
                {
                    b.Property<int>("CardType")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<bool>("ActiveCard")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHidden")
                        .HasColumnType("bit");

                    b.HasKey("CardType", "Value", "Color");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            CardType = 0,
                            Value = 0,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 0,
                            Value = 1,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 0,
                            Value = 2,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 0,
                            Value = 3,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 0,
                            Value = 4,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 0,
                            Value = 5,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 0,
                            Value = 6,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 0,
                            Value = 7,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 0,
                            Value = 8,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 0,
                            Value = 9,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 0,
                            Value = 10,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 0,
                            Value = 11,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 0,
                            Value = 12,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 1,
                            Value = 0,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 1,
                            Value = 1,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 1,
                            Value = 2,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 1,
                            Value = 3,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 1,
                            Value = 4,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 1,
                            Value = 5,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 1,
                            Value = 6,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 1,
                            Value = 7,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 1,
                            Value = 8,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 1,
                            Value = 9,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 1,
                            Value = 10,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 1,
                            Value = 11,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 1,
                            Value = 12,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 2,
                            Value = 0,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 2,
                            Value = 1,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 2,
                            Value = 2,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 2,
                            Value = 3,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 2,
                            Value = 4,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 2,
                            Value = 5,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 2,
                            Value = 6,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 2,
                            Value = 7,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 2,
                            Value = 8,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 2,
                            Value = 9,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 2,
                            Value = 10,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 2,
                            Value = 11,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 2,
                            Value = 12,
                            Color = 0,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 3,
                            Value = 0,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 3,
                            Value = 1,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 3,
                            Value = 2,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 3,
                            Value = 3,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 3,
                            Value = 4,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 3,
                            Value = 5,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 3,
                            Value = 6,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 3,
                            Value = 7,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 3,
                            Value = 8,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 3,
                            Value = 9,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 3,
                            Value = 10,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 3,
                            Value = 11,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
                        },
                        new
                        {
                            CardType = 3,
                            Value = 12,
                            Color = 1,
                            ActiveCard = true,
                            IsHidden = false
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

            modelBuilder.Entity("DatabaseLayer.DAL.DomainModels.CardInCardDeck", b =>
                {
                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<int>("CardDeckId")
                        .HasColumnType("int");

                    b.Property<int>("CardColor")
                        .HasColumnType("int");

                    b.Property<int>("CardType")
                        .HasColumnType("int");

                    b.Property<int>("CardValue")
                        .HasColumnType("int");

                    b.HasKey("CardId", "CardDeckId");

                    b.HasIndex("CardDeckId");

                    b.HasIndex("CardType", "CardValue", "CardColor");

                    b.ToTable("CardInDecks");
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

            modelBuilder.Entity("CardHand", b =>
                {
                    b.HasOne("DatabaseLayer.DAL.DomainModels.Hand", null)
                        .WithMany()
                        .HasForeignKey("CardInHandsHandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseLayer.DAL.DomainModels.Card", null)
                        .WithMany()
                        .HasForeignKey("cardsInHandCardType", "cardsInHandValue", "cardsInHandColor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DatabaseLayer.DAL.DomainModels.CardInCardDeck", b =>
                {
                    b.HasOne("DatabaseLayer.DAL.DomainModels.CardDeck", "CardDeck")
                        .WithMany()
                        .HasForeignKey("CardDeckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseLayer.DAL.DomainModels.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardType", "CardValue", "CardColor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("CardDeck");
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
