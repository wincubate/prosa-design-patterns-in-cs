namespace Wincubate.MediatorExamples;

class ColleagueInfo
{
    public IColleague Colleague { get; set; }
    public IEnumerable<string> Topics { get; set; }

    public ColleagueInfo( IColleague colleague, IEnumerable<string> topics )
    {
        Colleague = colleague;
        Topics = topics;
    }
}

class Mediator : IMediator
{
    private readonly IList<ColleagueInfo> _colleagues;

    public Mediator()
    {
        _colleagues = new List<ColleagueInfo>();
    }

    public void Register( IColleague colleague, params string[] topics )
    {
        _colleagues.Add( new ColleagueInfo(
            colleague,
            topics.Select(t => t.Trim().ToLower()))
        );
    }

    public void Distribute( IColleague sender, string messageContents )
    {
        IEnumerable<string> words =
            messageContents
                .ToLower()
                .Split(' ', '\n', '\r', '\t', ',', '.', '?', '!');
        var interested = _colleagues
            .Where(info => info.Colleague != sender)
            .Where(info => info.Topics.Intersect(words).Any())
            .Select(info => info.Colleague );

        foreach (Colleague colleague in interested)
        {
            IMessage message = new Message(sender.Name, messageContents);
            colleague.Receive(message);
        }
    }
}