using System.Dynamic;

using Wincubate.TemplateMethodExamples;

dynamic person = new ExpandoObject();
person.FirstName = "Terry";
person.LastName = "Tate";
person.Occupation = "Office Linebacker";

XmlPrettyPrinter pp = new();

pp.PrintPreamble();

pp.PrintBegin(nameof(person));

foreach (KeyValuePair<string, object> kvp in (IDictionary<string, object>) person)
{
    pp.PrintProperty(kvp.Key, kvp.Value);
}

pp.PrintEnd(nameof(person));
