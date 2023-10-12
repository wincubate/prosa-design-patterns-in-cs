using System.Dynamic;
using Wincubate.TemplateMethodExamples;

dynamic person = new ExpandoObject();
person.FirstName = "Terry";
person.LastName = "Tate";
person.Occupation = "Office Linebacker";

IPrettyPrinter pp = new JsonPrettyPrinter();
pp.Print(person, "Person");
