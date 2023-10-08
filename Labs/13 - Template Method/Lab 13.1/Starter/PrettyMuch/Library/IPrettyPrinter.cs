using System.Dynamic;

namespace Library;

public interface IPrettyPrinter
{
    void Print(ExpandoObject obj, string name);
}
