namespace Wincubate.MediatorExamples;

interface IMessage
{
    string Sender { get; }
    string Contents { get; }
}
