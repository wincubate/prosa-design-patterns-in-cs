using Wincubate.MediatorExamples;

IMediator mediator = new Mediator();

IColleague c1 = new Colleague(mediator, "Alice");
IColleague c2 = new Colleague(mediator, "Bob");
IColleague c3 = new Colleague(mediator, "Clyde");

#region Spammer

//IColleague c4 = new Colleague(mediator, "Spammer");
//mediator.Register(c4);

#endregion

mediator.Register(c1, "pattern", "shop", "beer");
mediator.Register(c2, "pattern", "beer");
mediator.Register(c3, "awesome");

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

// We are however SLIGHTLY cheating here, because Colleague -> Mediator
// is not counted... But... :-)
Console.WriteLine($"{Message.InstanceCount} message(s) were sent");

