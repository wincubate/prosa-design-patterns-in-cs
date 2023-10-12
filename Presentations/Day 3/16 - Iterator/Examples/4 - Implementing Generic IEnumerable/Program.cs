using Wincubate.IteratorExamples;

Deck deck = new();
deck.Shuffle();

//IEnumerator enumerator = deck.GetEnumerator();
//enumerator.Reset();
//while( enumerator.MoveNext() )
//{
//    Console.Write($"{enumerator.Current} ");
//}

foreach (Card card in deck)
{
    Console.Write($"{card} ");
}

//var query = deck.Where(c => c.Suit == Suit.Hearts);
//foreach (Card card in query)
//{
//    Console.Write($"{card} ");
//}
