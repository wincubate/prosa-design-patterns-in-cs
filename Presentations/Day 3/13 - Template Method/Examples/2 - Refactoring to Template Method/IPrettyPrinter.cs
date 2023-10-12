using System.Dynamic;

namespace Wincubate.TemplateMethodExamples;

interface IPrettyPrinter
{
    void Print( ExpandoObject obj, string name );
}
