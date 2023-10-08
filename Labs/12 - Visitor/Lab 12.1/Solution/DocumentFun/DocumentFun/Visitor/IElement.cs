namespace DocumentFun;

interface IElement
{
    void Accept( IVisitor visitor );
}
