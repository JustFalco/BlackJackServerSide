// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;
using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.DAL.DomainModels;
using DatabaseLayer.Repositories;
using Microsoft.AspNetCore.SignalR.Client;
namespace Test;

class Program
{
	static void Main(string[] args)
	{
		var connection = new HubConnectionBuilder()
			.WithUrl("https://localhost:49155/gameHub")
			.Build();

		connection.StartAsync().Wait();

		Console.Write("Email: ");
		string email = Console.ReadLine();

		Console.Write("Room: ");
		int roomKey = int.Parse(Console.ReadLine());
		connection.InvokeAsync("JoinGame", email, roomKey);

		connection.On("ReceiveMessage", (string arg1) =>
		{
			Console.WriteLine(arg1);
		});

		Console.ReadKey();
	}

	void testmethod()
	{
		Console.WriteLine("Hello, World!");
		Player player = new Player();
		Game game = new Game();

		GameContext gameContext = new GameContext();
		PlayerRepository repository = new PlayerRepository(gameContext);
		GameRepository gameRepository = new GameRepository(gameContext);
		Console.Write("Naam: ");
		player.Name = Console.ReadLine();

		Console.Write("Email: ");
		player.Email = Console.ReadLine();

		Console.WriteLine($"Hello {player.Name}");
		repository.AddPlayerToDB(player);

		game.PlayersInGame.Add(player);
		/*game.cards = new CardDeck();
		game.isActiveGame = true;*/
		gameRepository.SaveGameInDatabase(game);
		Thread.Sleep(2000);

		Console.WriteLine(repository.getAllPlayers());
	}
}



