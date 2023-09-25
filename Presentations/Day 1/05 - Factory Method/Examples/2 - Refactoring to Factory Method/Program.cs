using Wincubate.FactoryMethodExamples;

Publication fiction = new Book("Harry Porter goes Beer-binging");
fiction.Print();

Console.WriteLine();

Publication technicalBook = new TechnicalBook("Gang of Four Design Patterns in C#");
technicalBook.Print();

Console.WriteLine();

Publication tabloid = new Tabloid("Krazy W00rld");
tabloid.Print();
