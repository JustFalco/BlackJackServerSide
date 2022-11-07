// See https://aka.ms/new-console-template for more information

using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.DAL.DomainModels;
using DatabaseLayer.Repositories;


Console.WriteLine("Hello, World!");
Player player = new Player();
PlayerRepository repository = new PlayerRepository(new PlayerContext());
Console.Write("Naam: ");
player.Name = Console.ReadLine();

Console.WriteLine($"Hello {player.Name}");
repository.AddPlayerToDB(player);

Thread.Sleep(2000);

Console.WriteLine(repository.getAllPlayers());
