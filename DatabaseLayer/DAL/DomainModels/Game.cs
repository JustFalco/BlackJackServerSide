namespace DatabaseLayer.DAL.DomainModels;

public class Game
{
	public int GameId { get; set; }
	//private Dealer dealer;
	public List<Player> PlayersInGame { get; set; }
	public CardDeck Cards { get; set; }
	public bool IsActiveGame { get; set; }

	public int CurrentPlayerIndex { get; set; }

    public Game()
	{
		if (PlayersInGame == null)
		{
			PlayersInGame = new List<Player>();
		}
	}

    public int getCurrentPlayerId()
    {
        return PlayersInGame.ElementAt(CurrentPlayerIndex).PlayerId;
    }
}