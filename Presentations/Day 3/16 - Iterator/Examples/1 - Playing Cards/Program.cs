using Wincubate.IteratorExamples;

Deck deck = new();
deck.Shuffle();
Card card = deck.Deal();
Console.WriteLine( card );
