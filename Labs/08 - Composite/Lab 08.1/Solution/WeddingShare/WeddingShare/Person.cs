namespace WeddingShare;

class Person : IParticipant
{
    #region IParticipant Members

    public decimal MustPay { get; set; }

    #endregion

    public string Name { get; set; }

    public override string ToString() => $"{Name} pays {MustPay:c}";
    public Person(string name) => Name = name;
}
