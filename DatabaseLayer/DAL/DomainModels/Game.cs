using GameLibrary.Models;

namespace DatabaseLayer.DAL.DomainModels;

public class Game
{
	//private Dealer dealer;
	public Player player { get; set; }
	public CardDeck cards { get; set; }
	public bool isActiveGame { get; set; }

	public Game()
	{
		
	}

	public override string ToString()
	{
		string returnString = player + "\n";
		return returnString;
	}
}