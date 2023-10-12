namespace Wincubate.MediatorExamples;

interface IColleague
{
    string Name { get; }

    void Send(string messageContents);
    void Receive(IMessage message);
}
