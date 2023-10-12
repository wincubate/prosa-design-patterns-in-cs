namespace Wincubate.MediatorExamples;

interface IColleague
{
    string Name { get; }

    void Register(IColleague colleague);
    void Send(string messageContents);
    void Receive(IMessage message);
}
