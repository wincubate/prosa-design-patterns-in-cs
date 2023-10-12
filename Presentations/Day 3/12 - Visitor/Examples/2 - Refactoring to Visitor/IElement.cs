namespace Wincubate.VisitorExamples;

interface IElement
{
    void Accept( IVisitor visitor );
}
