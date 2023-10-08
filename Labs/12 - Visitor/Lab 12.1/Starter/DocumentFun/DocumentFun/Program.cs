using DocumentFun;

Document document = new Document(
    new HeadingElement( "Welcome to Document Fun", 1 ),
    new RegularText( "Here is some plain text." ),
    new BoldText( "Here is some bold text." ),
    new Hyperlink( "Useful information", "http://www.ubrugelig.dk" )
);
