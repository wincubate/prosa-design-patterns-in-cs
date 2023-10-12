using System.Dynamic;
using Wincubate.TemplateMethodExamples;

dynamic person = new ExpandoObject();
person.FirstName = "Terry";
person.LastName = "Tate";
person.Occupation = "Office Linebacker";

//dynamic person2 = new ExpandoObject();
//person2.FirstName = "Bruce";
//person2.LastName = "Campbell";
//person2.Occupation = "Jefe";

PrettyPrinter pp = new XmlPrettyPrinter();
pp.Print(person, "Person");
