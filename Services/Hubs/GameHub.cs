using System.Text.RegularExpressions;
using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.Repositories;
using GameLibrary.Controllers;
using Microsoft.AspNetCore.SignalR;

namespace Services.Hubs;

public class GameHub : Hub
{
    private static GameController _gameController;

    public GameHub(GameController gameController)
    {
		_gameController = gameController;
    }

	public async Task JoinGame(string email, int gameId)
	{
		int gameRoomCode = gameId;


		if (!_gameController.CheckIfGameExists(gameRoomCode))
		{
			gameRoomCode = _gameController.NewGame();
		}
		
		//_gameController.AddPlayerToGame(gameRoomCode, email);

		await Groups.AddToGroupAsync(Context.ConnectionId, gameId.ToString());

		await Clients.Group(gameId.ToString()).SendAsync("ReceiveMessage", $"{email} has joined, waiting to start");
	}
}