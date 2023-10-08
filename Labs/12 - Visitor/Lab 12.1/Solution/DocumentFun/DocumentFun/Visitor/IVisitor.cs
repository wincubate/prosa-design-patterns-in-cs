namespace DocumentFun;

interface IVisitor
{
    void Visit( RegularText regular );
    void Visit( BoldText bold );
    void Visit( Hyperlink link );
    void Visit( HeadingElement heading );
}
