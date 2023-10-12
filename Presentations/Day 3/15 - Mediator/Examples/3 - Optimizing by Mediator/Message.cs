namespace Wincubate.MediatorExamples;

class Message : IMessage
{
    #region Instance Count

    public static int InstanceCount { get; set; }

    #endregion

    public string Sender { get; }
    public string Contents { get; }

    public Message( string sender, string contents )
    {
        Sender = sender;
        Contents = contents;

        InstanceCount++;
    }
}
