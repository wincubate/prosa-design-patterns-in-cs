using System.Collections;

namespace Wincubate.PrototypeExamples;

class Deck : IEnumerable<Card>
{
    private List<Card> _cards;

    #region IEnumerable Members

    public IEnumerator<Card> GetEnumerator()
    {
        foreach (Card card in _cards)
        {
            yield return card;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    #endregion

    public override string ToString() => string.Join(" ", _cards);

    public Deck()
    {
        _cards = new List<Card>();

        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                Card card = new(suit, rank);
                _cards.Add(card);
            }
        }
    }

    public Card TakeCard()
    {
        if (_cards.Count > 0)
        {
            Card top = _cards[0];
            _cards.RemoveAt(0);

            return top;
        }

        throw new InvalidOperationException("Deck is empty");
    }

    public void Shuffle()
    {
        Random random = new();
        for (int i = 0; i < _cards.Count; i++)
        {
            int j = random.Next(_cards.Count);
            SwapCards(i, j);
        }
    }

    public void SwapCards( int position, int otherPosition )
    {
        (_cards[otherPosition], _cards[position])
            = (_cards[position], _cards[otherPosition]);
    }
}