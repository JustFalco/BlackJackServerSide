namespace DatabaseLayer.DAL.DomainModels;

public class Game
{
	public int GameId { get; set; }
	//private Dealer dealer;
	public List<Player> PlayersInGame { get; set; }

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

    public Player? getCurrentPlayer()
    {
        foreach (var player in PlayersInGame)
        {
            if (player.GetFirstActiveHand() != null)
                return player;
        }

        return null;
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

    public void ResetGame()
    {
        foreach (var player in PlayersInGame)
        {
            if (player.Email != "Dealer")
            {
                player.Reset();
            }

        }

        PlayersInGame.RemoveAll(d => d.Email == "Dealer");
    }
}