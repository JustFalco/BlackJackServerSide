namespace GameLibrary.Models;

public class Card
{
    public CardValue Value { get; set; }
    public CardColor Color { get; set; }
    public CardType CardType { get; set; }
    public bool IsHidden { get; set; }
    public bool ActiveCard { get; set; } = true;



    public override string? ToString()
    {
        if (IsHidden)
        {
            return "Hidden card";
        }
        return $"{Color} {CardType} met waarde {Value}";
    }
}