using System.Text.RegularExpressions;
using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.DAL.DomainModels;
using DatabaseLayer.Repositories;
using GameLibrary.Controllers;
using Microsoft.AspNetCore.SignalR;

namespace Services.Hubs;

public class GameHub : Hub
{
    private static IGameController _gameController;
    private readonly IPlayerController _playerController;

    public GameHub(IGameController gameController, IPlayerController playerController)
    {
        _gameController = gameController;
        _playerController = playerController;
    }

    public async Task CreateGame(string email)
    {
        Game game = _gameController.NewGame();
        _gameController.AddPlayerToGame(game.GameId, email);
        await Groups.AddToGroupAsync(Context.ConnectionId, game.GameId.ToString());
        await Clients.Caller.SendAsync("ReceiveCreatedMessage", game.GameId.ToString(), game.ToString());
    }

	public async Task JoinGame(string email, int gameId)
	{
        await Groups.AddToGroupAsync(Context.ConnectionId, gameId.ToString());
        _gameController.AddPlayerToGame(gameId, email);
        await Clients.Group(gameId.ToString()).SendAsync("ReceiveMessage", $"{email} has joined, waiting to start");
	}

    public async Task StartGame(int gameId)
    {
        await Clients.Group(gameId.ToString()).SendAsync("ReceiveStartedMessage", $"{_gameController.GetGame(gameId).getCurrentPlayer().Email}'s turn");
    }
}