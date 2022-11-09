namespace DatabaseLayer.DAL.DomainModels;

public class Game
{
	public int GameId { get; set; }
	//private Dealer dealer;
	public List<Player> PlayersInGame { get; set; }
	public CardDeck cards { get; set; }
	public bool isActiveGame { get; set; }

	public int CurerntPlayerId { get; set; }

	public Game()
	{
		if (PlayersInGame == null)
		{
			PlayersInGame = new List<Player>();
		}
	}
}