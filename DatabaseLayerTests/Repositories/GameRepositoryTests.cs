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
using Microsoft.EntityFrameworkCore.Infrastructure;
using Shared.Exeptions;

namespace DatabaseLayer.Repositories.Tests
{
	public class GameRepositoryTests : IDisposable
	{
		private GameRepository gameRepository;
		private GameContext gameContext;
		private string connectionString = $"Server=localhost;Port=3307;Database=BlackJackGameTestDB;Uid=root;Pwd=SecretPassword@01;";
		public GameRepositoryTests()
		{
			var builder = new DbContextOptionsBuilder<GameContext>();
			builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
			DbContextOptions<GameContext> options = builder.Options;
			gameContext = new GameContext(options);
			gameRepository = new GameRepository(gameContext);
		}

        private Game gameBuilder()
        {
            Game testGame = new Game();
            testGame.PlayersInGame.Add(new Player
            {
                Email = "FalcoTest",
                Name = "Falco"
            });
            testGame.Cards = new CardDeck();

            return testGame;
        }

		[Fact()]
		public async void SaveGameInDatabaseTest_insertEmptyGameInDatabase_ShouldThrowError()
		{
			//Arrange
			Game testGame = new Game();

			//Assert
			await Assert.ThrowsAsync<ArgumentNullException>(() => gameRepository.SaveGameInDatabase(testGame));
		}

		[Fact()]
		public async void SaveGameInDatabaseTest_insertNormalGameInDatabase_ShouldHaveSingleEntry()
		{
			//Arrange
            Game testGame = gameBuilder();

			//Act
			await gameRepository.SaveGameInDatabase(testGame);

			//Assert
			Assert.Single(gameContext.Games.ToList());
		}

		[Fact()]
		public void GetGameFromDatabaseTest_GetTheSecondGameFromTheDB_ShouldReturnGameObject()
        {
			//Arrange
            Game testGame1 = gameBuilder();
            Game testGame2 = gameBuilder();
            gameContext.Games.Add(testGame1);
            gameContext.Games.Add(testGame2);
            gameContext.SaveChanges();
            
            
            //Act
            Game gameFromDatabase = gameRepository.GetGameFromDatabase(1);

            //Assert
            Assert.Equal(testGame1.GameId, gameFromDatabase.GameId);
            Assert.Equal(testGame1.PlayersInGame.Count, gameFromDatabase.PlayersInGame.Count);
            Assert.Equal(testGame1.Cards.CardDeckId, gameFromDatabase.Cards.CardDeckId);
            Assert.Equal(testGame1.getCurrentPlayerId(), gameFromDatabase.getCurrentPlayerId());
        }

        [Fact()]
        public void GetGameFromDatabaseTest_GetNonExistingGameFromDatabase_ShouldThrowError()
        {
            Assert.Throws<NoEntitiesInDatabaseExeption>(() => gameRepository.GetGameFromDatabase(3456));
        }

		public void Dispose()
		{
			gameContext.Database.EnsureDeleted();
		}
	}
}