namespace Wincubate.VisitorExamples;

interface IVisitor
{
    void Visit( Employee employee );
    void Visit( Project project );
}
