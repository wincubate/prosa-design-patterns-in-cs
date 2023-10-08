using System.Text;

namespace DocumentFun;

class TextVisitor : IVisitor
{
    public StringBuilder Output { get; }

    public TextVisitor()
    {
        Output = new StringBuilder();
    }


    public void Visit( RegularText regular )
    {
        Output.Append($"{regular.Text} ");
    }

    public void Visit( BoldText bold )
    {
        Output.Append($"--{bold.Text}-- ");
    }

    public void Visit( Hyperlink link )
    {
        Output.Append($"{link.Text}-->[{link.Url}] ");
    }

    public void Visit( HeadingElement heading )
    {
        Output.AppendLine($"{heading.Text.ToUpper()}");
    }
}
