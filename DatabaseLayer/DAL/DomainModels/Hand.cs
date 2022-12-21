namespace DatabaseLayer.DAL.DomainModels;

public class Hand
{
	public int HandId { get; set; }
	public bool IsActiveHand { get; set; }
	public List<Card> cardsInHand { get; set; }

    public List<string> getCurrentOptions()
    {
		List<string> options = new List<string>();

		options.Add("stand");
        if (CanSplit())
        {
			options.Add("split");
        }
        if (CanHit())
        {
            options.Add("split");
        }
        if (CanDouble())
        {
            options.Add("split");
        }
        return options;
    }

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