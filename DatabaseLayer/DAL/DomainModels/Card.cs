using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Storage;

namespace DatabaseLayer.DAL.DomainModels;

public class Card
{
	public int Id { get; set; }
    [JsonIgnore]
    public CardValue Value { get; set; }
    [JsonIgnore]
    public CardColor Color { get; set; }
    [JsonIgnore]
    public CardType CardType { get; set; }
	public bool IsHidden { get; set; }
    public List<Hand> CardInHands { get; set; }

    public string CardName
    {
        get
        {
            if (IsHidden)
            {
                return "Hidden card";
            }
            return $"{Value.ToString().ToLower()} of {CardType.ToString().ToLower()}";
        }

    }
}