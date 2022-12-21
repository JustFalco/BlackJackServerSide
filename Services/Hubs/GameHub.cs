using System.Security.Claims;
using System.Text.RegularExpressions;
using DatabaseLayer.DAL.Contexts;
using DatabaseLayer.DAL.DomainModels;
using DatabaseLayer.Repositories;
using GameLibrary.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;

namespace Services.Hubs;


public class GameHub : Hub
{
    private static IGameController _gameController;
    private readonly IPlayerController _playerController;
    private readonly UserManager<Player> _userManager;

    public GameHub(IGameController gameController, IPlayerController playerController, UserManager<Player> userManager)
    {
        _gameController = gameController;
        _playerController = playerController;
        _userManager = userManager;
    }

    [Authorize]
    public async Task CreateGame()
    {
        Game game = null;
        try
        {
            game = await _gameController.NewGame();
            if (game == null)
            {
                throw new ArgumentException("Game cannot be null");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            await Clients.Caller.SendAsync("Error", "Could not create or save new game");
        }

        try
        {
            var player = await _userManager.FindByEmailAsync(Context.UserIdentifier);
            _gameController.AddPlayerToGame(player, game.GameId);
            await Groups.AddToGroupAsync(Context.ConnectionId, game.GameId.ToString());
            await Clients.Caller.SendAsync("ReceiveCreatedMessage", player, game);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            await Clients.Caller.SendAsync("Error", "Could not add player to game");
        }
       
    }

    [Authorize]
    public async Task JoinGame(int gameId)
	{
        Console.WriteLine("Joining the game");
        try
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, gameId.ToString());
            var player = await _userManager.FindByEmailAsync(Context.UserIdentifier);
            _gameController.AddPlayerToGame(player, gameId);
            await Clients.Group(gameId.ToString()).SendAsync("ReceiveMessage", $"{player.Email} has joined, waiting to start");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            await Clients.Group(gameId.ToString()).SendAsync("Error", e.Message);
        }
        
	}

    [Authorize]
    public async Task StartTheGame(int gameId)
    {
        Console.WriteLine("Starting the game");
        try
        {
            var game = _gameController.GetGame(gameId);
            await Clients.Group(gameId.ToString()).SendAsync("ReceiveStartedMessage", "Game has started!");
            await Clients.Group(gameId.ToString()).SendAsync("CurrentUser", game.getCurrentPlayer(), game.getCurrentPlayer().GetFirstActiveHand().getCurrentOptions());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            await Clients.Group(gameId.ToString()).SendAsync("Error", e.Message);
        }
        
    }

    [Authorize]
    public async Task UserChoice(string choice, int gameId)
    {
        var game = _gameController.GetGame(gameId);
        var player = await _userManager.FindByEmailAsync(Context.UserIdentifier);

        if (game.getCurrentPlayer().Id == player.Id)
        {
            game = _gameController.PlayGame(choice, gameId);
        }

        await Clients.Group(gameId.ToString()).SendAsync("CurrentUser", game.getCurrentPlayer(), game.getCurrentPlayer().GetFirstActiveHand().getCurrentOptions());
        await Clients.Group(gameId.ToString()).SendAsync("CurrentGame", game);
    }
}