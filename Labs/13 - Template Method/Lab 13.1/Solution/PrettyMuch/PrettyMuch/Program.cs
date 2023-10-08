﻿using System.Dynamic;
using Library;

dynamic person = new ExpandoObject();
person.FirstName = "Terry";
person.LastName = "Tate";
person.Occupation = "Office Linebacker";

IPrettyPrinter pp = new IniFilePrettyPrinter();
pp.Print(person, "Person");
