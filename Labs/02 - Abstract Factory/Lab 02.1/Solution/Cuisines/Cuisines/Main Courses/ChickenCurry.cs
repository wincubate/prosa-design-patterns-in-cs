namespace Cuisines;

class ChickenCurry : IMainCourse
{
    public int Spicyness { get; }

    public ChickenCurry( int spicyness )
    {
        Spicyness = spicyness;
    }

    public void Consume()
    {
        Console.WriteLine( $"Eating delicious and h{new string('o', Spicyness)}ot dish with naan and rice");
    }
}
