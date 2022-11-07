namespace GameLibrary.Models;

public class Hand{

	public List<Card> cardsInHand { get; set; }

	public Hand()
	{
		cardsInHand = new List<Card>();
	}

	public bool CanSplit()
	{
		throw new NotImplementedException();
	}

	public bool CanHit()
	{
		throw new NotImplementedException();
	}

	public bool CanDouble()
	{
		throw new NotImplementedException();
	}

	public void Add(Card card)
	{
		cardsInHand.Add(card);
	}
}