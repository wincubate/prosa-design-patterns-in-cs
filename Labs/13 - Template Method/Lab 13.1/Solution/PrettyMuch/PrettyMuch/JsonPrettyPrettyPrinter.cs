using Library;

namespace PrettyMuch;

class JsonPrettyPrettyPrinter : PrettyPrinter
{
    private bool _firstProperty;

    protected override void PrintBegin(string className)
    {
        _firstProperty = true;
        Console.Write("{ ");
    }

    protected override void PrintEnd( string className ) => Console.WriteLine(" }");

    protected override void PrintProperty( string propertyName, object propertyValue )
    {
        string separator = (_firstProperty ? "" : $",{Environment.NewLine}  ");
        Console.Write($"{separator}\"{propertyName}\": \"{propertyValue}\"");

        _firstProperty = false;
    }
}
