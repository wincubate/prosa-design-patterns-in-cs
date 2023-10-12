namespace Wincubate.MediatorExamples;

class Mediator : IMediator
{
    private readonly ISet<IColleague> _colleagues;

    public Mediator()
    {
        _colleagues = new HashSet<IColleague>();
    }

    public void Register(IColleague colleague) => _colleagues.Add(colleague);

    public void Distribute(IColleague sender, string messageContents)
    {
        foreach (IColleague colleague in _colleagues
            .Where(c => c != sender)
        )
        {
            IMessage message = new Message(sender.Name, messageContents);
            colleague.Receive(message);
        }
    }
}