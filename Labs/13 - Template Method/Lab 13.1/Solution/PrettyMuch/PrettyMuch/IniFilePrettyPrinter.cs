namespace Library;

public class IniFilePrettyPrinter : PrettyPrinter
{
    protected override void PrintBegin(string className) =>
        Console.WriteLine( $"[{className}]");

    protected override void PrintEnd(string className) { }

    protected override void PrintProperty(string propertyName, object propertyValue) =>
        Console.WriteLine($"{propertyName}={propertyValue}");
}
