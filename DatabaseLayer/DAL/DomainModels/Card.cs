using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLayer.DAL.DomainModels;

public class Card
{
	public int Id { get; set; }
    public CardValue Value { get; set; }
	public CardColor Color { get; set; }
	public CardType CardType { get; set; }
	public bool IsHidden { get; set; }
    public List<Hand> CardInHands { get; set; }
}