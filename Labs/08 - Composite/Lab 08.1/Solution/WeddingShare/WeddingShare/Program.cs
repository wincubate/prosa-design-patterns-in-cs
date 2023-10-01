// Group 1
using WeddingShare;

Person noah = new("Noah");
Person frederikke = new("Frederikke");
Person ane = new("Ane");
Person jesper = new("Jesper");

// Group 2
Person peter = new("Peter");
Person malene = new("Malene");

// Individuals
Person thomas = new("Thomas");
Person rasmus = new("Rasmus");
Person mads = new("Mads");

Group all = new(
    new Group(noah, frederikke, ane, jesper),
    new Group(peter, malene),
    thomas,
    rasmus,
    mads
);

// Share balanced by groups
decimal giftPrice = 2500;
all.MustPay = giftPrice;

// Print the bill
Console.WriteLine(all);





