using Xunit;
using DatabaseLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.Exeptions;
using Assert = Xunit.Assert;

namespace DatabaseLayer.Repositories.Tests
{
    public class PlayerRepositoryTests : IDisposable
    {
        private PlayerRepository playerRepository;
        private GameContext playerContext;
        private string connectionString = $"Server=localhost;Port=3307;Database=BlackJackGameTestDB;Uid=root;Pwd=SecretPassword@01;";

        public PlayerRepositoryTests()
        {
            var builder = new DbContextOptionsBuilder<GameContext>();
            builder.UseInMemoryDatabase(databaseName: "TestDatabase");
            DbContextOptions<GameContext> options = builder.Options;
            playerContext = new GameContext(options);
            playerRepository = new PlayerRepository(playerContext);
        }

        public Player playerBuilder()
        {
            Player testPlayer = new Player();
            testPlayer.Email = "falco@wolkorte.nl";
            testPlayer.Name = "falco";

            return testPlayer;
        }

        [Fact()]
        //[DoNotParallelize]
        public void getAllPlayersTest_WithThreePlayersInDatabase_ShouldReturnListOfThreePlayers()
        {
            //arrange
            playerContext.Players.Add(playerBuilder());
            playerContext.Players.Add(playerBuilder());
            playerContext.Players.Add(playerBuilder());
            playerContext.SaveChanges();

            //act 
            int NumberOfplayersInDB = playerRepository.getAllPlayers().Count;

            //assert
            Assert.Equal(3, NumberOfplayersInDB);
        }

        [Fact()]
        public void getAllPlayersTest_WithNoPlayersInDatabase_ShouldReturnEmptyList()
        {
            Assert.Empty(playerRepository.getAllPlayers());
        }

        [Fact()]
        public void AddPlayerToDBTest_AddTwoNormalPlayersToDB_ShouldHaveTwoPlayersInDatabase()
        {
            //Arrange
            Player p1 = playerBuilder();
            Player p2 = playerBuilder();
            p2.Email = "falco@wolkorte2.nl";


            //Act
            playerRepository.AddPlayerToDB(p1);
            playerRepository.AddPlayerToDB(p2);

            //Assert
            Assert.Equal(2, playerContext.Players.ToList().Count);
        }

        [Fact()]
        public void AddPlayerToDBTest_AddEmptyPlayerToDB_ShouldThrowError()
        {
            //Arrange
            Player p1 = new Player();

            //Assert
            Assert.Throws<ArgumentNullException>(() => playerRepository.AddPlayerToDB(p1));
        }

        [Fact()]
        public void AddPlayerToDBTest_AddDuplicateEmailToDatabase_ShouldThrowError()
        {
            //Arrange
            Player p1 = playerBuilder();
            Player p2 = playerBuilder();


            //Act
            playerRepository.AddPlayerToDB(p1);
            

            //Assert
            Assert.Throws<DuplicateObjectInDBExeption>(() => playerRepository.AddPlayerToDB(p2));
        }

        [Fact()]
        public void GetPlayerByEmailTest_GetNormalPlayerFromDatabase_ShouldReturnSinglePlayer()
        {
            //Arrange
            Player p1 = playerBuilder();
            playerContext.Players.Add(p1);
            playerContext.SaveChanges();

            //Act
            Player playerFromDB = playerRepository.GetPlayerByEmail("falco@wolkorte.nl");

            //Assert
            Assert.Equal(p1.PlayerId, playerFromDB.PlayerId);
            Assert.Equal(p1.Name, playerFromDB.Name);
            Assert.Equal(p1.Email, playerFromDB.Email);
        }

        [Fact()]
        public void GetPlayerByEmailTest_InsertIllegalEmail_ShouldThrowError()
        {
            //Assert
            Assert.Throws<IllegalEmailExeption>(() => playerRepository.GetPlayerByEmail("'SELECT * FROM BlackJack"));
        }

        public void Dispose()
        {
            playerContext.Database.EnsureDeleted();
        }
    }
}