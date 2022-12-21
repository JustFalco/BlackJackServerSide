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
        return getCurrentPlayer().Id;
    }

    public Player getCurrentPlayer()
    {
        return PlayersInGame.ElementAt(CurrentPlayerIndex);
    }

    public override string ToString()
    {
        string returnString = string.Empty;

        returnString += "players: ";
        foreach (var player in PlayersInGame)
        {
            returnString += "\n\t" + player;
        }
        

        return returnString;
    }
}