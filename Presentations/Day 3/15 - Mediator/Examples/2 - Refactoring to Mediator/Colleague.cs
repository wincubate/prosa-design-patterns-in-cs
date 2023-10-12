namespace Wincubate.MediatorExamples;

class Colleague : IColleague
{
    public string Name { get; }

    private readonly IMediator _mediator;
    private readonly IEnumerable<string> _topics;

    public Colleague(IMediator mediator, string name, params string[] topics)
    {
        _mediator = mediator;
        Name = name;
        _topics = topics.Select(t => t.Trim().ToLower());
    }

    public void Send(string messageContents) =>
        _mediator.Distribute(this, messageContents);

    public void Receive(IMessage message)
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