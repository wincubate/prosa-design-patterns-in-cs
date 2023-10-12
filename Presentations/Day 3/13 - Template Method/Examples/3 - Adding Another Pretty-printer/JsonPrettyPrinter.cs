namespace Wincubate.TemplateMethodExamples;

class JsonPrettyPrinter : PrettyPrinter
{
    private bool _firstProperty;

    protected override void PrintBegin(string className)
    {
        _firstProperty = true;
        Console.Write("{");
    }

    protected override void PrintEnd( string className ) => Console.WriteLine("}");

    protected override void PrintProperty( string propertyName, object propertyValue )
    {
        string commaOrNot = (_firstProperty ? "" : ",");
        Console.Write( $"{commaOrNot}\"{propertyName}\":\"{propertyValue}\"");

        _firstProperty = false;
    }
}