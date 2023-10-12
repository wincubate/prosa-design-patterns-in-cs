using Wincubate.MediatorExamples;

IColleague c1 = new Colleague("Alice", "pattern", "shop", "beer");
IColleague c2 = new Colleague("Bob", "pattern", "beer");
IColleague c3 = new Colleague("Clyde", "awesome");

#region Spammer

//IColleague c4 = new Colleague("Spammer");
//c1.Register(c4);
//c2.Register(c4);
//c3.Register(c4);
//c4.Register(c1);
//c4.Register(c2);
//c4.Register(c3);

#endregion

c1.Register(c2);
c1.Register(c3);
c2.Register(c1);
c2.Register(c3);
c3.Register(c1);
c3.Register(c2);

c1.Send("A pattern is emerging");
c2.Send("Wanna get an awesome BEER?");
c3.Send("Does anybody care?");
c3.Send("Does anybody care?");

#region Spammer

//c4.Send("$$$");
//c4.Send("Get rich fast!");
//c4.Send("Enlarge your p***s");

#endregion

Console.ReadLine();

Console.WriteLine($"{Message.InstanceCount} message(s) were sent");
