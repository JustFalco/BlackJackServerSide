namespace DatabaseLayer.DAL.DomainModels;

public class Hand
{
	public int HandId { get; set; }
	public bool IsActiveHand { get; set; }
	public List<Card> cardsInHand { get; set; }

	public Hand()
	{
		cardsInHand = new List<Card>();
		IsActiveHand = true;
	}

	public void StandBust()
	{
		IsActiveHand = false;
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