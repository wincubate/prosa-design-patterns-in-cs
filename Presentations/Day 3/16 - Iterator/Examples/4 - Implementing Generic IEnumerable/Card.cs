namespace Wincubate.IteratorExamples;

readonly struct Card : IComparable
{
    public Suit Suit { get; }
    public Rank Rank { get; }

    public Card( Suit suit, Rank rank )
    {
        Suit = suit;
        Rank = rank;
    }

    public override string ToString()
    {
        char rankOutput;
        switch (Rank)
        {
            case Rank.Two:
            case Rank.Three:
            case Rank.Four:
            case Rank.Five:
            case Rank.Six:
            case Rank.Seven:
            case Rank.Eight:
            case Rank.Nine:
                {
                    rankOutput = (char)('2' + ((char)(Rank - Rank.Two)));
                    break;
                }
            case Rank.Ten:
                {
                    rankOutput = 'T';
                    break;
                }
            case Rank.Jack:
                {
                    rankOutput = 'J';
                    break;
                }
            case Rank.Queen:
                {
                    rankOutput = 'Q';
                    break;
                }
            case Rank.King:
                {
                    rankOutput = 'K';
                    break;
                }
            case Rank.Ace:
                {
                    rankOutput = 'A';
                    break;
                }
            default:
                {
                    rankOutput = '?';
                    break;
                }
        }

        char suitOutput;
        switch (Suit)
        {
            case Suit.Clubs:
                {
                    suitOutput = 'c';
                    break;
                }
            case Suit.Diamonds:
                {
                    suitOutput = 'd';
                    break;
                }
            case Suit.Hearts:
                {
                    suitOutput = 'h';
                    break;
                }
            case Suit.Spades:
                {
                    suitOutput = 's';
                    break;
                }
            default:
                {
                    suitOutput = '?';
                    break;
                }
        }

        return string.Format("{0}{1}",
           rankOutput,
           suitOutput);
    }

    #region IComparable Members

    public int CompareTo( object obj )
    {
        if (obj is Card other)
        {
            return Rank - other.Rank;
        }

        throw new ArgumentException("Can only compare Card to other Cards");
    }

    #endregion
}
