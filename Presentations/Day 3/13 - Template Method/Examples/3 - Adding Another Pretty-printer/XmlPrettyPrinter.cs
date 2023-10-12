namespace Wincubate.TemplateMethodExamples;

class XmlPrettyPrinter : PrettyPrinter
{
    protected override void PrintPreamble() =>
        Console.WriteLine(@"<?xml version=""1.0"" encoding=""UTF-8""?>");

    protected override void PrintBegin(string className) =>
        Console.WriteLine($"<{className}>");

    protected override void PrintEnd(string className) =>
        Console.WriteLine($"</{className}>");

    protected override void PrintProperty(string propertyName, object propertyValue) =>
        Console.WriteLine($"   <{propertyName}>{propertyValue}</{propertyName}>");
}