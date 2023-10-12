namespace Wincubate.TemplateMethodExamples;

class XmlPrettyPrinter
{
    public void PrintPreamble() =>
        Console.WriteLine(@"<?xml version=""1.0"" encoding=""UTF-8""?>");

    public void PrintBegin( string className ) =>
        Console.WriteLine($"<{className}>");

    public void PrintEnd( string className ) =>
        Console.WriteLine($"</{className}>");

    public void PrintProperty( string propertyName, object propertyValue ) =>
        Console.WriteLine($"   <{propertyName}>{propertyValue}</{propertyName}>");
}
