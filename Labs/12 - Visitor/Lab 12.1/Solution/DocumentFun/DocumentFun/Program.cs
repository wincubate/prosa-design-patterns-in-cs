using DocumentFun;

Document document = new(
    new HeadingElement( "Welcome to Document Fun", 1 ),
    new RegularText( "Here is some plain text." ),
    new BoldText( "Here is some bold text." ),
    new Hyperlink( "Useful information", "http://www.ubrugelig.dk" )
);

//HtmlVisitor visitor = new HtmlVisitor();
//document.Accept(visitor);
//Console.WriteLine( visitor.Output.ToString() );

TextVisitor visitor = new();
document.Accept(visitor);
Console.WriteLine(visitor.Output.ToString());
Console.WriteLine();
