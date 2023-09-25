namespace Wincubate.PrototypeExamples;

enum Suit
{
    Spades,
    Clubs,
    Hearts,
    Diamonds
}

enum Rank
{
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
    Ace
}

class Card : ICloneable
{
    public Suit Suit { get; }
    public Rank Rank { get; }

    #region ICloneable Members

    //public object Clone() => new Card(Suit, Rank);

    // ...or...

    public object Clone() => (Card) this.MemberwiseClone();

    #endregion

    public Card( Suit suit, Rank rank )
    {
        Suit = suit;
        Rank = rank;
    }

    public override string ToString()
    {
        var rankOutput = Rank switch
        {
            Rank.Two or Rank.Three or Rank.Four or Rank.Five or Rank.Six or Rank.Seven or Rank.Eight or Rank.Nine => (char)('2' + ((char)(Rank - Rank.Two))),
            Rank.Ten => 'T',
            Rank.Jack => 'J',
            Rank.Queen => 'Q',
            Rank.King => 'K',
            Rank.Ace => 'A',
            _ => '?',
        };
        var suitOutput = Suit switch
        {
            Suit.Clubs => 'c',
            Suit.Diamonds => 'd',
            Suit.Hearts => 'h',
            Suit.Spades => 's',
            _ => '?',
        };
        return $"{rankOutput}{suitOutput}";
    }
}