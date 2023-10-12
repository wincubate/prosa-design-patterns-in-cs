namespace Wincubate.MediatorExamples;

class Colleague : IColleague
{
    public string Name { get; }

    private readonly IEnumerable<string> _topics;
    private readonly IList<IColleague> _colleagues;

    public Colleague( string name, params string[] topics )
    {
        Name = name;
        _topics = topics.Select(t => t.Trim().ToLower());
        _colleagues = new List<IColleague>();
    }

    public void Register( IColleague colleague ) => _colleagues.Add(colleague);

    public void Send( string messageContents )
    {
        foreach (IColleague colleague in _colleagues)
        {
            IMessage message = new Message(Name, messageContents);
            colleague.Receive(message);
        }
    }

    public void Receive( IMessage message )
    {
        IEnumerable<string> words =
            message.Contents
                .ToLower()
                .Split(' ', '\n', '\r', '\t', ',', '.', '?', '!');
        if (words.Intersect(_topics).Any())
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write($"@{Name} <-- {message.Sender}: ");
            Console.ResetColor();

            Console.WriteLine(message.Contents);
        }
    }
}
