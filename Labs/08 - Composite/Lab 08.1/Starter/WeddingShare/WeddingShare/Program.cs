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

List<Person> participants = new()
{
    noah,
    frederikke,
    ane,
    jesper,

    peter,
    malene,

    thomas,
    rasmus,
    mads
};

decimal giftPrice = 2500;

// Equal sharing among all participants
foreach (Person person in participants)
{
    person.MustPay = giftPrice / participants.Count;
}

// Print the bill
foreach (Person person in participants)
{
    Console.WriteLine( person );
}
