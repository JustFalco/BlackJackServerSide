namespace DatabaseLayer.DAL.DomainModels;

public class Hand
{
	public int HandId { get; set; }
	public bool IsActiveHand { get; set; }
	public List<Card> cardsInHand { get; set; }

    public List<string> getCurrentOptions()
    {
		List<string> options = new List<string>();

		
        if (CanSplit())
        {
			options.Add("split");
        }
        if (CanHit())
        {
            options.Add("hit");
        }
        if (CanDouble())
        {
            options.Add("double");
        }
        options.Add("stand");
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

	public bool CanSplit(){
        if (cardsInHand.Count == 2)
        {
            if ((int)cardsInHand.First().Value == (int)cardsInHand.Last().Value)
            {
                return true;
            }
        }

        return false;
    }

	public bool CanHit()
	{
        if (GetLowestValue() <= 21)
        {
            return true;
        }
        return false;
	}

	public bool CanDouble()
	{
        if (cardsInHand.Count == 2 && GetLowestValue() <= 11)
        {
            return true;
        }
        return false;
	}

	public void Add(Card card)
	{
		cardsInHand.Add(card);
	}

    public int GetHighestValue()
    {
        int value = 0;
        foreach (Card card in cardsInHand)
        {
            if (card.Value == 0)
            {
                value += 11;
            }
            else if (((int)card.Value + 1) >= 10)
            {
                value += 10;
            }
            else
            {
                value += (int)card.Value;
            }
        }

        return value;
    }

    public int GetLowestValue()
    {
        if (cardsInHand.Count == 2 && GetHighestValue() == 22)
        {
            return 2;
        }
        
        return GetHighestValue() - 10;
    }
}