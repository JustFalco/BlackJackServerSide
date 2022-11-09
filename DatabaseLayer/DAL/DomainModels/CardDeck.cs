using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.DAL.DomainModels;

public class CardDeck
{
	public int CardDeckId { get; set; }

	public List<Card> Deck { get; set; }

	public CardDeck()
	{
		if (Deck == null)
		{
			Deck = new List<Card>();
		}

		foreach (Enum type in Enum.GetValues(typeof(CardType)))
		{
			foreach (Enum value in Enum.GetValues(typeof(CardValue)))
			{
				CardColor color;

				if ((CardType)type == CardType.SPADES || (CardType)type == CardType.CLUBS)
				{
					color = CardColor.BLACK;
				}
				else
				{
					color = CardColor.RED;
				}

				Card card = new Card
				{
					ActiveCard = true,
					CardType = (CardType)type,
					Value = (CardValue)value,
					Color = color
				};

				Deck.Add(card);
			}
		}

		ShuffleDeck();
	}

	public Card getCard(int index)
	{
		return Deck[index];
	}

	
	public void ShuffleDeck()
	{
		var rnd = new Random();
		Deck = Deck.OrderBy(item => rnd.Next()).ToList();
	}

	public CardDeck StackAllCardDecks(List<CardDeck> cardsInGame)
	{
		CardDeck allCardsStacked = new CardDeck();
		foreach (CardDeck cardDeck in cardsInGame)
		{
			foreach (Card card in Deck)
			{
				allCardsStacked.Deck.Add(card);
			}
		}

		allCardsStacked.ShuffleDeck();

		return allCardsStacked;
	}

	public Card? GetFirstActiveCardOnDeck()
	{
		Card card = Deck.Where(card => card.ActiveCard == true).First();
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