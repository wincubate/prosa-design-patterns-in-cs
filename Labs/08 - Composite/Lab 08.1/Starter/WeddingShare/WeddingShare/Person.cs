namespace WeddingShare;

class Person
{
    public string Name { get; set; }
    public decimal MustPay { get; set; }

    public override string ToString() => $"{Name} pays {MustPay:c}";

    public Person( string name ) => Name = name;
}
