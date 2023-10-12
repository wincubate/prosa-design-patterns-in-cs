namespace Wincubate.MediatorExamples;

interface IMediator
{
    void Register(IColleague colleague, params string[] topics);
    void Distribute(IColleague sender, string messageContents);
}
