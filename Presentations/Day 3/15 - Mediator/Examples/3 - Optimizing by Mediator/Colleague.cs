namespace Wincubate.MediatorExamples;

class Colleague : IColleague
{
    public string Name { get; }

    private readonly IMediator _mediator;

    public Colleague(IMediator mediator, string name)
    {
        _mediator = mediator;
        Name = name;
    }

    public void Send(string messageContents) =>
        _mediator.Distribute(this, messageContents);

    public void Receive(IMessage message)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write($"@{Name} <-- {message.Sender}: ");
        Console.ResetColor();

        Console.WriteLine(message.Contents);
    }
}