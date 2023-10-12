using System.Collections;

namespace Wincubate.IteratorExamples;

class Deck : IEnumerable
{
    private readonly List<Card> _cards;

    #region IEnumerable Members

    public IEnumerator GetEnumerator()
    {
        return _cards.GetEnumerator();

        #region Please kill me...!

        //yield return _cards[0];
        //yield return _cards[1];
        //yield return _cards[2];
        //yield return _cards[3];
        //yield return _cards[4];
        //yield return _cards[5];
        //yield return _cards[6];
        //yield return _cards[7];
        // ...

        #endregion

        #region yield

        //int i = 0;
        //while (true)
        //{
        //    yield return _cards[i++];
        //    if (i == _cards.Count)
        //    {
        //        yield break;
        //    }
        //}

        #endregion
    }

    #endregion

    public Deck()
    {
        _cards = new List<Card>();

        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                _cards.Add(new Card(suit, rank));
            }
        }
    }

    public Card Deal()
    {
        if (_cards.Any())
        {
            Card top = _cards[0];
            _cards.RemoveAt(0);
            return top;
        }

        throw new InvalidOperationException("No more cards left to deal");
    }

    public void Shuffle()
    {
        Random random = new Random((int)DateTime.Now.Ticks);
        for (int i = 0; i < _cards.Count; i++)
        {
            int j = random.Next(_cards.Count);
            (_cards[j], _cards[i]) = (_cards[i], _cards[j]);
        }
    }
}
