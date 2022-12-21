using System.ComponentModel.DataAnnotations.Schema;
using DatabaseLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLayer.DAL.DomainModels;

public class CardDeck
{
	public int CardDeckId { get; set; }

    public List<Card> Cards { get; set; }


    public int previousIndex = 0;

    public CardDeck()
	{
		if (Cards == null)
		{
			Cards = new List<Card>();
		}

        ShuffleDeck();
	}

	public Card getCard(int index)
	{
		return Cards.ElementAt(index);
	}

	
	public void ShuffleDeck()
	{
		var rnd = new Random();
		Cards = Cards.OrderBy(item => rnd.Next()).ToList();
	}

    public Card? GetFirstActiveCardOnDeck()
	{
		//TODO dit gaat voor errors zorgen
		Card card = Cards.Where(card => card.ActiveCard == true).First();
		card.ActiveCard = false;
		return card;
	}
}

public enum CardColor
{
	BLACK,
	RED
}

public enum CardType
{
	CLUBS,
	HEART,
	SPADES,
	DIAMONDS
}

public enum CardValue
{
	TWO,
	THREE,
	FOUR,
	FIVE,
	SIX,
	SEVEN,
	EIGHT,
	NINE,
	TEN,
	JACK,
	QUEEN,
	KING,
	ACE
}