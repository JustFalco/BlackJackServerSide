using DatabaseLayer.DAL.DomainModels;
using Shared.DTOs;

namespace GameLibrary.Controllers;

public interface IPlayerController
{
    Task<Player> NewPlayer(PlayerDTO playerData);
    void Hit(Player player);
    void Stand(Player player);
    void Double(Player player);
    void Split(Player player);
}