namespace Wincubate.MediatorExamples;

interface IMediator
{
    void Register(IColleague colleague);
    void Distribute(IColleague sender, string messageContents);
}
