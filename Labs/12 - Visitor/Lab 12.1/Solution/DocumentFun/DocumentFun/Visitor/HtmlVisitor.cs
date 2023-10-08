using System.Text;

namespace DocumentFun;

class HtmlVisitor : IVisitor
{
    public StringBuilder Output { get; }

    public HtmlVisitor()
    {
        Output = new StringBuilder();
    }

    public void Visit( RegularText regular )
    {
        Output.AppendLine(regular.Text);
    }

    public void Visit( BoldText bold )
    {
        Output.AppendLine($"<b>{bold.Text}</b>");
    }

    public void Visit( Hyperlink link )
    {
        Output.AppendLine($"<a href=\"{link.Url}\">{link.Text}</a>");
    }

    public void Visit( HeadingElement heading )
    {
        Output.AppendLine($"<h{heading.Level}>{heading.Text}</h{heading.Level}>");
    }
}