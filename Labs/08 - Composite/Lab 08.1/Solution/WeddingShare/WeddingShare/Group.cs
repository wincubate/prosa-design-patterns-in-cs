namespace WeddingShare;

class Group : IParticipant
{
    #region IParticipant Members

    public decimal MustPay
    {
        get => _mustPay;
        set
        {
            _mustPay = value;

            decimal amount = value / Participants.Count();
            foreach (IParticipant participant in Participants)
            {
                participant.MustPay = amount;
            }
        }
    }
    private decimal _mustPay;

    #endregion

    public IEnumerable<IParticipant> Participants { get; }

    public override string ToString() =>
        string.Join(Environment.NewLine,
            Participants.Select(p => p.ToString())
        );

    public Group(params IParticipant[] participants)
    {
        Participants = participants;
    }
}